using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class frЗаказы : Form
{
    public frЗаказы()
    {
        InitializeComponent();
    }

    private void frЗаказы_Load(object sender, EventArgs e)
    {
        ASTimer timer = new ASTimer
        (
            gridViewЗаказы,
            new List<Button> { this.buttonИзменитьЗаказ, this.buttonУдалитьЗаказ }
        )
        { Enabled = true };

        Обновить();
    }

    private void buttonОбновить_Click(object sender, EventArgs e)
    {
        Обновить();
    }

    private void Обновить(object value = null)
    {
        var focusDR = gridViewЗаказы.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        if (focusDR != null)
        {
            value = (Guid?)focusDR.Cells["UIDЗаказа"].Value;
        }

        var ЗаказыDT = clsSql.ExecuteSP("dbo.Заказы_SIUD", clsMisc.ASSqlFunction.ViewForm).dataTable;
        gridViewЗаказы.ASОбновитьСохранитьВыделение(ЗаказыDT, "UIDЗаказа", value);
        gridViewЗаказы.ASНастроитьGridView(true, "UIDЗаказа", "UIDТовара");
    }

    private void gridViewЗаказы_MouseClick(object sender, MouseEventArgs e)
    {
        var FocusDR = gridViewЗаказы.SelectedRows.Cast<DataGridViewRow>().SingleOrDefault();
        var menu = new ContextMenuStrip();

        if (FocusDR != null && e.Button == MouseButtons.Right)
        {
            menu.Items.Add("Изменить", AutoSalon.Properties.Resources.Edit_16x16, ИзменитьЗаказ);
            menu.Items.Add("Удалить", AutoSalon.Properties.Resources.Delete_16x16, УдалитьЗаказ);

            menu.Show(MousePosition);
        }
    }

    private void ИзменитьЗаказ(object sender, EventArgs e)
    {
        using (var dlgEditОформитьЗаказ = new dlgEditОформитьЗаказ(
            (Guid)gridViewЗаказы["UIDТовара", gridViewЗаказы.CurrentRow.Index].Value,
            (Guid)gridViewЗаказы["UIDЗаказа", gridViewЗаказы.CurrentRow.Index].Value, 
            clsMisc.ASSqlFunction.Update))
        {
            var result = dlgEditОформитьЗаказ.ShowDialog();
            if (result == DialogResult.OK)
            {
                Обновить(dlgEditОформитьЗаказ.UIDЗаказа);
            }
        }
    }

    private void УдалитьЗаказ(object sender, EventArgs e)
    {
        if (MessageBox.Show("Вы уверены что хотите удалить запись?",
                                                        Program.ProductName,
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question) == DialogResult.Yes)
        {
            clsSql.ExecuteSPNonQuery("dbo.Заказы_SIUD",
                                      clsMisc.ASSqlFunction.Delete, "@UIDЗаказа",
                                      clsMisc.DBin(gridViewЗаказы["UIDЗаказа", gridViewЗаказы.CurrentRow.Index].Value));
            Обновить();
        }
    }
}
