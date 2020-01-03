using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

public class clsSql
{
    private static SqlConnection conn;
    
    public static bool ConnectionDase(string server , string db, string login, string pass) 
    {
        using (conn = new SqlConnection())
        {
            conn.ConnectionString = $"Data Source={server};" +
                                    $"Initial Catalog={db};" +
                                    $"Encrypt=False;" +
                                    $"Integrated Security=False;" +
                                    $"User ID={login};" +
                                    $"Password={pass}";

            try
            {
                if (conn.State ==  System.Data.ConnectionState.Closed) {
                    conn.Open();
                    return true;
                }
                
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message,  AppDomain.CurrentDomain.FriendlyName);
                return false;
            }
            return true;
        }
    }
}
