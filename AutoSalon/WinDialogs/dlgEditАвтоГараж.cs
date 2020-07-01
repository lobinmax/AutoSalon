using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditАвтоГараж : Form
{
    private Guid? ForeigenKey;
    private clsMisc.ASSqlFunction sqlFunction;
    public object NewRecord { get; set; }

    public dlgEditАвтоГараж(Guid? UIDТовара, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.ForeigenKey = UIDТовара;
        this.sqlFunction = sqlFunction;
    }

    private void dlgEditАвтоМарки_Load(object sender, EventArgs e)
    {
        this.Text = "Добавить запись";

        comboBoxМарка.ASНастроитьВыпадалку_SP("СписокФильтров_МаркиАвто", "UID", "Name", 0, "@Все", 0);
        comboBoxТипТоплива.ASНастроитьВыпадалку_SP("СписокФильтров_ТипТоплива", "Id", "Name", 0, "@Все", 0);
        comboBoxТипПривода.ASНастроитьВыпадалку_SP("СписокФильтров_ТипПривода", "Id", "Name", 0, "@Все", 0);
        comboBoxТипКузова.ASНастроитьВыпадалку_SP("СписокФильтров_ТипКузова", "Id", "Name", 0, "@Все", 0);
        comboBoxТипРуля.ASНастроитьВыпадалку_SP("СписокФильтров_ТипРуля", "Id", "Name", 0, "@Все", 0);
        comboBoxТипКПП.ASНастроитьВыпадалку_SP("СписокФильтров_ТипКПП", "Id", "Name", 0, "@Все", 0);
        comboBoxСтатусАвто.ASНастроитьВыпадалку_SP("СписокФильтров_СтатусАвто", "Id", "Name", 1, "@Все", 0);

        var dt = new DataTable() { Columns = { new DataColumn("ValueMember"), new DataColumn("DisplayMember") } };
        for(var i = 0.1m; i<=10; i = i + 0.1m)
        {
            var dr = dt.NewRow();
            dr["ValueMember"] = i;
            dr["DisplayMember"] =$"{Math.Round(i, 1)} л";
            dt.Rows.Add(dr);
        }
        comboBoxОбъемДвигателя.DataSource = dt;
        comboBoxОбъемДвигателя.ValueMember = "ValueMember";
        comboBoxОбъемДвигателя.DisplayMember = "DisplayMember";
        comboBoxОбъемДвигателя.SelectedValue = 1.5m;

        var dt1 = new DataTable() { Columns = { new DataColumn("ValueMember"), new DataColumn("DisplayMember") } };
        for (var i = 30; i <= 600; i = i + 10)
        {
            var dr = dt1.NewRow();
            dr["ValueMember"] = i;
            dr["DisplayMember"] = $"{i} л.c.";
            dt1.Rows.Add(dr);
        }
        comboBoxМощностьДвигателя.DataSource = dt1;
        comboBoxМощностьДвигателя.ValueMember = "ValueMember";
        comboBoxМощностьДвигателя.DisplayMember = "DisplayMember";
        comboBoxМощностьДвигателя.SelectedValue = 80;

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            this.Text = "Изменить запись";

            labelControl6.Visible = true;
            checkBoxОбновитьСтатистику.Enabled = true;

            var dr = clsSql.ExecuteSP("dbo.ГаражАвто_SIUD", clsMisc.ASSqlFunction.Select, "@UIDТовара", ForeigenKey).dataTable.RowsDR().SingleOrDefault();

            comboBoxМарка.SelectedValue = clsMisc.DBout(dr["UIDМарки"]);
            comboBoxМодель.SelectedValue = clsMisc.DBout(dr["UIDМодели"]);
            comboBoxПоколение.SelectedValue = clsMisc.DBout(dr["UIDПоколения"]);
            textEditVIN.Text = clsMisc.DBout((string)dr["VIN"]);
            textEditНомерКузова.Text = clsMisc.DBout((string)dr["НомерКузова"]);
            labelColor.BackColor = Color.FromArgb(Convert.ToInt32(dr["ЦветRGB"]));
            comboBoxСтатусАвто.SelectedValue = clsMisc.DBout(dr["IdСтатусАвто"]);
            textEditСтоимость.Text = $"{clsMisc.DBout(dr["Стоимость"].ToString()):C2}";
            comboBoxТипТоплива.SelectedValue = clsMisc.DBout(dr["IdТипТоплива"]);
            comboBoxТипПривода.SelectedValue = clsMisc.DBout(dr["IdТипПривода"]);
            comboBoxТипКузова.SelectedValue = clsMisc.DBout(dr["IdТипКузова"]);
            comboBoxТипРуля.SelectedValue = clsMisc.DBout(dr["IdТипРуля"]);
            comboBoxТипКПП.SelectedValue = clsMisc.DBout(dr["IdТипКПП"]);
            textEditГодВыпуска.Text = clsMisc.DBout((string)dr["ГодВыпуска"]);
            textEditПробег.Text = clsMisc.DBout(dr["Пробег"].ToString());
            comboBoxОбъемДвигателя.SelectedValue =  clsMisc.DBout(dr["ОбъемДвигателя"]);
            comboBoxМощностьДвигателя.SelectedValue = clsMisc.DBout(dr["МощностьДвигателя"]);
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e) { this.DialogResult = DialogResult.Cancel; }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(comboBoxМарка.Text,
                                 comboBoxМодель.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.@UIDТовара", this.sqlFunction,
            "@UIDТовара", clsMisc.DBin(this.ForeigenKey));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.NewRecord = clsMisc.DBout(dr[0]);
            this.DialogResult = DialogResult.OK;
        }
    }

    private void comboBoxМарка_SelectedValueChanged(object sender, EventArgs e)
    {
        comboBoxМодель.ASНастроитьВыпадалку_SP
        (
            "СписокФильтров_МоделиАвто", 
            "UID", 
            "Name", 
            0, 
            "@Все", 
            0, 
            "@UIDМарки", 
            clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"])
        );
    }

    private void comboBoxМодель_SelectedIndexChanged(object sender, EventArgs e)
    {
        comboBoxПоколение.ASНастроитьВыпадалку_SP
        (
            "СписокФильтров_ПоколенияАвто",
            "UID",
            "Name",
            0,
            "@Все",
            0,
            "@UIDМарки",
            clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]),
            "@UIDМодели",
            clsMisc.DBin(comboBoxМодель.ASSelectedRow()["UID"])
        );
    }

    private void textEditТолькоЦыфры_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = !(Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Delete);
    }

    private void simpleButtonСохранить_Click_1(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(new List<Control>()
        {
            comboBoxМарка,
            comboBoxМодель,
            comboBoxПоколение,
            comboBoxСтатусАвто, 
            comboBoxТипТоплива,
            comboBoxТипПривода,
            comboBoxТипКузова,
            comboBoxТипРуля,
            comboBoxТипКПП,
            textEditГодВыпуска,
            textEditПробег,
            textEditVIN,
            comboBoxОбъемДвигателя,
            comboBoxМощностьДвигателя,
            textEditНомерКузова,
            textEditСтоимость
        }))

        {
            return;
        }

        var response = clsSql.ExecuteSP("ГаражАвто_SIUD", this.sqlFunction,
            "@UIDТовара", clsMisc.DBin(this.ForeigenKey),
            "@UIDМарки", clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]),
            "@UIDМодели", clsMisc.DBin(comboBoxМодель.ASSelectedRow()["UID"]),
            "@UIDПоколения", clsMisc.DBin(comboBoxПоколение.ASSelectedRow()["UID"]),
            "@ОбновитьСтатистику", clsMisc.DBin((object)checkBoxОбновитьСтатистику.Checked),
            "@Стоимость", clsMisc.DBin(textEditСтоимость.Text),
            "@IdСтатусАвто", clsMisc.DBin(comboBoxСтатусАвто.ASSelectedRow()["Id"]),
            "@IdТипТоплива", clsMisc.DBin(comboBoxТипТоплива.ASSelectedRow()["Id"]),
            "@IdТипПривода", clsMisc.DBin(comboBoxТипПривода.ASSelectedRow()["Id"]),
            "@IdТипКузова", clsMisc.DBin(comboBoxТипКузова.ASSelectedRow()["Id"]),
            "@IdТипРуля", clsMisc.DBin(comboBoxТипРуля.ASSelectedRow()["Id"]),
            "@IdТипКПП", clsMisc.DBin(comboBoxТипКПП.ASSelectedRow()["Id"]),
            "@ГодВыпуска", clsMisc.DBin(textEditГодВыпуска.Text),
            "@Пробег", clsMisc.DBin(textEditПробег.Text),
            "@ЦветRGB", clsMisc.DBin(labelColor.BackColor.ToArgb().ToString()),
            "@VIN", clsMisc.DBin(textEditVIN.Text),
            "@ОбъемДвигателя", clsMisc.DBin(comboBoxОбъемДвигателя.SelectedValue),
            "@МощностьДвигателя", clsMisc.DBin(comboBoxМощностьДвигателя.SelectedValue),
            "@НомерКузова", clsMisc.DBin(textEditНомерКузова.Text));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            this.NewRecord = clsMisc.DBout(dr[0]);
            this.DialogResult = DialogResult.OK;
        }
    }

    private void simpleButtonColor_Click(object sender, EventArgs e)
    {
        if (textEditЦветАвто.ShowDialog() == DialogResult.OK)
        {
            labelColor.BackColor = textEditЦветАвто.Color;
        }
    }

}
