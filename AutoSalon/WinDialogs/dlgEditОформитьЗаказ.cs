using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditОформитьЗаказ : Form
{
    private Guid? UIDКлиента;
    private Guid? UIDТовара;
    private decimal? СтоимостьАвто;
    private clsMisc.ASSqlFunction SqlFunction;
    public Guid? UIDЗаказа;
    
    public dlgEditОформитьЗаказ()
    {
            InitializeComponent();
    }

    private void ЗаполнитьПоля()
    {
        memoExEditПол.DataSource = clsSql.ExecuteQuery("SELECT * FROM vКлиентыПол").dataTable;
        memoExEditПол.ValueMember = "Id";
        memoExEditПол.DisplayMember = "Наименование";
        memoExEditПол.SelectedItem = 0;

        // Объем двигателя
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

        // Мощность
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

        comboBoxМарка.ASНастроитьВыпадалку_SP("СписокФильтров_МаркиАвто", "UID", "Name", 0, "@Все", 0);
        comboBoxТипТоплива.ASНастроитьВыпадалку_SP("СписокФильтров_ТипТоплива", "Id", "Name", 0, "@Все", 0);
        comboBoxТипПривода.ASНастроитьВыпадалку_SP("СписокФильтров_ТипПривода", "Id", "Name", 0, "@Все", 0); 
        comboBoxТипРуля.ASНастроитьВыпадалку_SP("СписокФильтров_ТипРуля", "Id", "Name", 0, "@Все", 0);
        comboBoxТипКПП.ASНастроитьВыпадалку_SP("СписокФильтров_ТипКПП", "Id", "Name", 0, "@Все", 0);
        comboBoxСтатусЗаказа.ASНастроитьВыпадалку_SP("СписокФильтров_СтатусыЗаказа", "Id", "Name", 0, "@Все", 0);

    }

    private void ЗаполнитьДанныеАвто(DataRow dr)
    {
        comboBoxМарка.SelectedValue = clsMisc.DBout(dr["UIDМарки"]);

        comboBoxМодель.ASНастроитьВыпадалку_SP("СписокФильтров_МоделиАвто", "UID", "Name", 0, "@Все", 0, "@UIDМарки", clsMisc.DBin(comboBoxМарка.ASSelectedRow()["UID"]));
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
        СтоимостьАвто = Convert.ToDecimal(clsMisc.DBout(dr["Стоимость"].ToString()));
        textEditСтоимость.Text = clsMisc.DBout(dr["Стоимость"].ToString());
        comboBoxТипТоплива.SelectedValue = clsMisc.DBout(dr["IdТипТоплива"]);
        comboBoxТипПривода.SelectedValue = clsMisc.DBout(dr["IdТипПривода"]); 
        comboBoxТипРуля.SelectedValue = clsMisc.DBout(dr["IdТипРуля"]);
        comboBoxТипКПП.SelectedValue = clsMisc.DBout(dr["IdТипКПП"]);
        textEditГодВыпуска.Text = (string)clsMisc.DBout(dr["ГодВыпуска"]);
        textEditПробег.Text = clsMisc.DBout(dr["Пробег"].ToString());
        comboBoxОбъемДвигателя.SelectedValue = clsMisc.DBout(dr["ОбъемДвигателя"]);
        comboBoxМощностьДвигателя.SelectedValue = clsMisc.DBout(dr["МощностьДвигателя"]);
    }

    public dlgEditОформитьЗаказ(Guid UIDТовара, Guid? UIDЗаказа, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        ЗаполнитьПоля();
        this.SqlFunction = sqlFunction;
        this.UIDТовара = UIDТовара;
        this.UIDЗаказа = UIDЗаказа;

        var АвтоDR = clsSql.ExecuteSP(
            "dbo.ГаражАвто_SIUD",
            clsMisc.ASSqlFunction.Select,
            "@UIDТовара", UIDТовара).dataTable.RowsDR().SingleOrDefault();
        ЗаполнитьДанныеАвто(АвтоDR);

        if (sqlFunction == clsMisc.ASSqlFunction.Insert)
        {
            this.Text = "Оформить заказ";
        }

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            this.Text = "Редактировать заказ";

            var ЗаказDR = clsSql.ExecuteSP(
                "dbo.Заказы_SIUD",
                clsMisc.ASSqlFunction.Select,
                "@UIDЗаказа", UIDЗаказа).dataTable.RowsDR().SingleOrDefault();

            ЗаполнитьДанныеКлиента((Guid)ЗаказDR["UIDКлиента"]);

            comboBoxСтатусЗаказа.SelectedValue = clsMisc.DBout(ЗаказDR["IdСтатусаЗаказа"]);
            labelНомерЗаказа.Text = clsMisc.DBout(ЗаказDR["НомерЗаказа"].ToString());
            textBoxОплачено.Text = clsMisc.DBout(ЗаказDR["СуммаОплаты"].ToString());
            textEditСтоимость.Text = clsMisc.DBout(ЗаказDR["Стоимость"].ToString()); // перзаписываем стоимость из заказа
        }
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
        var КлиентDR = clsSql.ExecuteSP(
            "dbo.Клиенты_SIUD", 
            clsMisc.ASSqlFunction.Select, 
            "@UIDКлиента", UIDКлиента).dataTable.RowsDR().SingleOrDefault();

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

        textEditФамилия.Text = clsMisc.DBout((string)КлиентDR["Фамилия"]);
        textEditИмя.Text = clsMisc.DBout((string)КлиентDR["Имя"]);
        textEditОтчество.Text = clsMisc.DBout((string)КлиентDR["Отчество"]);
        textEditТелефон.Text = clsMisc.DBout((string)КлиентDR["Номер телефона"]);
        textEditEmail.Text = clsMisc.DBout(КлиентDR["Email"].ToString());
        textBoxАдресРегистрации.Text = clsMisc.DBout((string)КлиентDR["Адрес регистрации"]);
        TextBoxПДСерия.Text = clsMisc.DBout((string)КлиентDR["ПД Серия"]);
        TextBoxПДНомер.Text = clsMisc.DBout((string)КлиентDR["ПД Номер"]);
        TextBoxПДКодПодразделения.Text = clsMisc.DBout((string)КлиентDR["ПД Код подразделения"]);
        TextBoxПДДатаВыдачи.Value = (DateTime)clsMisc.DBout(КлиентDR["ПД Дата выдачи"]);
        dateEditДатаРождения.Value = (DateTime)clsMisc.DBout(КлиентDR["ПД Дата рождения"]);
        memoExEditПол.SelectedValue = Convert.ToInt16(clsMisc.DBout(КлиентDR["IdПола"]));
        textBoxПДКемВыдан.Text = clsMisc.DBout((string)КлиентDR["ПД Кем выдан"]);
        this.UIDКлиента = UIDКлиента;
    }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(
            UIDТовара,
            СтоимостьАвто, 
            UIDКлиента,
            textBoxОплачено.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.Заказы_SIUD", SqlFunction,
            "@UIDЗаказа", UIDЗаказа,
            "@UIDТовара", UIDТовара,
            "@СтоимостьАвто", СтоимостьАвто,
            "@UIDКлиента", UIDКлиента,
            "@IdСтатусаЗаказа", comboBoxСтатусЗаказа.SelectedValue,
            "@СуммаОплаты", textBoxОплачено.Text);

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            UIDЗаказа = (Guid)clsMisc.DBout(dr[0]);
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}
