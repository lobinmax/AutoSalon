using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоМарки : DevExpress.XtraEditors.XtraForm
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    public object NewRecord { get; set; }

    public dlgEditАвтоМарки(string UIDМарки, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.ForeigenKey = UIDМарки;
        this.sqlFunction = sqlFunction;
    }

    private void dlgEditАвтоМарки_Load(object sender, EventArgs e)
    {
        this.Text = "Добавить запись";
        var dt = clsSql.ExecuteSP("dbo.Страны_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        LookUpEditСтраны.Properties.DataSource = dt;
        LookUpEditСтраны.Properties.PopulateColumns();
        LookUpEditСтраны.Properties.Columns["UIDСтраны"].Visible = false;
        LookUpEditСтраны.Properties.Columns["Наименование сокр."].Visible = false;
        LookUpEditСтраны.ItemIndex = 0;

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.АвтоМарки_SIUD", clsMisc.ASSqlFunction.Select, "@UIDМарки", ForeigenKey).dataTable.RowsDR().SingleOrDefault();
            textEditНаименование.EditValue = clsMisc.DBout(dr["Наименование"]);
            LookUpEditСтраны.EditValue = clsMisc.DBout(dr["UIDСтранаПроизводитель"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditНаименование.EditValue,
                                 LookUpEditСтраны.EditValue))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоМарки_SIUD", this.sqlFunction,
            "@UIDМарки", clsMisc.DBin(this.ForeigenKey),
            "@Марка", clsMisc.DBin(textEditНаименование.EditValue),
            "@UIDСтраны", clsMisc.DBin(LookUpEditСтраны.EditValue));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.NewRecord = clsMisc.DBout(dr[0]);
            this.DialogResult = DialogResult.OK;
        }
    }
}
