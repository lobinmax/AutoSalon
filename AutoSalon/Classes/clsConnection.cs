using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static clsMisc;

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
                        $"Password={pass};" +
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
                XtraMessageBox.Show($"{ex.Message}\nОшибка вызова: ConnectionToDase",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }

    /// <summary>
    ////Вернуть подключение
    /// </summary>
    /// <returns></returns>
    private static SqlConnection GetSqlConnection()
    {
        var conn = new SqlConnection() { ConnectionString = Program.ConnectionString };
        return conn;
    }

    /// <summary>
    /// Выполнение хранимой процедуры без возвращения данных и базы
    /// </summary>
    /// <param name="procedureName"></param>
    public static void ExecuteSPNonQuery(string procedureName)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }
    }

    /// <summary>
    /// Выполнение хранимой процедуры без параметров
    /// </summary>
    /// <param name="procedureName">Имя хранимой процедуры</param>
    /// <returns>DataTable</returns>
    public static DataTable ExecuteSP(string procedureName)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                //command.ExecuteReader();

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return null;
            }
        }
    }

    /// <summary>
    /// Выполнение хранимой процедуры с параметрами
    /// </summary>
    /// <param name="procedureName">Имя хранимой процедуры</param>
    /// <param name="parameters">Набор параметров @papmeter, значение</param>
    /// <returns>DataTable</returns>
    public static DataTable ExecuteSP(string procedureName, params object[] parameters)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.StoredProcedure;

                if ((parameters.Length % 2) != 0)
                {
                    throw new Exception("Ошибка программиста. Нехватка параметров в хранимой процедуре.");
                }
                // добавляем параметры
                for (int i = 0; i < (parameters.Length / 2); i++)
                {
                    command.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                }

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return null;
            }
        }
    }


    public static DataTable ExecuteSP(string procedureName, ASSqlFunction sqlFunction, params object[] parameters)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.StoredProcedure;

                if ((parameters.Length % 2) != 0)
                {
                    throw new Exception("Ошибка программиста. Нехватка параметров в хранимой процедуре.");
                }
                // добавляем параметры
                for (int i = 0; i < (parameters.Length / 2); i++)
                {
                    command.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
                }
                command.Parameters.AddWithValue("@Function", sqlFunction);


                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return null;
            }
        }
    }

    /// <summary>
    /// Выполнение скалярной пользовательской функции без параметров
    /// </summary>
    /// <param name="functionName"></param>
    /// <returns>object</returns>
    public static object ExecuteScalarFunction(string functionName)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(functionName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT {functionName}()";

                var result = command.ExecuteScalar();
                if (result == DBNull.Value)
                    { return null; }
                else
                    { return result; }

            }

            catch (Exception ex)
            {
                XtraMessageBox.Show($"{ex.Message}\nОшибка вызова: '{functionName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return null;
            }
        }
    }

    /// <summary>
    /// Выполнение скалярной пользовательской функции c параметрами
    /// </summary>
    /// <param name="functionName"></param>
    /// <param name="parameters">Массив значений параметров</param>
    /// <returns>object</returns>
    public static object ExecuteScalarFunction(string functionName, params object[] parameters)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(functionName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string parametersString = "";
            string spliter = "";

            for (int i = 0; i < parameters.Length; i++)
            {
                parametersString += (spliter + InOutValue.IsNumOrStringForDB(parameters[i].ToString()));
                spliter = ", ";
            }

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT {functionName}({parametersString})";

                var result = command.ExecuteScalar();
                if (result == DBNull.Value)
                    { return null; }
                else
                    { return result; }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show($"{ex.Message}\nОшибка вызова: '{functionName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return null;
            }
        }
    }

    /// <summary>
    /// Обработка значений из базы данных и перед отправки в нее
    /// </summary>
    private class InOutValue
    {
        public static object IsNumOrStringForDB(object obj)
        {
            int num;
            bool isNum = int.TryParse((string)obj, out num);

            if (isNum)
            {
                return obj;
            }
            else
            {
                return (string)$"'{obj}'";
            }
        }

    }
}

