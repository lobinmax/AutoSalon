using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditОформитьЗаказ : Form
{
    private Guid? UIDКлиента;
    private Guid? UIDТовара;
    private Guid? UIDСтоимости;
    private clsMisc.ASSqlFunction SqlFunction;
    public Guid? UIDЗаказа;
    
    public dlgEditОформитьЗаказ()
    {
        InitializeComponent();
    }

    public dlgEditОформитьЗаказ(Guid UIDТовара)
    {
        InitializeComponent();
        this.UIDТовара = UIDТовара;
        this.SqlFunction = clsMisc.ASSqlFunction.Insert;

        memoExEditПол.DataSource = clsSql.ExecuteQuery("SELECT * FROM vКлиентыПол").dataTable;
        memoExEditПол.ValueMember = "Id";
        memoExEditПол.DisplayMember = "Наименование";
        memoExEditПол.SelectedItem = 0;

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

        var dr = clsSql.ExecuteSP("dbo.ГаражАвто_SIUD", clsMisc.ASSqlFunction.Select, "@UIDТовара", UIDТовара).dataTable.RowsDR().SingleOrDefault();

        comboBoxМарка.SelectedValue = clsMisc.DBout(dr["UIDМарки"]);

        comboBoxМодель.ASНастроитьВыпадалку_SP("СписокФильтров_МоделиАвто","UID","Name", 0, "@Все", 0, "@UIDМарки", clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]));
        comboBoxМодель.SelectedValue = clsMisc.DBout(dr["UIDМодели"]);

        comboBoxПоколение.ASНастроитьВыпадалку_SP("СписокФильтров_ПоколенияАвто", "UID", "Name", 0, "@Все", 0,
            "@UIDМарки",
            clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]),
            "@UIDМодели",
            clsMisc.DBin(comboBoxМодель.ASSelectedRow()["UID"]));
        comboBoxПоколение.SelectedValue = clsMisc.DBout(dr["UIDПоколения"]);

        textEditVIN.Text = (string)clsMisc.DBout(dr["VIN"]);
        textEditНомерКузова.Text = (string)clsMisc.DBout(dr["НомерКузова"]);
        labelColor.BackColor = Color.FromArgb(Convert.ToInt32(dr["ЦветRGB"]));
        comboBoxСтатусЗаказа.SelectedValue = clsMisc.DBout(dr["IdСтатусАвто"]);
        UIDСтоимости = (Guid)clsMisc.DBout(dr["UIDСтоимости"]);
        textEditСтоимость.Text = clsMisc.DBout(dr["Стоимость"].ToString());
        comboBoxТипТоплива.SelectedValue = clsMisc.DBout(dr["IdТипТоплива"]);
        comboBoxТипПривода.SelectedValue = clsMisc.DBout(dr["IdТипПривода"]);
        comboBoxТипКузова.SelectedValue = clsMisc.DBout(dr["IdТипКузова"]);
        comboBoxТипРуля.SelectedValue = clsMisc.DBout(dr["IdТипРуля"]);
        comboBoxТипКПП.SelectedValue = clsMisc.DBout(dr["IdТипКПП"]);
        textEditГодВыпуска.Text = (string)clsMisc.DBout(dr["ГодВыпуска"]);
        textEditПробег.Text = clsMisc.DBout(dr["Пробег"].ToString());
        comboBoxОбъемДвигателя.SelectedValue = clsMisc.DBout(dr["ОбъемДвигателя"]);
        comboBoxМощностьДвигателя.SelectedValue = clsMisc.DBout(dr["МощностьДвигателя"]);
    }

    public dlgEditОформитьЗаказ(Guid UIDЗаказа, clsMisc.ASSqlFunction sqlFunction = clsMisc.ASSqlFunction.Update)
    {
        var ЗаказDR = clsSql.ExecuteSP(
            "dbo.Заказы_SIUD",
            clsMisc.ASSqlFunction.Select,
            "@UIDЗаказа", UIDЗаказа).dataTable.RowsDR().SingleOrDefault();

        ЗаполнитьДанныеКлиента((Guid)ЗаказDR["UIDКлиента"]);
        new dlgEditОформитьЗаказ((Guid)ЗаказDR["UIDКлиента"]);
        textEditСтоимость.Text = (string)clsMisc.DBout(ЗаказDR["Стоимость"]);
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
            textEditФамилия.Text = null;
            textEditИмя.Text = null;
            textEditОтчество.Text = null;
            textEditТелефон.Text = null;
            textEditEmail.Text = null;
            textBoxАдресРегистрации.Text = null;
            TextBoxПДСерия.Text = null;
            TextBoxПДНомер.Text = null;
            TextBoxПДКодПодразделения.Text = null;
            TextBoxПДДатаВыдачи.Text = null;
            dateEditДатаРождения.Text = null;
            memoExEditПол.SelectedItem = 0;
            textBoxПДКемВыдан.Text = null;

            this.UIDКлиента = null;
            return;
        }

        textEditФамилия.Text = clsMisc.DBout(КлиентDR["Фамилия"].ToString());
        textEditИмя.Text = clsMisc.DBout(КлиентDR["Имя"].ToString());
        textEditОтчество.Text = clsMisc.DBout(КлиентDR["Отчество"].ToString());
        textEditТелефон.Text = clsMisc.DBout(КлиентDR["Номер телефона"].ToString());
        textEditEmail.Text = clsMisc.DBout(КлиентDR["Email"].ToString());
        textBoxАдресРегистрации.Text = clsMisc.DBout(КлиентDR["Адрес регистрации"].ToString());
        TextBoxПДСерия.Text = clsMisc.DBout(КлиентDR["ПД Серия"].ToString());
        TextBoxПДНомер.Text = clsMisc.DBout(КлиентDR["ПД Номер"].ToString());
        TextBoxПДКодПодразделения.Text = clsMisc.DBout(КлиентDR["ПД Код подразделения"].ToString());
        TextBoxПДДатаВыдачи.Value = (DateTime)clsMisc.DBout(КлиентDR["ПД Дата выдачи"]);
        dateEditДатаРождения.Value = (DateTime)clsMisc.DBout(КлиентDR["ПД Дата рождения"]);
        memoExEditПол.SelectedValue = Convert.ToInt16(clsMisc.DBout(КлиентDR["IdПола"]));
        textBoxПДКемВыдан.Text = clsMisc.DBout(КлиентDR["ПД Кем выдан"].ToString());
        this.UIDКлиента = UIDКлиента;
    }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(
            UIDТовара,
            UIDСтоимости, 
            UIDКлиента))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.Заказы_SIUD", SqlFunction,
            "@UIDЗаказа", UIDЗаказа,
            "@UIDТовара", UIDТовара,
            "@UIDСтоимости", UIDСтоимости,
            "@UIDКлиента", UIDКлиента,
            "@IdСтатусаЗаказа", comboBoxСтатусЗаказа.SelectedValue,
            "@СуммаОплаты", textBoxОплачено.Text);

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            UIDЗаказа = (Guid)dr[0];
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}
