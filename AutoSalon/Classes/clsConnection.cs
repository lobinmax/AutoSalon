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

    public static bool ConnectionToDase(string server, string db, string login, string pass)
    {
        using (conn = new SqlConnection())
        {
            conn.ConnectionString = $"Data Source={server};" +
                        $"Initial Catalog={db};" +
                        $"Encrypt=False;" +
                        $"Integrated Security=True;" +
                        $"Initial Catalog={pass};" +
                        $"User ID={login}";
            Program.ConnectionString = conn.ConnectionString;
            Program.CurrentBase = db;
            Program.CurrentServer = server;
            Program.CurrentUser = login;

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    return true;
                }

            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, Program.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }

    private static SqlConnection GetSqlConnection()
    {
        var conn = new SqlConnection() { ConnectionString = Program.ConnectionString };
        return conn;
    }

    public static DataTable ExecuteSP(string procedureName, params string[] Parameters)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(Parameters);
                command.ExecuteReader();

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Program.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
    
}
