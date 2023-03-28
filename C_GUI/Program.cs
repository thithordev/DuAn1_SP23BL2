using C_GUI.Views;

namespace C_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new FrmThongKe());
=======
            Application.Run(new FrmKhung());
>>>>>>> 9b09089a24e190499a4128a876e148eb45b6a4a1
        }
    }
}