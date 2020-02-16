using System;

public partial class frМаркиАвто : DevExpress.XtraEditors.XtraForm
{
    public frМаркиАвто()
    {
        using (var d = new DevExpress.Utils.WaitDialogForm("Идет загрузка ...", "Пожалуйста, подождите"))
        {
            InitializeComponent();

            ОбновитьМарки();
        }
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
        var dr = gridViewМарки.GetFocusedDataRow();
        if (dr == null)
        {
            gridControlМодели.DataSource = null;
            return;
        }

        var dt = clsSql.ExecuteSP("dbo.АвтоМодели_SIUD", clsMisc.ASSqlFunction.ViewForm, 
                                  "@UIDМарки", dr["UIDМарки"]).dataTable;
        gridViewМодели.ASОбновитьСохранитьВыделение(dt, "UIDМодели", value);

        gridViewМодели.ASНастроитьGridView(true, "UIDМарки", "UIDМодели");
    }
    void ОбновитьПоколения(object value = null)
    {
        var dr = gridViewМодели.GetFocusedDataRow();
        if (dr == null)
        {
            gridControlПоколения.DataSource = null;
            return;
        }

        var dt = clsSql.ExecuteSP("dbo.АвтоПоколения_SIUD", clsMisc.ASSqlFunction.ViewForm,
                                  "@UIDМодели", dr["UIDМодели"]).dataTable;
        gridViewПоколения.ASОбновитьСохранитьВыделение(dt, "UIDПоколения", value);

        gridViewПоколения.ASНастроитьGridView(true, "UIDМарки", "UIDМодели", "UIDПоколения");
    }

    private void gridViewМарки_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
    {
        DevExpress.Utils.Menu.DXPopupMenu dxpopupmenu = new DevExpress.Utils.Menu.DXPopupMenu();

        e.МенюДляAddEditDelete(dxpopupmenu, ДобавитьМарку, РедактироватьМарку, УдалитьМарку);
    }

    private void gridViewМарки_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
        ОбновитьМодели();
    }
    private void gridViewМарки_FilterRowChanged(object sender, EventArgs e)
    {
        ОбновитьМодели();
    }

    private void gridViewМодели_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
    {
        DevExpress.Utils.Menu.DXPopupMenu dxpopupmenu = new DevExpress.Utils.Menu.DXPopupMenu();

        e.МенюДляAddEditDelete(dxpopupmenu, ДобавитьМодель, РедактироватьМодель, УдалитьМодель);
    }
    private void gridViewМодели_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    {
        ОбновитьПоколения();
    }
    private void gridViewМодели_FilterRowChanged(object sender, EventArgs e)
    {
        ОбновитьПоколения();
    }

    private void gridViewПоколения_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
    {
        DevExpress.Utils.Menu.DXPopupMenu dxpopupmenu = new DevExpress.Utils.Menu.DXPopupMenu();

        e.МенюДляAddEditDelete(dxpopupmenu, ДобавитьПоколение, РедактироватьПоколение, УдалитьПоколение);
    }

    #region "gridViewМарки" Кнопки управления и контекстное меню  

    void ДобавитьМарку(object sender, EventArgs e)
    {
        using (var dlgEditАвтоМарки = new dlgEditАвтоМарки(null,
                                                           clsMisc.ASSqlFunction.Insert))
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
        using (var dlgEditАвтоМарки = new dlgEditАвтоМарки(gridViewМарки.GetFocusedRowCellDisplayText("UIDМарки").ToString(),
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
        var selectRow = gridViewМарки.FocusedRowHandle;
        if (DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены что хотите удалить запись?",
                                                        Program.ProductName,
                                                        System.Windows.Forms.MessageBoxButtons.YesNo,
                                                        System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.АвтоМарки_SIUD",
                                      clsMisc.ASSqlFunction.Delete, "@UIDМарки",
                                      gridViewМарки.GetFocusedRowCellDisplayText("UIDМарки").ToString());
            ОбновитьМарки();
            gridViewМарки.FocusedRowHandle = selectRow - 1;
        }
    }
    #endregion

    #region "gridViewМодели" Кнопки управления и контекстное меню  

    void ДобавитьМодель(object sender, EventArgs e)
    {
        using (var dlgEditАвтоМодели = new dlgEditАвтоМодели(null,
                                                             gridViewМарки.GetFocusedRowCellDisplayText("UIDМарки").ToString(),
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
        var dr = gridViewМодели.GetFocusedDataRow();
        if (dr == null) { return; }
        using (var dlgEditАвтоМодели = new dlgEditАвтоМодели(dr["UIDМодели"].ToString(),
                                                             dr["UIDМарки"].ToString(),
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
        var selectRow = gridViewМодели.FocusedRowHandle;
        if (DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены что хотите удалить запись?",
                                                        Program.ProductName,
                                                        System.Windows.Forms.MessageBoxButtons.YesNo,
                                                        System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.АвтоМодели_SIUD",
                                      clsMisc.ASSqlFunction.Delete, "@UIDМодели",
                                      gridViewМодели.GetFocusedRowCellDisplayText("UIDМодели").ToString());
            ОбновитьМодели();
            gridViewМодели.FocusedRowHandle = selectRow - 1;
        }
    }

    #endregion

    #region "gridViewПоколения" Кнопки управления и контекстное меню  

    void ДобавитьПоколение(object sender, EventArgs e)
    {
        var dr = gridViewМодели.GetFocusedDataRow();
        if (dr == null) { return; }
        using (var dlgEditАвтоПоколения = new dlgEditАвтоПоколения(null,
                                                                   dr["UIDМодели"].ToString(), 
                                                                   dr["UIDМарки"].ToString(),
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
        var dr = gridViewПоколения.GetFocusedDataRow();
        if (dr == null) { return; }
        using (var dlgEditАвтоПоколения = new dlgEditАвтоПоколения(dr["UIDПоколения"].ToString(),
                                                                   dr["UIDМодели"].ToString(),
                                                                   dr["UIDМарки"].ToString(),
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
        var selectRow = gridViewПоколения.FocusedRowHandle;
        if (DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены что хотите удалить запись?",
                                                        Program.ProductName,
                                                        System.Windows.Forms.MessageBoxButtons.YesNo,
                                                        System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.АвтоПоколения_SIUD",
                                      clsMisc.ASSqlFunction.Delete, "@UIDПоколения",
                                      gridViewМодели.GetFocusedRowCellDisplayText("UIDПоколения").ToString());
            ОбновитьМодели();
            gridViewМодели.FocusedRowHandle = selectRow - 1;
        }
    }

    #endregion

   
}

