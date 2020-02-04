using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоМодели : DevExpress.XtraEditors.XtraForm
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    private string UIDМарки; 
    public object NewRecord { get; set; }

    public dlgEditАвтоМодели(string UIDМодели, string UIDМарки, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.ForeigenKey = UIDМодели; 
        this.sqlFunction = sqlFunction;
        this.UIDМарки = UIDМарки;  
    }

    private void dlgEditАвтоМодели_Load(object sender, EventArgs e)
    {
        this.Text = "Добавить запись";
        var dt = clsSql.ExecuteSP("dbo.АвтоМодели_SIUD", clsMisc.ASSqlFunction.Select, "@UIDМодели", ForeigenKey).dataTable;
        var dr = dt.RowsDR().FirstOrDefault();
        textEditМарка.EditValue = clsMisc.DBout(dr["Марка"]);

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            textEditМодель.EditValue = clsMisc.DBout(dr["Модель"]);
            textEditНачалоПроизводства.EditValue = clsMisc.DBout(dr["Начало производства"]);
            textEditОкончаниеПроизводства.EditValue = clsMisc.DBout(dr["Окончание производства"]);

            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditМодель.EditValue,
                                 textEditНачалоПроизводства.EditValue))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоМодели_SIUD", this.sqlFunction,
            "@UIDМодели", clsMisc.DBin(this.ForeigenKey),
            "@UIDМарки", clsMisc.DBin(UIDМарки),
            "@Модель", clsMisc.DBin(textEditМодель.EditValue),
            "@НачалоПроизводства", clsMisc.DBin(textEditНачалоПроизводства.EditValue),
            "@ОкончаниеПроизводства", clsMisc.DBin(textEditОкончаниеПроизводства.EditValue));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.NewRecord = clsMisc.DBout(dr[0]);
            this.DialogResult = DialogResult.OK;
        }
    }
}
