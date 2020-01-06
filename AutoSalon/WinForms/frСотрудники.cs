using System;
public partial class frСотрудники : DevExpress.XtraEditors.XtraForm
{
    public frСотрудники() { InitializeComponent(); }

    private void frСотрудники_Load(object sender, EventArgs e)
    {
        gridControlСотрудники.DataSource = clsSql.ExecuteSP("");
    }
}
