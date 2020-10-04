using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

class clsDlgEditSimple: IDisposable
{
    private string procedureName { get; set; }
    private DataGridView gridView { get; set; }
    private string IdFieldName { get; set; }
    private Button btnОбновить { get; set; }
    private Button btnДобавить { get; set; }
    private Button btnИзменить { get; set; }
    private Button btnУдалить { get; set; }
    private string dlgEditForm { get; set; }

    /// <summary>
    /// Класс обработчик типовых диалогов "Добавить, Изменить, Удалить"
    /// </summary>
    /// <param name="btnОбновить"></param>
    /// <param name="btnДобавить"></param>
    /// <param name="btnИзменить"></param>
    /// <param name="btnУдалить"></param>
    /// <param name="gridView"></param>
    /// <param name="IdFieldName">Имя ключевогополя в таблице</param>
    /// <param name="procedureName">Имя процедуры SIUD</param>
    /// <param name="dlgEditForm">Форма диалог</param>
    public clsDlgEditSimple(Button btnОбновить,
                            Button btnДобавить,
                            Button btnИзменить,
                            Button btnУдалить,
                            DataGridView gridView, 
                            string IdFieldName, 
                            string procedureName, 
                            string dlgEditForm, Action settingGridView)
    {
        this.btnОбновить = btnОбновить;
        this.btnДобавить = btnДобавить;
        this.btnИзменить = btnИзменить;
        this.btnУдалить = btnУдалить;

        this.gridView = gridView;
        this.IdFieldName = IdFieldName;
        this.procedureName = procedureName;
        this.dlgEditForm = dlgEditForm;

        this.Обновить();
        settingGridView();

        RemoveHandlerList(this.btnОбновить);
        RemoveHandlerList(this.btnДобавить);
        RemoveHandlerList(this.btnИзменить);
        RemoveHandlerList(this.btnУдалить);

        this.btnОбновить.Click += ОбновитьClick;
        this.btnДобавить.Click += ДобавитьClick;
        this.btnИзменить.Click += ИзменитьClick;
        this.btnУдалить.Click += УдалитьClick;
        gridView.MouseClick += gridView_MouseClick;

        ASTimer timer = new ASTimer(gridView,
                                    new List<Button> { this.btnИзменить, this.btnУдалить }
                                    );
    }

    private void ДобавитьClick(object sender, EventArgs e)
    {
        // форма из переменной 
        Type myDlgForm = Type.GetType(this.dlgEditForm);
        ConstructorInfo constructor = myDlgForm.GetConstructor(new Type[] { });
        Form form = (Form)constructor.Invoke(new object[] { });

        // параметры запроса передаем через Тэг формы
        var QueryParameters = new Dictionary<string, clsMisc.ASSqlFunction>();
        QueryParameters.Add(String.Empty, clsMisc.ASSqlFunction.Insert);
        form.Tag = QueryParameters;

        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
            Обновить(clsMisc.DBout(form.Tag));
        }
    }

    private void ИзменитьClick(object sender, EventArgs e)
    {
        // форма из переменной 
        Type myForm = Type.GetType(this.dlgEditForm);
        ConstructorInfo constructor = myForm.GetConstructor(new Type[] { });
        Form form = (Form)constructor.Invoke(new object[] { });

        var QueryParameters = new Dictionary<string, clsMisc.ASSqlFunction>();
        QueryParameters.Add(gridView[this.IdFieldName, gridView.CurrentRow.Index].Value.ToString(), clsMisc.ASSqlFunction.Update);
        form.Tag = QueryParameters;

        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
            Обновить(clsMisc.DBout(form.Tag));
        }
    }

    private void УдалитьClick(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                                Program.ProductName,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery(this.procedureName,
                clsMisc.ASSqlFunction.Delete, $"@{IdFieldName}",
                gridView[IdFieldName, gridView.CurrentRow.Index].Value.ToString());

            Обновить();
        }
    }

    private void Обновить(object Idvalue = null)
    {
        var dt = clsSql.ExecuteSP(this.procedureName, clsMisc.ASSqlFunction.ViewForm).dataTable;
        this.gridView.ASОбновитьСохранитьВыделение(dt, this.IdFieldName, Idvalue);
    }

    private void ОбновитьClick(object sender, EventArgs e) { Обновить(); }


    private void gridView_MouseClick(object sender, MouseEventArgs e)
    {
        var menu = new ContextMenuStrip();
        e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьClick, ИзменитьClick, УдалитьClick);
    }

    public void RemoveHandlerList(Control c)
    {
        EventHandlerList list = (EventHandlerList)typeof(Control).GetProperty("Events", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(c);
        typeof(EventHandlerList).GetMethod("Dispose").Invoke(list, null);
    }

    #region IDisposable Support
    private bool disposedValue = false; // Для определения избыточных вызовов
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing) { }
            disposedValue = true;
        }
    }
    void IDisposable.Dispose() { Dispose(true); }
    #endregion

}
