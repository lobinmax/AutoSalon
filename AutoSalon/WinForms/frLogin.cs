using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class frLogin : DevExpress.XtraEditors.XtraForm
{
    public frLogin() { InitializeComponent(); }

    private void frLogin_Load(object sender, EventArgs e) { }

    private void simpleButton1_Click(object sender, EventArgs e)
    {        
        if (clsSql.ConnectionToDase(
                TextEdit_server.EditValue.ToString(),
                TextEdit_db.EditValue.ToString(),
                TextEdit_Login.EditValue.ToString(),
                TextEdit_Pass.EditValue.ToString()))
        {
            // проверяем регистрацию в базе
            var dt = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", 
                                        "@Логин", 
                                        TextEdit_Login.EditValue.ToString());

            // проверяем настройку базы
            var sett = (bool)clsSql.ExecuteScalarFunction("dbo.ЯдроПолучитьКонстанту", "База данных настроена", 125, DateTime .Now );
            if (!sett)
            {
                if (XtraMessageBox.Show("База данных требует настройки.\n+" +
                                        "Желаете произвети настройку?",
                                        Program.ProductName,
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsSql.ExecuteSPNonQuery("dbo.ЯдроНастройкаБазыДанных");
                }
                else
                {
                    Application.Exit();
                }
            }

            if (dt.Rows .Count == 0)
            {
                XtraMessageBox.Show($"Подключение прошло успешно, но пользователь {TextEdit_Login.EditValue} не зарегистрирован в базе данных! \n" + 
                                    "Для продолжения необходимо создать пользователя в базе данных от имени Администратора", 
                                    Program.ProductName, 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information, 
                                    DevExpress.Utils.DefaultBoolean.True);
                Application.Exit();
            }

            frMainForm MainForm = new frMainForm();
            MainForm.Show();
            this.Hide();
        }
    }
}
