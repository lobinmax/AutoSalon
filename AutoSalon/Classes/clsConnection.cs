using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static clsMisc;

public class clsSql
{
    public class QueryResponse
    {
        public object result;
        public List <string> errors;
        public bool? success;
        public DataTable dataTable = new DataTable();
    }

    private static SqlConnection conn;

    public static bool ConnectionToDase(string server, string db, string login, string pass)
    {
        using (conn = new SqlConnection())
        {
            conn.ConnectionString = $"Data Source={server};" +
                        $"Initial Catalog={db};" +
                        $"Encrypt=False;" +
                        $"Integrated Security=False;" +
                        $"Password={pass};" +
                        $"User ID={login}";
            Program.ConnectionString = conn.ConnectionString;
            Program.CurrentBase = db;
            Program.CurrentServer = server;
            Program.CurrentUser = login;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова: ConnectionToDase",
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
                MessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }
    }

    public static void ExecuteSPNonQuery(string procedureName, ASSqlFunction sqlFunction = ASSqlFunction.Null, params object[] parameters)
    {
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.StoredProcedure;

                if ((parameters.Length % 2) != 0)
                {
                    throw new Exception("Ошибка программиста. Нехватка параметров в хранимой процедуре.");
                }
                // добавляем параметры
                for (int i = 0; i < parameters.Length; i = i + 2)
                {
                    command.Parameters.AddWithValue((string)parameters[i], parameters[i + 1]);
                }

                if (sqlFunction != ASSqlFunction.Null)
                {
                    command.Parameters.AddWithValue("@Function", sqlFunction);
                }

                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }
    }

    /// <summary>
    /// Выполнение хранимой процедуры без параметров. Заполняет dataTable
    /// </summary>
    /// <param name="procedureName">Имя хранимой процедуры</param>
    /// <returns>DataTable</returns>
    public static QueryResponse ExecuteSP(string procedureName)
    {
        var response = new QueryResponse() { success = true };
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                //command.ExecuteReader();

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(response.dataTable);
                return response;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                response.success = false;
                // response.errors.Add(ex.StackTrace);
                return response;
            }
        }
    }

    /// <summary>
    /// Выполнение хранимой процедуры с параметрами. Заполняет dataTable
    /// </summary>
    /// <param name="procedureName">Имя хранимой процедуры</param>
    /// <param name="parameters">Набор параметров @papmeter, значение</param>
    /// <returns>DataTable</returns>
    public static QueryResponse ExecuteSP(string procedureName, params object[] parameters)
    {
        var response = new QueryResponse() { success = true };
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.StoredProcedure;

                if ((parameters.Length % 2) != 0)
                {
                    throw new Exception("Ошибка программиста. Нехватка параметров в хранимой процедуре.");
                }
                // добавляем параметры
                for (int i = 0; i < parameters.Length; i = i + 2)
                {
                    command.Parameters.AddWithValue((string)parameters[i], parameters[i + 1]);
                }

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(response.dataTable);
                return response;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                response.success = false;
                return response;
            }
        }
    }

    /// /// <summary>
    /// Выполнение хранимой процедуры с параметрами. Заполняет dataTable
    /// </summary>
    /// <param name="procedureName">Имя хранимой процедуры</param>
    /// <param name="sqlFunction">Номер функции</param>
    /// <param name="parameters">Набор параметров @papmeter, значение</param>
    /// <returns>DataTable</returns>
    public static QueryResponse ExecuteSP(string procedureName, ASSqlFunction sqlFunction = ASSqlFunction.Null, params object[] parameters)
    {
        var response = new QueryResponse() { success = true };
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(procedureName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.StoredProcedure;

                if ((parameters.Length % 2) != 0)
                {
                    throw new Exception("Ошибка программиста. Нехватка параметров в хранимой процедуре.");
                }
                // добавляем параметры
                for (int i = 0; i < parameters.Length; i = i + 2)
                {
                    command.Parameters.AddWithValue((string)parameters[i], parameters[i + 1]);
                }

                if (sqlFunction != ASSqlFunction.Null)
                {
                    command.Parameters.AddWithValue("@Function", sqlFunction);
                }

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(response.dataTable);
                return response;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова: '{procedureName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                response.success = false;
                return response;
            }
        }
    }

    /// <summary>
    /// Выполнение скалярной пользовательской функции без параметров. Заполняет result
    /// </summary>
    /// <param name="functionName"></param>
    /// <returns>object</returns>
    public static object ExecuteScalarFunction(string functionName)
    {
        var response = new QueryResponse() { success = true };
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(functionName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT {functionName}()";

                response.result = clsMisc.DBout(command.ExecuteScalar());
                return response;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова: '{functionName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                response.success = false;
                return null;
            }
        }
    }

    /// <summary>
    /// Выполнение скалярной пользовательской функции c параметрами. Заполняет result
    /// </summary>
    /// <param name="functionName"></param>
    /// <param name="parameters">Массив значений параметров</param>
    /// <returns>object</returns>
    public static QueryResponse ExecuteScalarFunction(string functionName, params object[] parameters)
    {
        var response = new QueryResponse() { success = true };
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand(functionName, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string parametersString = "";
            string spliter = "";
            var result = new object();
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

                response.result = clsMisc.DBout(command.ExecuteScalar());
                return response;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова: '{functionName}'",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                response.success = false;
                return response;
            }
        }
    }
    
    public static QueryResponse ExecuteQuery(string TextQuery)
    {
        var response = new QueryResponse() { success = true };
        using (conn = GetSqlConnection())
        {
            SqlCommand command = new SqlCommand($"{TextQuery}", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                command.CommandType = CommandType.Text;

                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(response.dataTable);
                return response;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nОшибка вызова запроса.",
                                    Program.ProductName,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                response.success = false;
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

