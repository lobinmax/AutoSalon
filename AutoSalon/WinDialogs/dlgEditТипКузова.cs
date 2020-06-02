using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditТипКузова : Form
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;

    public dlgEditТипКузова()
    {
        InitializeComponent();
    }

    private void dlgEditТипКузова_Load(object sender, EventArgs e)
    {
        var dicTag = (Dictionary<string, clsMisc.ASSqlFunction>)this.Tag;
        var keyValue = dicTag.SingleOrDefault();
        ForeigenKey = keyValue.Key;
        sqlFunction = keyValue.Value;
        this.Text = "Добавить запись";

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.АвтоТипКузова_SIUD", clsMisc.ASSqlFunction.ViewForm, "@IdТипКузова", ForeigenKey).dataTable.RowsDR().SingleOrDefault();
            textEditНаименование.Text = clsMisc.DBout((string)dr["Наименование"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditНаименование.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоТипКузова_SIUD", this.sqlFunction,
            "@IdТипКузова", this.ForeigenKey,
            "@Наименование", clsMisc.DBin(textEditНаименование.Text));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}