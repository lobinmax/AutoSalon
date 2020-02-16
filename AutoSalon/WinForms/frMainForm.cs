using System;
using System.Windows.Forms;
    
public partial class frMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
{
    public frMainForm()
    {
        InitializeComponent();
        
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

   
    private void barButtonItemСправочники_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        frСправочники frДолжности = new frСправочники();
        if (this.ASMdiConstrain(frДолжности))
        {
            this.ASMdiChildFocus(frДолжности);
        }
        else
        {
            clsTabActivated frДолжностиMDI = new clsTabActivated(frДолжности, this);
        }
    }

    private void barButtonItemМаркиАвто_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        frМаркиАвто frМаркиАвто = new frМаркиАвто();
        if (this.ASMdiConstrain(frМаркиАвто))
        {
            this.ASMdiChildFocus(frМаркиАвто);
        }
        else
        {
            clsTabActivated frМаркиАвтоMDI = new clsTabActivated(frМаркиАвто, this);
        }
    }

    private void barButtonItemАвтоВПродаже_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        frГаражАвто frГаражАвто = new frГаражАвто();
        if (this.ASMdiConstrain(frГаражАвто))
        {
            this.ASMdiChildFocus(frГаражАвто);
        }
        else
        {
            clsTabActivated frМаркиАвтоMDI = new clsTabActivated(frГаражАвто, this);
        }
    }
}


