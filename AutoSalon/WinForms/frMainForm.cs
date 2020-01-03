using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;

public partial class frMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
{

    public frMainForm()
    {
        InitializeComponent();
        clsTabActivated cls1 = new clsTabActivated(barButtonItemСотрудники, new XtraForm2(), this);
        clsTabActivated cls2 = new clsTabActivated(barButtonItemДолжности, new XtraForm3(), this/*, new Dictionary<RibbonPageCategory, bool> { { ribbonPageCategory1, true } }*/);
    }

    private void XtraForm1_Load(object sender, EventArgs e) { }

    private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e){Application.Exit();}


}


