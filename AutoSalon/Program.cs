using System;
using System.Windows.Forms;

static class Program
{
    public static string ConnectionString;
    public static string CurrentServer;
    public static string CurrentBase;
    public static string CurrentUser;
    public static string ProductName;
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ProductName = Application.ProductName;
        Application.Run(new frLogin());

    }
}
