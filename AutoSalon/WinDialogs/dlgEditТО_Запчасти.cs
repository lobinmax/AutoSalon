using System;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditТО_Запчасти : Form
{

    private clsMisc.ASSqlFunction sqlFunction;
    private Guid? UIDТО;
    private Guid? UIDРаботы;
    private Guid? UIDЗапчасти;

    public dlgEditТО_Запчасти(Guid? UIDТО, Guid? UIDРаботы, Guid? UIDЗапчасти, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.UIDТО = UIDТО;
        this.UIDРаботы = UIDРаботы;
        this.UIDЗапчасти = UIDЗапчасти;
        this.sqlFunction = sqlFunction;
    }

    private void dlgEditТО_ВидРаботы_Load(object sender, EventArgs e)
    {
        comboBoxНаименование.ASНастроитьВыпадалку_SP("СписокФильтров_ТО_Запчасти", "Id", "Name", 0, "@Все", 0);
        this.Text = "Добавить запись";
        comboBoxНаименование.SelectedIndex = 0;

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            var dr = clsSql.ExecuteSP("dbo.ТО_ФактЗапчасти_SIUD", clsMisc.ASSqlFunction.Select, "@UIDЗапчасти", UIDЗапчасти).dataTable.RowsDR().SingleOrDefault();
            comboBoxНаименование.SelectedValue = clsMisc.DBout(dr["IdЗапчасти"]);
            numericUpDownСтоимость.Value = (decimal)clsMisc.DBout(dr["Стоимость"]);
            numericUpDownКоличество.Value = (int)clsMisc.DBout(dr["Количество"]);
            this.Text = "Изменить запись";
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(comboBoxНаименование.Text,
                                 numericUpDownСтоимость.Value,
                                 numericUpDownКоличество.Value))
        {
            return;
        }

        var response = clsSql.ExecuteSP("ТО_ФактЗапчасти_SIUD", this.sqlFunction,
            "@UIDТО", clsMisc.DBin(this.UIDТО),
            "@UIDРаботы", clsMisc.DBin(this.UIDРаботы),
            "@UIDЗапчасти", clsMisc.DBin(this.UIDЗапчасти),
            "@IdЗапчасти", clsMisc.DBin(comboBoxНаименование.ASSelectedRow()["Id"]),
            "@Стоимость", clsMisc.DBin(numericUpDownСтоимость.Text),
            "@Количество", clsMisc.DBin(numericUpDownКоличество.Text));

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
                "dbo.ТО_ОпределитьСтоимостьЗапчасти",
                clsMisc.DBin(comboBoxНаименование.ASSelectedRow()["Id"])
            ).result;
    }
     
}
