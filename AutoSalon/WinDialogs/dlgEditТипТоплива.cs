using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditТипТоплива : DevExpress.XtraEditors.XtraForm
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;

    public dlgEditТипТоплива() { InitializeComponent(); }

    private void dlgEditТипТоплива_Load(object sender, EventArgs e)
    {
        var dicTag = (Dictionary<string, clsMisc.ASSqlFunction>)this.Tag;
        var keyValue = dicTag.SingleOrDefault();
        ForeigenKey = keyValue.Key;
        sqlFunction = keyValue.Value;
        this.Text = "Добавить запись";

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.АвтоТипТоплива_SIUD", clsMisc.ASSqlFunction.ViewForm, "@IdТипТоплива", ForeigenKey).dataTable.RowsDR().SingleOrDefault();
            textEditНаименование.EditValue = clsMisc.DBout(dr["Наименование"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditНаименование.EditValue))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.АвтоТипТоплива_SIUD", this.sqlFunction,
            "@IdТипТоплива", this.ForeigenKey,
            "@Наименование", clsMisc.DBin(textEditНаименование.EditValue));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}