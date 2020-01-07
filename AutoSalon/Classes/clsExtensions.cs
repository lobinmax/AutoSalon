using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static clsMisc;

public static class clsExtensions
{
    static public void ASНастроитьGridView(this DevExpress.XtraGrid.Views.Grid.GridView gridView)
    {
        
    }

    /// <summary>
    //// Проверка содержит ли родительская форма MDI дочернюю форму 
    /// </summary>
    /// <param name="MDIParent">Родительская форма</param>
    /// <param name="MDIChild">Дочерняя форма</param>
    /// <returns></returns>
    static public bool ASMdiConstrain(this XtraForm MDIParent, XtraForm MDIChild)
    {
        foreach (Form MDIch in MDIParent.MdiChildren)
        {
            if (MDIch.Name == MDIChild.Name)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Метод переводит фокус на заданную дочернюю форму в контейнере Mdi, если она существует
    /// </summary>
    /// <param name="MDIParent">Родительская форма</param>
    /// <param name="MDIChild">Дочерняя форма</param>
    static public void ASMdiChildFocus(this XtraForm MDIParent, XtraForm MDIChild)
    {
        if (MDIParent.ASMdiConstrain(MDIChild))
        {
            foreach (Form MDIch in MDIParent.MdiChildren)
            {
                if (MDIch.Name == MDIChild.Name)
                {
                    MDIch.Focus();
                }
            }
        }
    }
}
