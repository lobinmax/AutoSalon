using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоПоколения : DevExpress.XtraEditors.XtraForm
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    private string UIDМодели;
    private string UIDМарки;
    public object NewRecord { get; set; }

    public dlgEditАвтоПоколения(string UIDПоколение, string UIDМодели, string UIDМарки, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.ForeigenKey = UIDПоколение; 
        this.sqlFunction = sqlFunction;
        this.UIDМодели = UIDМодели;
        this.UIDМарки = UIDМарки;
    }

    private void dlgEditАвтоМодели_Load(object sender, EventArgs e)
    {
        this.Text = "Добавить запись";
        var dt = clsSql.ExecuteSP("dbo.АвтоПоколения_SIUD", clsMisc.ASSqlFunction.Select, "@UIDМодели", ForeigenKey).dataTable;
        var dr = dt.RowsDR().FirstOrDefault();
        textEditМарка.EditValue = clsMisc.DBout(dr["Марка"]);
        textEditМодель.EditValue = clsMisc.DBout(dr["Поколение"]);

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            textEditМарка.EditValue = clsMisc.DBout(dr["Марка"]);
            textEditМодель.EditValue = clsMisc.DBout(dr["Модель"]);
            textEditПоколение.EditValue = clsMisc.DBout(dr["Поколение"]);
            textEditНачалоПроизводства.EditValue = clsMisc.DBout(dr["Начало производства"]);
            textEditОкончаниеПроизводства.EditValue = clsMisc.DBout(dr["Окончание производства"]);

            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditПоколение.EditValue,
                                 textEditНачалоПроизводства.EditValue))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоПоколения_SIUD", this.sqlFunction,
            "@UIDПоколения", clsMisc.DBin(this.ForeigenKey),
            "@UIDМодели", clsMisc.DBin(this.UIDМодели),
            "@UIDМарки", clsMisc.DBin(this.UIDМарки),
            "@Поколение", clsMisc.DBin(textEditПоколение.EditValue),
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
