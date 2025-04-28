using System;
using System.Windows.Forms;
using HotelLibrary.DBContex;

namespace ResepsjonDesktopApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Lager AppDbContext manuelt
            var dbContext = new AppDbContext();

            // Lager ResepsjonForm manuelt og sender inn dbContext
            Application.Run(new ResepsjonForm(dbContext));
        }
    }
}
