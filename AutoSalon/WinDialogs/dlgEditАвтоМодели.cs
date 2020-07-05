using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоМодели : Form
{
    private Guid? ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    private Guid? UIDМарки; 
    public object NewRecord { get; set; }

    public dlgEditАвтоМодели(Guid? UIDМодели, Guid UIDМарки, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.ForeigenKey = UIDМодели; 
        this.sqlFunction = sqlFunction;
        this.UIDМарки = UIDМарки;  
    }

    private void dlgEditАвтоМодели_Load(object sender, EventArgs e)
    {
        this.Text = "Добавить запись";
        var dt = clsSql.ExecuteSP(
            "dbo.АвтоМодели_SIUD", clsMisc.ASSqlFunction.Select, 
            "@UIDМодели", ForeigenKey, 
            "@UIDМарки", UIDМарки).dataTable;
        var dr = dt.RowsDR().FirstOrDefault();
        textEditМарка.Text = (string)clsMisc.DBout(dr["Марка"]);

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            textEditМодель.Text = (string)clsMisc.DBout(dr["Модель"]);
            textEditНачалоПроизводства.Text = Convert.ToString(clsMisc.DBout(dr["Начало производства"]));
            textEditОкончаниеПроизводства.Text = Convert.ToString(clsMisc.DBout(dr["Окончание производства"]));

            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditМодель.Text,
                                 textEditНачалоПроизводства.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоМодели_SIUD", this.sqlFunction,
            "@UIDМодели", clsMisc.DBin(this.ForeigenKey),
            "@UIDМарки", clsMisc.DBin(UIDМарки),
            "@Модель", clsMisc.DBin(textEditМодель.Text),
            "@НачалоПроизводства", clsMisc.DBin(textEditНачалоПроизводства.Text),
            "@ОкончаниеПроизводства", clsMisc.DBin(textEditОкончаниеПроизводства.Text));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.NewRecord = clsMisc.DBout(dr[0]);
            this.DialogResult = DialogResult.OK;
        }
    }
}
