using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class clsMisc
{
    /// <summary>
    /// Номер функции для хранимых процедур
    /// </summary>
    public enum ASSqlFunction
    {
        ViewForm = 0,
        Select = 1,
        Insert = 2,
        Update = 3,
        Delete = 4,
        Null = -1

    }
    
    public static object DBout(object obj)
    {
        if (obj == DBNull.Value)
        {
            return null;
        }
        return obj;
    }

    public static object DBin(object obj)
    {
        if (obj == null)
        {
            return DBNull.Value;
        }
        return obj;
    }

    public static bool CheckFields(params object[] controls)
    {
        if (!controls.Any()) { return true; }
        foreach (object obj in controls)
        {
            if ((obj == null) || string.IsNullOrWhiteSpace(obj.ToString()))
            {
                XtraMessageBox.Show("Не все обязательные поля заполнены!", Program .ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        return true;
    }
    
}

/// <summary>
////Тайимер для отслеживание активности на гридах
/// </summary>
public class ASTimer : Timer
{
    public static GridView _gridView;
    public static List<SimpleButton> _simpleButton;

    public ASTimer(GridView gridView, List<SimpleButton> simpleButton)
    {
        _gridView = gridView;
        _simpleButton = simpleButton;
        this.Tick += timer_Tick;
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        if (_simpleButton == null) { return; }
        foreach (SimpleButton btn in _simpleButton)
        {
            btn.Enabled = !(_gridView.FocusedRowHandle < 0);
        }
    }

}

