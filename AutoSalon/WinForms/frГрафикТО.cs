using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class frГрафикТО : Form
{
    private Guid UIDТовара;

    public Guid UIDТовара1 { get => UIDТовара; set => UIDТовара = value; }

    public frГрафикТО(Guid UIDТовара)
    {
        InitializeComponent();

        this.UIDТовара1 = UIDТовара;
        this.Text = (string)clsMisc.DBout(clsSql.ExecuteScalarFunction("dbo.АвтоПолучитьСтрокой", UIDТовара.ToString()).result);
        label1НаименованиеТовара.Text = $"График технического обслуживания:{this.Text}";

        gridViewТОфакт.DataSource = clsSql.ExecuteSP("ТО_ФактГрафикПоТовару", "@UIDТОвара", UIDТовара).dataTable;
        gridViewТОфакт.ASНастроитьGridView(true, "UIDТО", "UIDТовара");

           var timerПереченьРабот = new ASTimer
            (
                dataGridПереченьРабот,
                new List<Button> { this.buttonИзменитьРаботу, this.buttonУдалитьРаботу }
            );
        Application.DoEvents();
        var timerЗапчасти = new ASTimer
            (
                dataGridЗапчасти,
                new List<Button> { this.buttonИзменитьЗапчасть, this.buttonУдалитьЗапчасть }
            );
    } 

    private void buttonОбновить_Click(object sender, EventArgs e)
    {
        gridViewТОфакт.ASОбновитьСохранитьВыделение(
            clsSql.ExecuteSP("ТО_ФактГрафикПоТовару", "@UIDТОвара", UIDТовара1).dataTable, "UIDТО");
        gridViewТОфакт.ASНастроитьGridView(true, "UIDТО", "UIDТовара");
    }
    private void gridViewТОфакт_SelectionDataSourseChanged(object sender, EventArgs e)
    {
        var focusDR = gridViewТОфакт.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null)
        {
            dataGridПереченьРабот.DataSource = clsSql.ExecuteSP
                ("dbo.ТО_ФактРаботы_SIUD", 
                clsMisc.ASSqlFunction.ViewForm, 
                "@UIDТО", clsMisc.DBin(focusDR.Cells["UIDТО"].Value)).dataTable;
            dataGridПереченьРабот.ASНастроитьGridView(true, "UIDТО", "UIDРаботы");
        }
    }

    #region Управление датой факта
    private void buttonЗадатьФакт_Click(object sender, EventArgs e)
    {
        var focusDR = gridViewТОфакт.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null && !focusDR.Cells["Наименование ТО"].Value.Equals("Итого"))
        {
            clsSql.ExecuteSPNonQuery
                (
                    "dbo.ТО_ФактГрафикПоТовару", 
                    clsMisc.ASSqlFunction.Select, 
                    "@UIDТО", focusDR.Cells["UIDТО"].Value, 
                    "@ДатаФакта", clsMisc.DBin(dateTimePicker1.Text)
                );
            buttonОбновить.PerformClick();
        }
    }
    private void buttonУдалитьФакт_Click(object sender, EventArgs e)
    {
        var focusDR = gridViewТОфакт.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null && !focusDR.Cells["Наименование ТО"].Value.Equals("Итого"))
        {
            clsSql.ExecuteSPNonQuery
                (
                    "dbo.ТО_ФактГрафикПоТовару",
                    clsMisc.ASSqlFunction.Select,
                    "@UIDТО", focusDR.Cells["UIDТО"].Value,
                    "@ДатаФакта", clsMisc.DBin("")
                );
            buttonОбновить.PerformClick();
        }
    }
    #endregion

    #region Управление видами работами

    private void buttonДобавитьРаботу_Click(object sender, EventArgs e)
    {
        var focusDR = gridViewТОфакт.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if(focusDR != null)
        {
            var dlgEditТО_ВидРаботы = new dlgEditТО_ВидРаботы
                (
                    (Guid?)focusDR.Cells["UIDТО"].Value, 
                    null, 
                    clsMisc.ASSqlFunction.Insert
                );
            if (dlgEditТО_ВидРаботы.ShowDialog()== DialogResult.OK)
            {
                buttonОбновить.PerformClick();
            }
        }
    }

    private void buttonИзменитьРаботу_Click(object sender, EventArgs e)
    {
        var focusDR = dataGridПереченьРабот.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null)
        {
            var dlgEditТО_ВидРаботы = new dlgEditТО_ВидРаботы
                (
                    (Guid?)focusDR.Cells["UIDТО"].Value, 
                    (Guid?)focusDR.Cells["UIDРаботы"].Value, 
                    clsMisc.ASSqlFunction.Update
                );
            if (dlgEditТО_ВидРаботы.ShowDialog() == DialogResult.OK)
            {
                buttonОбновить.PerformClick();
            }
        }
    }

    private void buttonУдалитьРаботу_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                                Program.ProductName,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.ТО_ФактРаботы_SIUD",
                clsMisc.ASSqlFunction.Delete, "@UIDРаботы",
                dataGridПереченьРабот["UIDРаботы", dataGridПереченьРабот.CurrentRow.Index].Value.ToString());
            buttonОбновить.PerformClick();
        }
    }
    
    private void dataGridПереченьРабот_SelectionDataSourseChanged(object sender, EventArgs e)
    {
        var focusDR = dataGridПереченьРабот.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null)
        {
            dataGridЗапчасти.DataSource = clsSql.ExecuteSP
                ("dbo.ТО_ФактЗапчасти_SIUD",
                clsMisc.ASSqlFunction.ViewForm,
                "@UIDРаботы", clsMisc.DBin(focusDR.Cells["UIDРаботы"].Value)).dataTable;
            dataGridЗапчасти.ASНастроитьGridView(true, "UIDЗапчасти", "UIDРаботы", "UIDТО");
        }
    }
    #endregion

    #region Управление запчастями

    private void buttonДобавитьЗапчасть_Click(object sender, EventArgs e)
    {
        var focusDR = dataGridПереченьРабот.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null)
        {
            var dlgEditТО_Запчасти = new dlgEditТО_Запчасти
                (
                    (Guid?)focusDR.Cells["UIDТО"].Value,
                    (Guid?)focusDR.Cells["UIDРаботы"].Value,
                    null,
                    clsMisc.ASSqlFunction.Insert
                );
            if (dlgEditТО_Запчасти.ShowDialog() == DialogResult.OK)
            {
                buttonОбновить.PerformClick();
            }
        }
    }
    private void buttonИзменитьЗапчасть_Click(object sender, EventArgs e)
    {
        var focusDR = dataGridЗапчасти.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null)
        {
            var dlgEditТО_Запчасти = new dlgEditТО_Запчасти
                (
                    (Guid?)focusDR.Cells["UIDТО"].Value,
                    (Guid?)focusDR.Cells["UIDРаботы"].Value,
                    (Guid?)focusDR.Cells["UIDЗапчасти"].Value,
                    clsMisc.ASSqlFunction.Update
                );
            if (dlgEditТО_Запчасти.ShowDialog() == DialogResult.OK)
            {
                buttonОбновить.PerformClick();
            }
        }
    }
    private void buttonУдалитьЗапчасть_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                                Program.ProductName,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.ТО_ФактЗапчасти_SIUD",
                clsMisc.ASSqlFunction.Delete, "@UIDЗапчасти",
                dataGridЗапчасти["UIDЗапчасти", dataGridЗапчасти.CurrentRow.Index].Value.ToString());
            buttonОбновить.PerformClick();
        }
    }

    #endregion
}
