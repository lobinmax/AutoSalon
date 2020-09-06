using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditВидыРемонта : Form
{
    private string IdВидаРемонта;
    private clsMisc.ASSqlFunction sqlFunction;

    public dlgEditВидыРемонта()
    {
        InitializeComponent();
    }

    private void dlgEditВидыРемонта_Load(object sender, EventArgs e)
    {
        var dicTag = (Dictionary<string, clsMisc.ASSqlFunction>)this.Tag;
        var keyValue = dicTag.SingleOrDefault();
        IdВидаРемонта = keyValue.Key;
        sqlFunction = keyValue.Value;
        this.Text = "Добавить запись";

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.ТО_ВидыРемонта_SIUD", clsMisc.ASSqlFunction.ViewForm, "@IdВидаРемонта", IdВидаРемонта).dataTable.RowsDR().SingleOrDefault();
            textEditНаименование.Text = (string)clsMisc.DBout(dr["Наименование"]);
            numericСтоимость.Value = (decimal)clsMisc.DBout(dr["Стоимость"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditНаименование.Text,
                                    numericСтоимость.Value))
        {
            return;
        }

        var response = clsSql.ExecuteSP("ТО_ВидыРемонта_SIUD", this.sqlFunction,
            "@IdВидаРемонта", this.IdВидаРемонта,
            "@Наименование", clsMisc.DBin(textEditНаименование.Text),
            "@Стоимость", clsMisc.DBin(numericСтоимость.Value.ToString()));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}
