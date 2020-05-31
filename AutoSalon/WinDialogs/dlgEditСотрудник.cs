using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class dlgEditСотрудник : System.Windows.Forms.Form
{
    public object NewRecord { get; set; }
    object ForeigenKey;
    clsMisc.ASSqlFunction SqlFunction;

    public dlgEditСотрудник()
    {
        InitializeComponent();
    }
    
    public dlgEditСотрудник(object UIDСотрудника, clsMisc.ASSqlFunction sqlFunction)
    {
        InitializeComponent();

        textBoxДомен.Text = System.Environment.UserDomainName;

        gridLookUpEditДолжности.DataSource = clsSql.ExecuteSP("dbo.Должности_SIUD").dataTable;
        gridLookUpEditДолжности.ValueMember = "Id";
        gridLookUpEditДолжности.DisplayMember = "Наименование";

        memoExEditПол.DataSource = clsSql.ExecuteQuery("SELECT * FROM vКлиентыПол").dataTable;
        memoExEditПол.ValueMember = "Id";
        memoExEditПол.DisplayMember = "Наименование";

        this.SqlFunction = sqlFunction;

        if (sqlFunction == clsMisc.ASSqlFunction.Insert)
        {
            this.Text = "Добавить сотрудника";
        }
        else
        {
            this.Text = "Редактировать сотрудника";
            this.ForeigenKey = UIDСотрудника;
            var dt = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", clsMisc.ASSqlFunction.Select, "@UIDСотрудника", clsMisc.DBin(UIDСотрудника)).dataTable;
            textEditLogin.Enabled = false;

            if(dt.Rows.Count != 0)
            {
                var dr = dt.Rows[0];
                textEditLogin.Text = (string) clsMisc.DBout(dr["Логин"]);
                textEditФамилия.Text = (string) clsMisc.DBout(dr["Фамилия"]);
                textEditИмя.Text = (string) clsMisc.DBout(dr["Имя"]);
                textEditОтчество.Text = (string) clsMisc.DBout(dr["Отчество"]);
                gridLookUpEditДолжности.SelectedValue = (int) clsMisc.DBout(dr["IdДолжности"]);
                textEditТелефон.Text = (string) clsMisc.DBout(dr["Телефон"]);
                dateEditДатаРождения.Value = (DateTime) clsMisc.DBout(dr["Дата рождения"]);
                memoExEditПол.SelectedValue = Convert.ToInt16(clsMisc.DBout(dr["IdПола"].ToString()));
                textEditEmail.Text = (string) clsMisc.DBout(dr["Email"]);
            }

        }
        
    }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditLogin.Text,
                textEditLogin.Text, 
                textEditФамилия.Text, 
                textEditИмя.Text, 
                textEditОтчество.Text,
                gridLookUpEditДолжности.Text))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", this.SqlFunction,
            "@UIDСотрудника", this.ForeigenKey,
            "@Логин", clsMisc.DBin(textEditLogin.Text),
            "@Домен", clsMisc.DBin(textBoxДомен.Text),
            "@Фамилия", clsMisc.DBin(textEditФамилия.Text),
            "@Имя", clsMisc.DBin(textEditИмя.Text),
            "@Отчество", clsMisc.DBin(textEditОтчество.Text),
            "@ДатаРождения", clsMisc.DBin(dateEditДатаРождения.Text),
            "@Телефон", clsMisc.DBin(textEditТелефон.Text),
            "@Email", clsMisc.DBin(textEditEmail.Text),
            "@IdПола", clsMisc.DBin(memoExEditПол.SelectedValue),
            "@IdДолжности", clsMisc.DBin(gridLookUpEditДолжности.SelectedValue));

        if ((bool)response.success)
        {
            var dr = response.dataTable.RowsDR().SingleOrDefault();
            ForeigenKey = dr[0];
            this.DialogResult = DialogResult.OK;
        }
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
}
