using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditТО_ВидРаботы : Form
{

    private clsMisc.ASSqlFunction sqlFunction;
    private Guid? UIDТО;
    private Guid? UIDРаботы;

    public dlgEditТО_ВидРаботы(Guid? UIDТО, Guid? UIDРаботы, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.UIDТО = UIDТО;
        this.UIDРаботы = UIDРаботы;
        this.sqlFunction = sqlFunction;
    }

    private void dlgEditТО_ВидРаботы_Load(object sender, EventArgs e)
    {
        comboBoxНаименование.ASНастроитьВыпадалку_SP("СписокФильтров_ТО_ВидыРабот", "Id", "Name", 0, "@Все", 0);
        this.Text = "Добавить запись";

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.ТО_ФактРаботы_SIUD", clsMisc.ASSqlFunction.Select, "@UIDРаботы", UIDРаботы).dataTable.RowsDR().SingleOrDefault();
            comboBoxНаименование.SelectedValue = clsMisc.DBout(dr["IdВидаРемонта"]);
            numericUpDownСтоимость.Value = (decimal)clsMisc.DBout(dr["Стоимость"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(comboBoxНаименование.Text,
                                 numericUpDownСтоимость.Value))
        {
            return;
        }

        var response = clsSql.ExecuteSP("ТО_ФактРаботы_SIUD", this.sqlFunction,
            "@UIDТО", clsMisc.DBin(this.UIDТО),
            "@UIDРаботы", clsMisc.DBin(this.UIDРаботы),
            "@IdВидаРемонта", clsMisc.DBin(comboBoxНаименование.ASSelectedRow()["Id"]),
            "@Стоимость", clsMisc.DBin(numericUpDownСтоимость.Text));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }

    private void comboBoxНаименование_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxНаименование.SelectedIndex == 0)
        {
            numericUpDownСтоимость.Value = 0;
            return;
        }
        numericUpDownСтоимость.Value = 
            (decimal)clsSql.ExecuteScalarFunction
            (
                "dbo.ТО_ОпределитьСтоимостьРаботы", 
                clsMisc.DBin(comboBoxНаименование.ASSelectedRow()["Id"])
            ).result;
    }
}
