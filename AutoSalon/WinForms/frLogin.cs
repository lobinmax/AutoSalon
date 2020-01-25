using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

public partial class frLogin : DevExpress.XtraEditors.XtraForm
{
    public frLogin() { InitializeComponent(); }

    private void frLogin_Load(object sender, EventArgs e) { }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
        using (var d = new DevExpress.Utils.WaitDialogForm("Подключение к базе данных ...", "Пожалуйста, подождите!"))
        {
            if (clsSql.ConnectionToDase(
                            TextEdit_server.EditValue.ToString(),
                            TextEdit_db.EditValue.ToString(),
                            TextEdit_Login.EditValue.ToString(),
                            TextEdit_Pass.EditValue.ToString()))
            {
                // проверяем регистрацию в базе
                d.Caption = "Проверка регистрации ...";
                var dt = clsSql.ExecuteSP("dbo.ШтатСотрудники_SIUD", "@Логин", TextEdit_Login.EditValue.ToString()).dataTable;
                if (dt.Rows.Count == 0 && TextEdit_Login.EditValue.ToString() != "sa")
                {
                    XtraMessageBox.Show($"Подключение прошло успешно, но пользователь {TextEdit_Login.EditValue.ToString()} не зарегистрирован в базе данных! \n" +
                                        "Для продолжения необходимо создать пользователя в базе данных от имени Администратора (sa)",
                                        Program.ProductName,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                        DevExpress.Utils.DefaultBoolean.True);
                    Application.Exit();
                }

                // проверяем настройку базы
                //bool efff;
                d.Caption = "Проверка настройки базы ...";
                var sett = clsSql.ExecuteScalarFunction("dbo.ЯдроПолучитьКонстанту", "База данных настроена");
                if (!(Convert.ToBoolean(sett.result)) || sett is null)
                {
                    if (XtraMessageBox.Show("База данных требует настройки.\n" +
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
        
    }
}
