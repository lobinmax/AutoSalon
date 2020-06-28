using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditКлиенты : Form
{
    public Guid UIDКлиента { get; set; }
    private Guid? ForeigenKey;
    clsMisc.ASSqlFunction SqlFunction;

    public dlgEditКлиенты()
    {
        InitializeComponent();
    }

    public dlgEditКлиенты(Guid? UIDКлиента, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();
        this.Text = "Добавить клиента";
        ForeigenKey = UIDКлиента;
        SqlFunction = sqlFunction;

        memoExEditПол.DataSource = clsSql.ExecuteQuery("SELECT * FROM vКлиентыПол").dataTable;
        memoExEditПол.ValueMember = "Id";
        memoExEditПол.DisplayMember = "Наименование";
        memoExEditПол.SelectedItem = 0;

        if (sqlFunction == clsMisc.ASSqlFunction.Update)
        {
            this.Text = "Редактировать клиента";

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
    }


    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        var checkListControl = new List<Control>();
        checkListControl.Add(textEditФамилия);
        checkListControl.Add(textEditИмя);
        checkListControl.Add(textEditОтчество);
        checkListControl.Add(TextBoxПДСерия);
        checkListControl.Add(TextBoxПДНомер);
        checkListControl.Add(TextBoxПДДатаВыдачи);
        checkListControl.Add(textBoxПДКемВыдан);
        checkListControl.Add(TextBoxПДКодПодразделения);
        checkListControl.Add(dateEditДатаРождения);
        checkListControl.Add(memoExEditПол);
        checkListControl.Add(textBoxАдресРегистрации);

        if (!clsMisc.CheckFields(checkListControl))
        {
            return;
        }

        var response = clsSql.ExecuteSP("Клиенты_SIUD", SqlFunction,
            "@UIDКлиента", clsMisc.DBin(ForeigenKey),
            "@Фамилия", clsMisc.DBin(textEditФамилия.Text),
            "@Имя", clsMisc.DBin(textEditИмя.Text),
            "@Отчество", clsMisc.DBin(textEditОтчество.Text),
            "@ПДСерия", clsMisc.DBin(TextBoxПДСерия.Text),
            "@ПДНомер", clsMisc.DBin(TextBoxПДНомер.Text),
            "@ПДКодПодразделения", clsMisc.DBin(TextBoxПДКодПодразделения.Text),
            "@ПДДатаВыдачи", clsMisc.DBin(TextBoxПДДатаВыдачи.Text),
            "@ПДДатаРождения", clsMisc.DBin(dateEditДатаРождения.Text),
            "@IdПола", clsMisc.DBin(memoExEditПол.SelectedValue),
            "@ПДКемВыдан", clsMisc.DBin(textBoxПДКемВыдан.Text),
            "@АдресРегистрации", clsMisc.DBin(textBoxАдресРегистрации.Text),
            "@Телефон", clsMisc.DBin(textEditТелефон.Text),
            "@Email", clsMisc.DBin(textEditEmail.Text));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            UIDКлиента = (Guid)dr[0];
            this.Tag = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
}
