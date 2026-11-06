using Parking_System;

namespace Parking_System.Froms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        LoginForm login = new LoginForm();
        if (login.ShowDialog() == DialogResult.OK)
        {
            Application.Run(new mainForm());
        }
    }
}