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
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}