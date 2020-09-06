using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditГрафикТО : Form
{
    private string IdТО;
    private clsMisc.ASSqlFunction sqlFunction;

    public dlgEditГрафикТО()
    {
        InitializeComponent();
    }

    private void dlgEditГрафикТО_Load(object sender, EventArgs e)
    {
        var dicTag = (Dictionary<string, clsMisc.ASSqlFunction>)this.Tag;
        var keyValue = dicTag.SingleOrDefault();
        IdТО = keyValue.Key;
        sqlFunction = keyValue.Value;
        this.Text = "Добавить запись";

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.ТО_График_SIUD", clsMisc.ASSqlFunction.ViewForm, "@IdТО", IdТО).dataTable.RowsDR().SingleOrDefault();
            textEditНаименование.Text = (string)clsMisc.DBout(dr["Наименование"]);
            numericСрокГод.Value = (int)clsMisc.DBout(dr["СрокГод"]);
            numericСрокМесяц.Value = (int)clsMisc.DBout(dr["СрокМесяц"]);

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

        var response = clsSql.ExecuteSP("ТО_График_SIUD", this.sqlFunction,
            "@IdТО", this.IdТО,
            "@Наименование", clsMisc.DBin(textEditНаименование.Text),
            "@СрокГод", clsMisc.DBin(numericСрокГод.Value.ToString()),
            "@СрокМесяц", clsMisc.DBin(numericСрокМесяц.Value.ToString()));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}
