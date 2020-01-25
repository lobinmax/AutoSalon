using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
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
    static public void МенюДляAddEditDelete(this PopupMenuShowingEventArgs popupMenu,
                                            DXPopupMenu dXPopupMenu,
                                            EventHandler actionAdd,
                                            EventHandler actionEdit,
                                            EventHandler actionDelete)
    {
        dXPopupMenu.Items.Add(new DXMenuItem("Добавить", actionAdd, AutoSalon.Properties.Resources.Add_16x16));

        if (popupMenu.MenuType == GridMenuType.Row)
        {
            dXPopupMenu.Items.Add(new DXMenuItem("Редактировать", actionEdit, AutoSalon.Properties.Resources.Edit_16x16));
            dXPopupMenu.Items.Add(new DXMenuItem("Удалить", actionDelete, AutoSalon.Properties.Resources.Delete_16x16));
        }
        dXPopupMenu.ShowPopup((Control)popupMenu.HitInfo.View.GridControl, popupMenu.Point);
    }
}
