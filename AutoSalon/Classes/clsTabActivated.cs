using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class clsTabActivated
{
    private BarButtonItem _barButton;                               // Кнопка вызова
    private XtraForm _form;                                         // форма вызова
    private RibbonForm _ribbonform;                                 // форма контейнер
    private Dictionary<RibbonPageCategory, bool> _pageCategorys;    // коллекция доп вкладок
    private XtraTabbedMdiManager _xtraTabbedMdiManager;             // менеджер вкладок

    // конструктор
    public clsTabActivated(BarButtonItem barButton, XtraForm form, RibbonForm ribbonform, Dictionary<RibbonPageCategory, bool> PageCategorys = null)
    {
        this._barButton = barButton;
        this._form = form;
        this._ribbonform = ribbonform;
        this._pageCategorys = PageCategorys;

        _xtraTabbedMdiManager = XtraTabbedMdiManager.GetXtraTabbedMdiManager(_ribbonform);

        _barButton.ItemClick += new ItemClickEventHandler(barButtonItem_ItemClick);
        _xtraTabbedMdiManager.SelectedPageChanged += xtraTabbedMdiManager_SelectedPageChanged;
    }

    // обработчик кнопки для вызова формы
    private void barButtonItem_ItemClick(object sender, ItemClickEventArgs e)
    {       
        foreach (Form MDIchild in _ribbonform.MdiChildren)
        {
            if (MDIchild.Equals(_form))
            {
                MDIchild.MdiParent = _ribbonform;
                MDIchild.Focus();
                return;
            }
        }

        _form.MdiParent = _ribbonform;
        _form.Show();
    }

    // событие переключения вкладок
    private void xtraTabbedMdiManager_SelectedPageChanged(object sender, EventArgs e)
    {
        XtraTabbedMdiManager MdiManager = (XtraTabbedMdiManager)sender;

        foreach (Form MDIchild in _ribbonform.MdiChildren)
        {
            if (MdiManager.SelectedPage.MdiChild.Equals(_form))
            {
                if (_pageCategorys != null)
                {
                    // цикл по доп вкладкам для отображения
                    foreach (KeyValuePair<RibbonPageCategory, bool> pc in _pageCategorys)
                    {
                        foreach (RibbonPageCategory pcForm in _ribbonform.Ribbon.PageCategories)
                        {
                            if (pc.Key.Equals(pcForm))
                            {
                                pcForm.Visible = pc.Value;
                            }
                            else
                            {
                                pcForm.Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (RibbonPageCategory pcForm in _ribbonform.Ribbon.PageCategories)
                    {
                        pcForm.Visible = false;
                    }
                }
            }
        }
    }
}
