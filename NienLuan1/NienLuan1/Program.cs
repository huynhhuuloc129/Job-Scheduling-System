namespace NienLuan1
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
            LoginUI loginUI = new LoginUI();

            Application.Run(loginUI);
            if (loginUI.LoginSuccessful == 1) // Role admin
            {
                Application.Run(new AdminForm());
            } else if (loginUI.LoginSuccessful == 2)
            {
                UserUI userUI = new UserUI();
                userUI.username = loginUI.username;
                Application.Run(userUI);
            }
        }
    }
}