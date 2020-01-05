using System;
using System.Windows.Forms;
    
public partial class frMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
{
    public frMainForm()
    {
        InitializeComponent();
        clsTabActivated cls1 = new clsTabActivated(barButtonItemСотрудники, new frСотрудники(), this);
        clsTabActivated cls2 = new clsTabActivated(barButtonItemДолжности, new XtraForm3(), this/*, new Dictionary<RibbonPageCategory, bool> { { ribbonPageCategory1, true } }*/);
        barStaticItemDB.Caption = Program.CurrentBase;
        barStaticItemServer.Caption = Program.CurrentServer;

    }

    private void XtraForm1_Load(object sender, EventArgs e) { }

    private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

    private void timer_Tick(object sender, EventArgs e)
    {
        barStaticItemВремяТекущее.Caption = DateTime.Now.ToString();
    }
}


