using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

public partial class dlgEditТипКузова : DevExpress.XtraEditors.XtraForm
{
    private string ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;

    public dlgEditТипКузова()
    {
        InitializeComponent();
    }

    private void dlgEditТипКПП_Load(object sender, EventArgs e)
    {
        var dicTag = (Dictionary<string, clsMisc.ASSqlFunction>)this.Tag;
        var keyValue = dicTag.SingleOrDefault();
        ForeigenKey = keyValue.Key;
        sqlFunction = keyValue.Value;
        this.Text = "Добавить запись";

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.АвтоТипКузова_SIUD", clsMisc.ASSqlFunction.ViewForm, "@IdТипКузова", ForeigenKey).dataTable.RowsDR().SingleOrDefault();
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

        var response = clsSql.ExecuteSP("dbo.АвтоТипКузова_SIUD", this.sqlFunction,
            "@IdТипКузова", this.ForeigenKey,
            "@Наименование", clsMisc.DBin(textEditНаименование.EditValue));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}