using System.Windows.Forms;

public static partial class clsExtensions
{
    /// <summary>
    //// Проверка содержит ли родительская форма MDI дочернюю форму 
    /// </summary>
    /// <param name="MDIParent">Родительская форма</param>
    /// <param name="MDIChild">Дочерняя форма</param>
    /// <returns></returns>
    static public bool ASMdiConstrain(this Form MDIParent, Form MDIChild)
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
    static public void ASMdiChildFocus(this Form MDIParent, Form MDIChild)
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
