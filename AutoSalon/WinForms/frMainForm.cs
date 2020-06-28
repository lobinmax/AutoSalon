using System;
using System.Windows.Forms;

public partial class frMainForm : Form
{

    public frMainForm()
    {
        InitializeComponent();

        barStaticItemDB.Text = Program.CurrentBase;
        barStaticItemServer.Text = Program.CurrentServer;
    }

    private void XtraForm1_Load(object sender, EventArgs e) { }

    private void XtraForm1_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

    private void barButtonItemСотрудники_Click(object sender, EventArgs e)
    {
        frСотрудники frСотрудники = new frСотрудники();
        foreach(MdiTabControl.TabPage tp in tabControlMDI.TabPages)
        {
            var _form = (Form)tp.Form;
            if (_form.Name == frСотрудники.Name)
            {
                tp.Show();
                _form.Refresh();
                _form.Update();
                return;
            }
        }
        tabControlMDI.TabPages.Add(frСотрудники);
    }

    private void barButtonItemСправочники_Click(object sender, EventArgs e)
    {
        var frСправочники = new frСправочники();
        foreach (MdiTabControl.TabPage tp in tabControlMDI.TabPages)
        {
            var _form = (Form)tp.Form;
            if (_form.Name == frСправочники.Name)
            {
                tp.Show();
                _form.Refresh();
                _form.Update();
                return;
            }
        }
        tabControlMDI.TabPages.Add(frСправочники);

    }

    private void barButtonItemМаркиАвто_Click(object sender, EventArgs e)
    {
        var frМаркиАвто = new frМаркиАвто();
        foreach (MdiTabControl.TabPage tp in tabControlMDI.TabPages)
        {
            var _form = (Form)tp.Form;
            if (_form.Name == frМаркиАвто.Name)
            {
                tp.Show();
                _form.Refresh();
                _form.Update();
                return;
            }
        }
        tabControlMDI.TabPages.Add(frМаркиАвто);
    }

    private void barButtonItemАвтоВПродаже_Click(object sender, EventArgs e)
    {
        var frГаражАвто = new frГаражАвто();
        foreach (MdiTabControl.TabPage tp in tabControlMDI.TabPages)
        {
            var _form = (Form)tp.Form;
            if (_form.Name == frГаражАвто.Name)
            {
                tp.Show();
                _form.Refresh();
                _form.Update();
                return;
            }
        }
        tabControlMDI.TabPages.Add(frГаражАвто);
    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {
        var frКлиенты = new frКлиенты();
        foreach (MdiTabControl.TabPage tp in tabControlMDI.TabPages)
        {
            var _form = (Form)tp.Form;
            if (_form.Name == frКлиенты.Name)
            {
                tp.Show();
                _form.Refresh();
                _form.Update();
                return;
            }
        }
        tabControlMDI.TabPages.Add(frКлиенты);
    }
}
