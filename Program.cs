using Microsoft.EntityFrameworkCore;
using CARED.Data;

namespace CARED
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // 1. Initialize and ensure the database exists.
            // This is crucial to create the 'app_database.db' file and all the tables 
            // defined in your AppDatabaseContext based on the models.
            try
            {
                using (var db = new AppDatabaseContext())
                {
                    // This method runs any pending migrations or creates the database if it doesn't exist.
                    db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                // In a real application, you would log this error and potentially show a 
                // user-friendly message box instead of just writing to the console.
                Console.WriteLine($"Database initialization failed: {ex.Message}");
                MessageBox.Show($"FATAL: Database initialization failed. Ensure the app has file write permissions. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally exit the application if the database is critical
                 return;
            }

            // 2. Run the main form of the application.
            // Replace 'Form1' with your actual starting form class name.
            Application.Run(new mainForm());
        }
    }
}