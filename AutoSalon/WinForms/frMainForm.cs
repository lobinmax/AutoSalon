using System;
using System.Windows.Forms;
    
public partial class frMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
{
    public frMainForm()
    {
        InitializeComponent();
        
        //clsTabActivated cls2 = new clsTabActivated(barButtonItemДолжности, new XtraForm3(), this/*, new Dictionary<RibbonPageCategory, bool> { { ribbonPageCategory1, true } }*/);
        barStaticItemDB.Caption = Program.CurrentBase;
        barStaticItemServer.Caption = Program.CurrentServer;

    }

    private void XtraForm1_Load(object sender, EventArgs e) { }

    private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
    
    private void timer_Tick(object sender, EventArgs e) { barStaticItemВремяТекущее.Caption = DateTime.Now.ToString(); }

    private void barButtonItemСотрудники_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        frСотрудники frСотрудники = new frСотрудники();
        if (this.ASMdiConstrain(frСотрудники))
        {
            this.ASMdiChildFocus(frСотрудники);
        }
        else
        {
            clsTabActivated frСотрудникиMDI = new clsTabActivated(frСотрудники, this);
        } 
    }

    private void barButtonItemДолжности_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        frДолжности frДолжности = new frДолжности();
        if (this.ASMdiConstrain(frДолжности))
        {
            this.ASMdiChildFocus(frДолжности);
        }
        else
        {
            clsTabActivated frДолжностиMDI = new clsTabActivated(frДолжности, this);
        }
    }
}


