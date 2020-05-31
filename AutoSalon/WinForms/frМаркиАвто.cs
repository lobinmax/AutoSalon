using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public partial class frМаркиАвто : Form
{
    public frМаркиАвто()
    {
        InitializeComponent();
        ОбновитьМарки();
    }

    private void frМаркиАвто_Load(object sender, System.EventArgs e) { }

    void ОбновитьМарки(object value = null)
    {
        var dt = clsSql.ExecuteSP("dbo.АвтоМарки_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        gridViewМарки.ASОбновитьСохранитьВыделение(dt, "UIDМарки", value);

        gridViewМарки.ASНастроитьGridView(true, "UIDМарки", "UIDСтраны", "Кодстраны");
    }

    private void simpleButtonОбновить_Click(object sender, EventArgs e) { ОбновитьМарки(); }

    void ОбновитьМодели(object value = null)
    {
        var dr = gridViewМарки.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        var UIDМарки =(dr == null) ? Guid.Empty : dr.Cells["UIDМарки"].Value;

        var dt = clsSql.ExecuteSP("dbo.АвтоМодели_SIUD", clsMisc.ASSqlFunction.ViewForm, 
                                  "@UIDМарки", UIDМарки).dataTable;
        gridViewМодели.ASОбновитьСохранитьВыделение(dt, "UIDМодели", value);

        gridViewМодели.ASНастроитьGridView(true, "UIDМарки", "UIDМодели");
    }
    void ОбновитьПоколения(object value = null)
    {
        var dr = gridViewМодели.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        var UIDМодели = (dr == null) ? Guid.Empty : dr.Cells["UIDМодели"].Value;

        var dt = clsSql.ExecuteSP("dbo.АвтоПоколения_SIUD", clsMisc.ASSqlFunction.ViewForm,
                                  "@UIDМодели", UIDМодели).dataTable;
        gridViewПоколения.ASОбновитьСохранитьВыделение(dt, "UIDПоколения", value);

        gridViewПоколения.ASНастроитьGridView(true, "UIDМарки", "UIDМодели", "UIDПоколения");
    }

    #region "Вызов контекстного меню"
    private void gridViewМарки_MouseClick(object sender, MouseEventArgs e)
    {
        var menu = new ContextMenuStrip();
        e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьМарку, РедактироватьМарку, УдалитьМарку);
    }
    private void gridViewМодели_MouseClick(object sender, MouseEventArgs e)
    {
        var curRow = gridViewМарки.CurrentRow;
        if (curRow != null)
        {
            var menu = new ContextMenuStrip();
            e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьМодель, РедактироватьМодель, УдалитьМодель);
        }
    }
    private void gridViewПоколения_MouseClick(object sender, MouseEventArgs e)
    {
        var curRow = gridViewМодели.CurrentRow;
        if (curRow != null)
        {
            var menu = new ContextMenuStrip();
            e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьПоколение, РедактироватьПоколение, УдалитьПоколение);
        }
    }
    #endregion

    #region "Выделение строк"
    private void gridViewМарки_SelectionChanged(object sender, EventArgs e)
    {
        ОбновитьМодели();
    }

    private void gridViewМарки_DataSourceChanged(object sender, EventArgs e)
    {
        ОбновитьМодели();
    }

    private void gridViewМодели_SelectionChanged(object sender, EventArgs e)
    {
        ОбновитьПоколения();
    }

    private void gridViewМодели_DataSourceChanged(object sender, EventArgs e)
    {
        ОбновитьПоколения();
    }
    #endregion

    #region "gridViewМарки" Кнопки управления и контекстное меню  

    void ДобавитьМарку(object sender, EventArgs e)
    {
        using (var dlgEditАвтоМарки = new dlgEditАвтоМарки(null, clsMisc.ASSqlFunction.Insert))
        {
            var result = dlgEditАвтоМарки.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ОбновитьМарки(dlgEditАвтоМарки.NewRecord);
            }
        }
    }

    void РедактироватьМарку(object sender, EventArgs e)
    {
        using (var dlgEditАвтоМарки = new dlgEditАвтоМарки((Guid)gridViewМарки["UIDМарки", gridViewМарки.CurrentRow.Index].Value,
                                                           clsMisc.ASSqlFunction.Update))
        {
            var result = dlgEditАвтоМарки.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ОбновитьМарки(dlgEditАвтоМарки.NewRecord);
            }
        }
    }

    void УдалитьМарку(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                            Program.ProductName,
                            System.Windows.Forms.MessageBoxButtons.YesNo,
                            System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.АвтоМарки_SIUD",
                                      clsMisc.ASSqlFunction.Delete, "@UIDМарки",
                                      gridViewМарки["UIDМарки", gridViewМарки.CurrentRow.Index].Value.ToString());
            ОбновитьМарки();
        }
    }
    #endregion

    #region "gridViewМодели" Кнопки управления и контекстное меню  

    void ДобавитьМодель(object sender, EventArgs e)
    {
        using (var dlgEditАвтоМодели = new dlgEditАвтоМодели(null,
                                                             (Guid)gridViewМарки["UIDМарки", gridViewМарки.CurrentRow.Index].Value,
                                                             clsMisc.ASSqlFunction.Insert))
        {
            var result = dlgEditАвтоМодели.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ОбновитьМодели(dlgEditАвтоМодели.NewRecord);
            }
        }
    }

    void РедактироватьМодель(object sender, EventArgs e)
    {
        var dr = gridViewМодели.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (dr == null) { return; }
        using (var dlgEditАвтоМодели = new dlgEditАвтоМодели((Guid)dr.Cells["UIDМодели"].Value,
                                                             (Guid)dr.Cells["UIDМарки"].Value,
                                                             clsMisc.ASSqlFunction.Update))
        {
            var result = dlgEditАвтоМодели.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ОбновитьМодели(dlgEditАвтоМодели.NewRecord);
            }
        }
    }

    void УдалитьМодель(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                            Program.ProductName,
                            System.Windows.Forms.MessageBoxButtons.YesNo,
                            System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.АвтоМодели_SIUD",
                                     clsMisc.ASSqlFunction.Delete, "@UIDМодели",
                                     gridViewМодели["UIDМодели", gridViewМодели.CurrentRow.Index].Value);
            ОбновитьМодели();
        }
    }

    #endregion

    #region "gridViewПоколения" Кнопки управления и контекстное меню  

    void ДобавитьПоколение(object sender, EventArgs e)
    {
        var dr = gridViewМодели.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (dr == null) { return; }
        using (var dlgEditАвтоПоколения = new dlgEditАвтоПоколения(null,
                                                                   (Guid)dr.Cells["UIDМодели"].Value,
                                                                   (Guid)dr.Cells["UIDМарки"].Value,
                                                                   clsMisc.ASSqlFunction.Insert))
        {
            var result = dlgEditАвтоПоколения.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ОбновитьМодели(dlgEditАвтоПоколения.NewRecord);
            }
        }
    }

    void РедактироватьПоколение(object sender, EventArgs e)
    {
        var dr = gridViewПоколения.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (dr == null) { return; }
        using (var dlgEditАвтоПоколения = new dlgEditАвтоПоколения((Guid)dr.Cells["UIDПоколения"].Value,
                                                                   (Guid)dr.Cells["UIDМодели"].Value,
                                                                   (Guid)dr.Cells["UIDМарки"].Value,
                                                                   clsMisc.ASSqlFunction.Update))
        {
            var result = dlgEditАвтоПоколения.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ОбновитьМодели(dlgEditАвтоПоколения.NewRecord);
            }
        }
    }

    void УдалитьПоколение(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                                                        Program.ProductName,
                                                        System.Windows.Forms.MessageBoxButtons.YesNo,
                                                        System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.АвтоПоколения_SIUD",
                                      clsMisc.ASSqlFunction.Delete, "@UIDПоколения",
                                      gridViewПоколения["UIDПоколения", gridViewПоколения.CurrentRow.Index].Value);
            ОбновитьМодели();
        }
    }



    #endregion

}

