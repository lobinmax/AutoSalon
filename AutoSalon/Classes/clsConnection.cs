using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class clsConnection
{
    private SqlConnection conn;

    public void ConnectionDase(string server , string db, string login, string pass)
    {
        using (conn = new SqlConnection())
        {
            conn.ConnectionString = $@"Data Source={server};Initial Catalog={db};Encrypt=False;Integrated Security=False;User ID={login};Password={pass}";

            try
            {
                if (conn.State ==  System.Data.ConnectionState.Closed) {
                    conn.Open();
                }

                if (!FindDB()){
                   if ( XtraMessageBox.Show("Базы данных 'Autosalon' не найдена. Желаете создать базу данных?", 
                        AppDomain.CurrentDomain.FriendlyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        XtraMessageBox.Show("Запуск создания базы данных");
                    }
                   else
                    {
                        throw new Exception("Не найдена база данных 'Autosalon'.");
                    }

                }

            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, AppDomain.CurrentDomain.FriendlyName);
            }
        }
    }

    private bool FindDB() 
    {
        List<string> list = new List<string>();
        using (SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE name NOT IN(N'master', N'tempdb', N'model', N'msdb') AND name = 'Autosalon1'", conn))
        {
            using (IDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    list.Add(dr[0].ToString());
                }

                if (list.Any()){
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }




}
