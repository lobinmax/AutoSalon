using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоПоколения : Form
{
    private Guid? ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    private Guid UIDМодели;
    private Guid UIDМарки;
    public object NewRecord { get; set; }

    public dlgEditАвтоПоколения(Guid? UIDПоколение, Guid UIDМодели, Guid UIDМарки, clsMisc.ASSqlFunction sqlFunction)
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
        var dt = clsSql.ExecuteSP("dbo.АвтоПоколения_SIUD", clsMisc.ASSqlFunction.Select, "@UIDМодели", UIDМодели).dataTable;
        var dr = dt.RowsDR().FirstOrDefault();
        textEditМарка.Text = (string)clsMisc.DBout(dr["Марка"]);
        textEditМодель.Text = (string)clsMisc.DBout(dr["Модель"]);

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            textEditМарка.Text = (string)clsMisc.DBout(dr["Марка"]);
            textEditМодель.Text = (string)clsMisc.DBout(dr["Модель"]);
            textEditПоколение.Text = (string)clsMisc.DBout(dr["Поколение"]);
            textEditНачалоПроизводства.Text = Convert.ToString(clsMisc.DBout(dr["Начало производства"]));
            textEditОкончаниеПроизводства.Text = Convert.ToString(clsMisc.DBout(dr["Окончание производства"]));

            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditПоколение.Text,
                                 textEditНачалоПроизводства.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоПоколения_SIUD", this.sqlFunction,
            "@UIDПоколения", clsMisc.DBin(this.ForeigenKey),
            "@UIDМодели", clsMisc.DBin(this.UIDМодели),
            "@UIDМарки", clsMisc.DBin(this.UIDМарки),
            "@Поколение", clsMisc.DBin(textEditПоколение.Text),
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
