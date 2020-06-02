using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоГараж : DevExpress.XtraEditors.XtraForm
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    public object NewRecord { get; set; }

    public dlgEditАвтГараж(string UIDМарки, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.ForeigenKey = UIDМарки;
        this.sqlFunction = sqlFunction;
    }

    private void dlgEditАвтоМарки_Load(object sender, EventArgs e)
    {
        this.Text = "Добавить запись";
        var dtМарки = clsSql.ExecuteSP("dbo.АвтоМарки_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        lookUpEditМарка.ASНастроитьВыпадалку("UIDМарки", "Марка", dtМарки, 0, "Марка");

        var dtСтатусы = clsSql.ExecuteQuery("SELECT * FROM vГаражСтатусАвто").dataTable;
        lookUpEditСтатусТовара.ASНастроитьВыпадалку("IdСтатусАвто", "Наименование", dtСтатусы, 0, "Наименование");

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.ГаражАвто_SIUD", clsMisc.ASSqlFunction.Select, "@UIDТовара", ForeigenKey).dataTable.RowsDR().SingleOrDefault();
            //textEditНаименование.EditValue = clsMisc.DBout(dr["Наименование"]);
            //LookUpEditСтраны.EditValue = clsMisc.DBout(dr["UIDСтранаПроизводитель"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(lookUpEditМарка.EditValue,
                                 lookUpEditМодель.EditValue))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.@UIDТовара", this.sqlFunction,
            "@UIDТовара", clsMisc.DBin(this.ForeigenKey)/*,
            "@UIDМарки", clsMisc.DBin(textEditНаименование.EditValue),
            "@UIDМодели", clsMisc.DBin(LookUpEditСтраны.EditValue))*/);

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.NewRecord = clsMisc.DBout(dr[0]);
            this.DialogResult = DialogResult.OK;
        }
    }

    private void lookUpEditМарка_EditValueChanged(object sender, EventArgs e)
    {
        if (lookUpEditМарка.EditValue == null)
        {
            lookUpEditМодель.Properties.DataSource = null;
            lookUpEditМодель.EditValue = null;
        }
        else
        {
            var dtМодели = clsSql.ExecuteSP("dbo.АвтоМодели_SIUD", clsMisc.ASSqlFunction.ViewForm, "@UIDМарки", lookUpEditМарка.EditValue).dataTable;
            lookUpEditМодель.ASНастроитьВыпадалку("UIDМодели", "Модель автомобиля", dtМодели, 0, "Модель автомобиля");
        } 

    }

    private void lookUpEditМодель_EditValueChanged(object sender, EventArgs e)
    {
        if (lookUpEditМодель.EditValue == null)
        {
            lookUpEditПоколение.Properties.DataSource = null;
            lookUpEditПоколение.EditValue = null;
        }
        else
        {
            var dtПоколение = clsSql.ExecuteSP("dbo.АвтоПоколения_SIUD", clsMisc.ASSqlFunction.ViewForm, "@UIDМодели", lookUpEditМодель.EditValue).dataTable;
            lookUpEditПоколение.ASНастроитьВыпадалку("UIDМодели", "Поколение", dtПоколение, 0, "Поколение");
        }
    }
}
