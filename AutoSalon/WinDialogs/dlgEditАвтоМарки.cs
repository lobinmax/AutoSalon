using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоМарки : Form
{
    private Guid? ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    public object NewRecord { get; set; }

    public dlgEditАвтоМарки(Guid? UIDМарки, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.ForeigenKey = UIDМарки;
        this.sqlFunction = sqlFunction;
    }

    private void dlgEditАвтоМарки_Load(object sender, EventArgs e)
    {
        this.Text = "Добавить запись";
        LookUpEditСтраны.ASНастроитьВыпадалку_SP("dbo.Страны_SIUD", "UIDСтраны", "Наименование");

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.АвтоМарки_SIUD", clsMisc.ASSqlFunction.Select, "@UIDМарки", ForeigenKey).dataTable.RowsDR().SingleOrDefault();
            textEditНаименование.Text = (string)clsMisc.DBout(dr["Наименование"]);
            LookUpEditСтраны.SelectedValue = clsMisc.DBout(dr["UIDСтранаПроизводитель"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditНаименование.Text,
                                 LookUpEditСтраны.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоМарки_SIUD", this.sqlFunction,
            "@UIDМарки", clsMisc.DBin(this.ForeigenKey),
            "@Марка", clsMisc.DBin(textEditНаименование.Text),
            "@UIDСтраны", clsMisc.DBin(LookUpEditСтраны.SelectedValue));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.NewRecord = clsMisc.DBout(dr[0]);
            this.DialogResult = DialogResult.OK;
        }
    }
}
