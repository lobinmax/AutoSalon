using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class frКлиенты : Form
{
    public frКлиенты()
    {
        InitializeComponent();
    }

    private void frКлиенты_Load(object sender, EventArgs e)
    {
        ASTimer timer = new ASTimer
            (
                gridViewКлиента,
                new List<Button> { this.buttonИзменитьКлиента, this.buttonУдалитьКлиента }
            );

        Обновить();
    }

    private void buttonОбновить_Click(object sender, EventArgs e)
    {
        Обновить();
    }

    private void Обновить(object value = null)
    {
        var focusDR = gridViewКлиента.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault(); 
        if (focusDR != null)
        {
            value = (Guid?) focusDR.Cells["UIDКлиента"].Value;
        }

        var КлиентыDT = clsSql.ExecuteSP("dbo.Клиенты_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        gridViewКлиента.ASОбновитьСохранитьВыделение(КлиентыDT, "UIDКлиента", value);
        gridViewКлиента.ASНастроитьGridView(true, "UIDКлиента");
    }

    private void gridViewКлиента_MouseClick(object sender, MouseEventArgs e)
    {
        var menu = new ContextMenuStrip();
        e.МенюДляAddEditDelete(menu, (DataGridView)sender, buttonДобавитьКлиента_Click, buttonИзменитьКлиента_Click, buttonУдалитьКлиента_Click);
    }

    private void buttonДобавитьКлиента_Click(object sender, EventArgs e)
    {
        using (var dlgEditКлиенты = new dlgEditКлиенты(null, clsMisc.ASSqlFunction.Insert))
        {
            if (dlgEditКлиенты.ShowDialog() == DialogResult.OK)
            {
                Обновить(dlgEditКлиенты.UIDКлиента);
            }
        }
    }

    private void buttonИзменитьКлиента_Click(object sender, EventArgs e)
    {
        var focusDR = gridViewКлиента.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR == null)
        {
            return;
        }

        using (var dlgEditКлиенты = new dlgEditКлиенты((Guid?)focusDR.Cells["UIDКлиента"].Value, clsMisc.ASSqlFunction.Update))
        {
            if (dlgEditКлиенты.ShowDialog() == DialogResult.OK)
            {
                Обновить(dlgEditКлиенты.UIDКлиента);
            }
        }
    }

    private void buttonУдалитьКлиента_Click(object sender, EventArgs e)
    {
        var focusDR = gridViewКлиента.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR == null)
        {
            return;
        }

        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                            Program.ProductName,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.Клиенты_SIUD",
                                      clsMisc.ASSqlFunction.Delete, 
                                      "@UIDКлиента", clsMisc.DBin(focusDR.Cells["UIDКлиента"].Value));
            Обновить();
        }
    }
}
