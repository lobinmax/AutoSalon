using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditОформитьЗаказ : Form
{
    private Guid? ForeigenKey;

    public dlgEditОформитьЗаказ()
    {
        InitializeComponent();
    }

    public dlgEditОформитьЗаказ(Guid? UIDТовара, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        ForeigenKey = UIDТовара;

        comboBoxМарка.ASНастроитьВыпадалку_SP("СписокФильтров_МаркиАвто", "UID", "Name", 0, "@Все", 0);
        comboBoxТипТоплива.ASНастроитьВыпадалку_SP("СписокФильтров_ТипТоплива", "Id", "Name", 0, "@Все", 0);
        comboBoxТипПривода.ASНастроитьВыпадалку_SP("СписокФильтров_ТипПривода", "Id", "Name", 0, "@Все", 0);
        comboBoxТипКузова.ASНастроитьВыпадалку_SP("СписокФильтров_ТипКузова", "Id", "Name", 0, "@Все", 0);
        comboBoxТипРуля.ASНастроитьВыпадалку_SP("СписокФильтров_ТипРуля", "Id", "Name", 0, "@Все", 0);
        comboBoxТипКПП.ASНастроитьВыпадалку_SP("СписокФильтров_ТипКПП", "Id", "Name", 0, "@Все", 0);
        comboBoxСтатусЗаказа.ASНастроитьВыпадалку_SP("СписокФильтров_СтатусыЗаказа", "Id", "Name", 0, "@Все", 0);

        var dt = new DataTable() { Columns = { new DataColumn("ValueMember"), new DataColumn("DisplayMember") } };
        for (var i = 0.1m; i <= 10; i = i + 0.1m)
        {
            var dr0 = dt.NewRow();
            dr0["ValueMember"] = i;
            dr0["DisplayMember"] = $"{Math.Round(i, 1)} л";
            dt.Rows.Add(dr0);
        }
        comboBoxОбъемДвигателя.DataSource = dt;
        comboBoxОбъемДвигателя.ValueMember = "ValueMember";
        comboBoxОбъемДвигателя.DisplayMember = "DisplayMember";
        comboBoxОбъемДвигателя.SelectedValue = 1.5m;

        var dt1 = new DataTable() { Columns = { new DataColumn("ValueMember"), new DataColumn("DisplayMember") } };
        for (var i = 30; i <= 600; i = i + 10)
        {
            var dr1 = dt1.NewRow();
            dr1["ValueMember"] = i;
            dr1["DisplayMember"] = $"{i} л.c.";
            dt1.Rows.Add(dr1);
        }
        comboBoxМощностьДвигателя.DataSource = dt1;
        comboBoxМощностьДвигателя.ValueMember = "ValueMember";
        comboBoxМощностьДвигателя.DisplayMember = "DisplayMember";
        comboBoxМощностьДвигателя.SelectedValue = 80;

        var dr = clsSql.ExecuteSP("dbo.ГаражАвто_SIUD", clsMisc.ASSqlFunction.Select, "@UIDТовара", ForeigenKey).dataTable.RowsDR().SingleOrDefault();

        comboBoxМарка.SelectedValue = clsMisc.DBout(dr["UIDМарки"]);

        comboBoxМодель.ASНастроитьВыпадалку_SP("СписокФильтров_МоделиАвто","UID","Name", 0, "@Все", 0, "@UIDМарки", clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]));
        comboBoxМодель.SelectedValue = clsMisc.DBout(dr["UIDМодели"]);

        comboBoxПоколение.ASНастроитьВыпадалку_SP("СписокФильтров_ПоколенияАвто", "UID", "Name", 0, "@Все", 0,
            "@UIDМарки",
            clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]),
            "@UIDМодели",
            clsMisc.DBin(comboBoxМодель.ASSelectedRow()["UID"]));
        comboBoxПоколение.SelectedValue = clsMisc.DBout(dr["UIDПоколения"]);

        textEditVIN.Text = clsMisc.DBout((string)dr["VIN"]);
        textEditНомерКузова.Text = clsMisc.DBout((string)dr["НомерКузова"]);
        labelColor.BackColor = Color.FromArgb(Convert.ToInt32(dr["ЦветRGB"]));
        comboBoxСтатусЗаказа.SelectedValue = clsMisc.DBout(dr["IdСтатусАвто"]);
        textEditСтоимость.Text = clsMisc.DBout(dr["Стоимость"].ToString());
        comboBoxТипТоплива.SelectedValue = clsMisc.DBout(dr["IdТипТоплива"]);
        comboBoxТипПривода.SelectedValue = clsMisc.DBout(dr["IdТипПривода"]);
        comboBoxТипКузова.SelectedValue = clsMisc.DBout(dr["IdТипКузова"]);
        comboBoxТипРуля.SelectedValue = clsMisc.DBout(dr["IdТипРуля"]);
        comboBoxТипКПП.SelectedValue = clsMisc.DBout(dr["IdТипКПП"]);
        textEditГодВыпуска.Text = clsMisc.DBout((string)dr["ГодВыпуска"]);
        textEditПробег.Text = clsMisc.DBout(dr["Пробег"].ToString());
        comboBoxОбъемДвигателя.SelectedValue = clsMisc.DBout(dr["ОбъемДвигателя"]);
        comboBoxМощностьДвигателя.SelectedValue = clsMisc.DBout(dr["МощностьДвигателя"]);
    }
    

    private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void textEditФамилия_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void buttonНайтиКлиента_Click(object sender, EventArgs e)
    {
        using (var f = new dlgEditНайденныеКлиенты())
        {
            if(f.ShowDialog() == DialogResult.OK)
            {
                ЗаполнитьДанныеКлиента(f.UIDКлиента);
            }
        }
    }

    private void buttonСоздатьКлиента_Click(object sender, EventArgs e)
    {
        using (var dlgEditКлиенты = new dlgEditКлиенты(null, clsMisc.ASSqlFunction.Insert))
        {
            if (dlgEditКлиенты.ShowDialog() == DialogResult.OK)
            {
                ЗаполнитьДанныеКлиента(dlgEditКлиенты.UIDКлиента);
            }
        }
    }

    private void ЗаполнитьДанныеКлиента(Guid UIDКлиента)
    {
        var КлиентDR = clsSql.ExecuteSP("dbo.Клиенты_SIUD", clsMisc.ASSqlFunction.Select, "@UIDКлиента", UIDКлиента).dataTable.RowsDR().SingleOrDefault();
        if (КлиентDR == null)
        {
            return;
        }

        textEditФамилия.Text = clsMisc.DBout((string)КлиентDR["Фамилия"]);
        textEditИмя.Text = clsMisc.DBout((string)КлиентDR["Имя"]);
        textEditОтчество.Text = clsMisc.DBout((string)КлиентDR["Отчество"]);
        textEditТелефон.Text = clsMisc.DBout((string)КлиентDR["Номер телефона"]);
        textEditEmail.Text = clsMisc.DBout((string)КлиентDR["Email"]);
        textBoxАдресРегистрации.Text = clsMisc.DBout((string)КлиентDR["Адрес регистрации"]);
        TextBoxПДСерия.Text = clsMisc.DBout((string)КлиентDR["ПД Серия"]);
        TextBoxПДНомер.Text = clsMisc.DBout((string)КлиентDR["ПД Номер"]);
        TextBoxПДКодПодразделения.Text = clsMisc.DBout((string)КлиентDR["ПД Код подразделения"]);
        TextBoxПДДатаВыдачи.Value = (DateTime)clsMisc.DBout(КлиентDR["ПД Дата выдачи"]);
        dateEditДатаРождения.Value = (DateTime)clsMisc.DBout(КлиентDR["ПД Дата рождения"]);
        memoExEditПол.SelectedValue = Convert.ToInt16(clsMisc.DBout(КлиентDR["IdПола"]));
        textBoxПДКемВыдан.Text = clsMisc.DBout((string)КлиентDR["ПД Кем выдан"]);
    }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {

    }
}
