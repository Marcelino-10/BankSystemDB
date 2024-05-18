using System.Data.SqlClient;

namespace BankSystem
{
    internal static class Program
    {
        public static bool isAdmin = false;
        public static bool isEmployee = false;
        public static bool isCustomer = false;
        public static string adminID;
        public static string employeeID;
        public static string customerID;
        public static Form1 obj;
        public static mainPage main;
        public static SqlConnection con;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            obj = new Form1();
            Application.Run(obj);
            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            con = new SqlConnection(connectionString);
        }
    }
}