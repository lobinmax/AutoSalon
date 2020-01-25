using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

public partial class dlgEditСотрудник : DevExpress.XtraEditors.XtraForm
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

        gridLookUpEditДолжности.Properties.DataSource = clsSql.ExecuteSP("dbo.Должности_SIUD").dataTable;
        gridLookUpEditДолжности.Properties.PopulateViewColumns();
        gridLookUpEditДолжности.EditValue=0;
        gridLookUpEditДолжности.Properties.View.ASНастроитьGridView(false, "Наименование");
        this.SqlFunction = sqlFunction;

        if (sqlFunction == clsMisc.ASSqlFunction.Insert)
        {
            this.Text = "Добавить сотрудника";
        }
        else
        {
            this.Text = "Редактировать сотрудника";
            this.ForeigenKey = UIDСотрудника;
            var dt = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", clsMisc.ASSqlFunction.Select, "@UIDСотрудника", UIDСотрудника).dataTable;
            textEditLogin.Enabled = false;

            DataRow dr;
            if(dt.Rows.Count != 0)
            {
                dr = dt.Rows[0];
                textEditLogin.EditValue = dr["Логин"];
                textEditФамилия.EditValue = dr["Фамилия"];
                textEditИмя.EditValue = dr["Имя"];
                textEditОтчество.EditValue = dr["Отчество"];
                gridLookUpEditДолжности.EditValue = dr["IdДолжности"];
                textEditТелефон.EditValue = dr["Телефон"];
                dateEditДатаРождения.EditValue = dr["Дата рождения"];
                memoExEditПол.SelectedIndex = Convert.ToInt32(dr["IdПола"]);
                textEditEmail.EditValue = dr["Email"];
            }

        }
        
    }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        if (!clsMisc.CheckFields(textEditLogin.EditValue, 
                textEditФамилия.EditValue, 
                textEditИмя.EditValue, 
                textEditОтчество.EditValue,
                gridLookUpEditДолжности.EditValue))
        {
            return;
        }

        var response = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", this.SqlFunction,
            "@UIDСотрудника", this.ForeigenKey,
            "@Логин", clsMisc.DBin(textEditLogin.EditValue),
            "@Фамилия", clsMisc.DBin(textEditФамилия.EditValue),
            "@Имя", clsMisc.DBin(textEditИмя.EditValue),
            "@Отчество", clsMisc.DBin(textEditОтчество.EditValue),
            "@ДатаРождения", clsMisc.DBin(dateEditДатаРождения.EditValue),
            "@Телефон", clsMisc.DBin(textEditТелефон.EditValue),
            "@Email", clsMisc.DBin(textEditEmail.EditValue),
            "@IdПола", clsMisc.DBin(memoExEditПол.SelectedIndex),
            "@IdДолжности", clsMisc.DBin(gridLookUpEditДолжности.EditValue));

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
