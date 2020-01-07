using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;

public partial class frСотрудники : DevExpress.XtraEditors.XtraForm
{
    public frСотрудники() { InitializeComponent(); }

    private void frСотрудники_Load(object sender, EventArgs e)
    {
        gridControlСотрудники.DataSource = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", clsMisc.ASSqlFunction.ViewForm);
        //gridViewСотрудники.НастроитьGridView(clsMisc.SqlFunction.)
    }

    private void gridViewСотрудники_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
    {
        if (e.MenuType == GridMenuType.Row)
        {
            DXPopupMenu menu = e.Menu as DXPopupMenu;
            menu.Items.Clear();
                menu.Items.Add(new DXMenuItem ("Item 1"));
        }
    }

    // Creates a menu item. 
    DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, Image image)
    {
        DXMenuCheckItem item = new DXMenuCheckItem(caption,
          !column.OptionsColumn.AllowMove, image, new EventHandler(OnCanMoveItemClick));
        item.Tag = new MenuColumnInfo(column);
        return item;
    }

    void OnCanMoveItemClick(object sender, EventArgs e)
    {
        DXMenuCheckItem item = sender as DXMenuCheckItem;
        MenuColumnInfo info = item.Tag as MenuColumnInfo;
        if (info == null) return;
        info.Column.OptionsColumn.AllowMove = !item.Checked;
    }

    class MenuColumnInfo
    {
        public MenuColumnInfo(GridColumn column)
        {
            this.Column = column;
        }
        public GridColumn Column;
    }
}
