using System;
using System.Linq;
using System.Windows.Forms;

public partial class frГаражАвто : Form
{
    public frГаражАвто()
    {
            InitializeComponent();

            ОбновитьГараж();
    }

    void ОбновитьГараж(object value = null)
    {
        var dt = clsSql.ExecuteSP("dbo.ГаражАвто_SIUD", clsMisc.ASSqlFunction.ViewForm, "@IdСтатусАвто", 0).dataTable;
        gridViewГараж.ASОбновитьСохранитьВыделение(dt, "UIDТовара", value);

        gridViewГараж.ASНастроитьGridView(true, "UIDТовара", "UIDМарки", "UIDМодели", "UIDПоколения", "IdСтатусАвто", "Автор");
    }

    private void simpleButtonОбновить_Click(object sender, EventArgs e) { ОбновитьГараж(); }

    void ОбновитьИсториюЦен(object value = null)
    {
        var dr = gridViewГараж.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (dr == null)
        {
            gridViewИсторияЦены.DataSource = null;
            return;
        }

        var dt = clsSql.ExecuteSP("dbo.ГаражСтоимостьАвто_SIUD", clsMisc.ASSqlFunction.ViewForm,
                                  "@UIDТовара", dr.Cells["UIDТовара"]).dataTable;
        gridViewИсторияЦены.ASОбновитьСохранитьВыделение(dt, "UIDТовара", value);

        gridViewИсторияЦены.ASНастроитьGridView(true, "UIDСтоимости", 
                                                      "UIDТовара", 
                                                      "ДатаСоздания", 
                                                      "ДатаИзменения", 
                                                      "UIDАвтора", 
                                                      "Автор", 
                                                      "UIDИзменяющего");
    }

    private void gridViewГаражи_MouseClick(object sender, MouseEventArgs e)
    {
        var menu = new ContextMenuStrip();
        e.МенюДляAddEditDelete(menu, (DataGridView)sender, ДобавитьТовар, РедактироватьТовар, УдалитьТовар);
    }
    
    //private void gridViewГараж_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
    //{
    //    ОбновитьИсториюЦен();
    //}

    //private void gridViewГараж_ColumnFilterDataSourceChanged(object sender, EventArgs e)
    //{
    //    ОбновитьИсториюЦен();
    //}

    void ДобавитьТовар(object sender, EventArgs e)
    {
        //using (var dlgEditАвтГараж = new dlgEditАвтоГараж(null, clsMisc.ASSqlFunction.Insert))
        //{
        //    var result = dlgEditАвтГараж.ShowDialog();
        //    if (result == System.Windows.Forms.DialogResult.OK)
        //    {
        //        ОбновитьГараж(dlgEditАвтГараж.NewRecord);
        //    }
        //}
    }
    private void simpleButtonДобавить_Click(object sender, EventArgs e) { ДобавитьТовар(sender, e); }

    void РедактироватьТовар(object sender, EventArgs e)
    {
        //using (var dlgEditАвтГараж = new dlgEditАвтоГараж(gridViewГараж.GetFocusedRowCellDisplayText("UIDТовара").ToString(),
        //                                                 clsMisc.ASSqlFunction.Update))
        //{
        //    var result = dlgEditАвтГараж.ShowDialog();
        //    if (result == System.Windows.Forms.DialogResult.OK)
        //    {
        //        ОбновитьГараж(dlgEditАвтГараж.NewRecord);
        //    }
        //}
    }
    private void simpleButtonИзменить_Click(object sender, EventArgs e) { РедактироватьТовар(sender, e); }


    void УдалитьТовар(object sender, EventArgs e)
    {
        //var selectRowHandle = gridViewГараж.FocusedRowHandle;
        //if (DevExpress.XtraEditors.XtraMessageBox.Show("Вы уверены что хотите удалить запись?",
        //                                                Program.ProductName,
        //                                                System.Windows.Forms.MessageBoxButtons.YesNo,
        //                                                System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
        //{
        //    clsSql.ExecuteSPNonQuery("dbo.ГаражАвто_SIUD",
        //                              clsMisc.ASSqlFunction.Delete, "@UIDТовара",
        //                              gridViewГараж.GetFocusedRowCellDisplayText("UIDТовара").ToString());
        //    ОбновитьГараж();
        //    gridViewГараж.FocusedRowHandle = selectRowHandle - 1;
        //}
    }
    private void simpleButtonУдалить_Click(object sender, EventArgs e) { УдалитьТовар(sender, e); }

}