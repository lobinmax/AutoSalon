using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class frLogin : DevExpress.XtraEditors.XtraForm
{
    public frLogin() { InitializeComponent(); }

    private void frLogin_Load(object sender, EventArgs e) { }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
        if (clsSql.ConnectionDase(
                TextEdit_server.EditValue.ToString(),
                TextEdit_db.EditValue.ToString(),
                TextEdit_Login.EditValue.ToString(),
                TextEdit_Pass.EditValue.ToString()))

        {
            frMainForm MainForm = new frMainForm();
            MainForm.Show();
            this.Hide();
        }
    }
}
