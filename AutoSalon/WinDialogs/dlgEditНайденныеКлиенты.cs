using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

public partial class dlgEditНайденныеКлиенты : Form
{
    public Guid UIDКлиента { get; set; }

    public dlgEditНайденныеКлиенты()
    {
        InitializeComponent();
    }

    private void buttonПоискКлиента_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxСтрокаПоиска.Text) && !checkBox1.Checked)
        {

            ((DataTable)gridViewНайденныеКлиенты.DataSource)?.Rows.Clear();
            return;
        }
            var КлиентыDT = clsSql.ExecuteSP("КлиентаПоискПоФИО", "@ФИОПоиска", clsMisc.DBin(textBoxСтрокаПоиска.Text)).dataTable;
            gridViewНайденныеКлиенты.DataSource = КлиентыDT;
            gridViewНайденныеКлиенты.ASНастроитьGridView(true, "UIDКлиента");
    }

    private void simpleButtonСохранить_Click(object sender, EventArgs e)
    {
        var FocusDR = gridViewНайденныеКлиенты.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (FocusDR != null)
        {
            UIDКлиента = (Guid)FocusDR.Cells["UIDКлиента"].Value;
        }

        DialogResult = DialogResult.OK;
    }

    private void simpleButtonОтменить_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        textBoxСтрокаПоиска.Enabled = !checkBox1.Checked;
    }
}
