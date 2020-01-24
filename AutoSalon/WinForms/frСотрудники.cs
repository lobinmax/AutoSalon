using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


public partial class frСотрудники : DevExpress.XtraEditors.XtraForm
{
    public frСотрудники()
    {
        InitializeComponent();
    }

    private void frСотрудники_Load(object sender, EventArgs e)
    {
        using (var d = new DevExpress.Utils.WaitDialogForm("Идет загрузка ...", "Пожалуйста, подождите"))
        {
            Обновить();
            gridViewСотрудники.BestFitColumns();
            gridViewСотрудники.ASНастроитьGridView(gridColumnVisible: "UIDСотрудника");
            ASTimer timer = new ASTimer(gridViewСотрудники, 
                                        new List<SimpleButton> { simpleButtonИзменить, simpleButtonУдалить }
                                        ) { Enabled = true };
        }
    }

    void Обновить(object value = null)
    {
        var dt = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        gridViewСотрудники.ASОбновитьСохранитьВыделение(dt, "UIDСотрудника", value);       
    }

    private void simpleButtonОбновить_Click(object sender, EventArgs e) { Обновить(); }

    private void gridViewСотрудники_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
    {
        e.МенюДляAddEditDelete(new DXPopupMenu(), ДобавитьСотрудника, РедактироватьСотрудника, УдалитьСотрудника);
    }

#region Кнопки управления и контекстное меню  

    void ДобавитьСотрудника(object sender, EventArgs e) 
    {
        using (var editСотрудник = new dlgEditСотрудник(gridViewСотрудники.GetFocusedRowCellDisplayText("UIDСотрудника").ToString(), clsMisc.ASSqlFunction.Insert))
        {
            var result = editСотрудник.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Обновить(editСотрудник.NewRecord);
            }
        }      
    }

    private void simpleButtonДобавить_Click(object sender, EventArgs e) { ДобавитьСотрудника(sender, e); }

    void РедактироватьСотрудника(object sender, EventArgs e)
    {
        using (var editСотрудник = new dlgEditСотрудник(gridViewСотрудники.GetFocusedRowCellDisplayText("UIDСотрудника").ToString(), clsMisc.ASSqlFunction.Update))
        {
            var result = editСотрудник.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Обновить(editСотрудник.NewRecord);
            }
        }
    }
    private void simpleButtonИзменить_Click(object sender, EventArgs e) { РедактироватьСотрудника(sender, e); }

    void УдалитьСотрудника(object sender, EventArgs e)
    {
        var selectRow = gridViewСотрудники.FocusedRowHandle;
        if (XtraMessageBox.Show("Вы уверены что хотите удалить сотрудника?", 
                                Program.ProductName, 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.ШтатСотрудники_SIUD",
                clsMisc.ASSqlFunction.Delete, "@UIDСотрудника",
                gridViewСотрудники.GetFocusedRowCellDisplayText("UIDСотрудника").ToString());
                Обновить();
                gridViewСотрудники.FocusedRowHandle = selectRow;
        }
    }
    private void simpleButtonУдалить_Click(object sender, EventArgs e) { УдалитьСотрудника(sender, e); }

 #endregion


}

