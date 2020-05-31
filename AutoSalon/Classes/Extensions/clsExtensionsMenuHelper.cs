using System;
using System.Windows.Forms;

public static partial class clsExtensions
{
    /// <summary>
    //// Контекстное меню для добавить, изменить, удалить
    /// </summary>
    /// <param name="dXPopupMenu">DXPopupMenu. Создается предварительно если есть еще пункты меню</param>
    /// <param name="actionAdd">Метод добавить</param>
    /// <param name="actionEdit">Метод изменить</param>
    /// <param name="actionDelete">Метод удалить</param>
    static public void МенюДляAddEditDelete(this MouseEventArgs e,
                                            ContextMenuStrip PopupMenu,
                                            DataGridView dataGrid,
                                            EventHandler actionAdd,
                                            EventHandler actionEdit,
                                            EventHandler actionDelete)
    {
        var h = dataGrid.HitTest(e.X, e.Y);
        if (e.Button == MouseButtons.Right)
        {
            PopupMenu.Items.Add("Добавить", AutoSalon.Properties.Resources.Add_16x16, actionAdd);
        }

        if (e.Button == MouseButtons.Right && h.Type == DataGridViewHitTestType.Cell)
        {
            dataGrid.Rows[h.RowIndex].Selected = true;
            PopupMenu.Items.Add("Изменить", AutoSalon.Properties.Resources.Edit_16x16, actionEdit);
            PopupMenu.Items.Add("Удалить", AutoSalon.Properties.Resources.Delete_16x16, actionDelete);
        }
        PopupMenu.Show(dataGrid, (System.Drawing.Point)e.Location);
    }
}
