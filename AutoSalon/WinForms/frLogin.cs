using System;
using System.Windows.Forms;

public partial class frLogin : System.Windows.Forms.Form
{
    public frLogin() { InitializeComponent(); }

    private void frLogin_Load(object sender, EventArgs e) { }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
        if (clsSql.ConnectionToDase(
                        TextEdit_server.Text.ToString(),
                        TextEdit_db.Text.ToString(),
                        TextEdit_Login.Text.ToString(),
                        TextEdit_Pass.Text.ToString()))
        {
            // проверяем регистрацию в базе
            var dt = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", "@Логин", TextEdit_Login.Text.ToString()).dataTable;
            if (dt.Rows.Count == 0 && TextEdit_Login.Text.ToString() != "sa")
            {
                MessageBox.Show($"Подключение прошло успешно, но пользователь {TextEdit_Login.Text.ToString()} не зарегистрирован в базе данных! \n" +
                                    "Для продолжения необходимо создать пользователя в базе данных от имени Администратора (sa)",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                Application.Exit();
            }

            // проверяем настройку базы
            //bool efff;
            var sett = clsSql.ExecuteScalarFunction("dbo.ЯдроПолучитьКонстанту", "База данных настроена");
            if (!(Convert.ToBoolean(sett.result)) || sett is null)
            {
                if (MessageBox.Show("База данных требует настройки.\n" +
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


            frMainForm MainForm = new frMainForm();
            MainForm.Show();
            this.Hide();
        }
    }

    private void checkEdit1_CheckedChanged(object sender, EventArgs e)
    {
        TextEdit_Pass.PasswordChar = !checkEdit1.Checked ? (char)'•' : Char.MinValue;
    }
}
