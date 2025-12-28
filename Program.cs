using CARED.Data;
using CARED.Services;
using CARED.UserControls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CARED
{
    internal static class Program
    {
        public static IHost? AppHost { get; private set; }

        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            AppHost = Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
                {
                    // 1. EF Core DbContext Registration
                    // Register the AppDatabaseContext with the dependency injection container.
                    services.AddDbContext<AppDatabaseContext>(options =>
                    {
                        // Using SQLite connection defined here
                        options.UseSqlite("Data Source=app_database.db");

                        // Inside services.AddDbContext<AppDatabaseContext>(options => { ... });
                        options.LogTo(Console.WriteLine, LogLevel.Information);
                    });

                    // 2. Service Layer Registration
                    // If you have a User model):
                    //services.AddTransient<IUserService, UserService>();

                    // --- Registration for your core entities ---
                    services.AddTransient<IProcedureService, ProcedureService>();
                    services.AddTransient<ITransactionService, TransactionService>();

                    // --- 3. WINFORMS REGISTRATION ---
                    services.AddTransient<mainForm>();
                    //services.AddTransient<TestForm>();

                    // --- Registration for your user controls ---
                    services.AddTransient<DashboardUserControl>();
                    services.AddTransient<NewBillingUserControl>();
                    services.AddTransient<RetrieveRecordsUserControl>();

                })
                .Build();

            // --- Database Migration and Initialization ---
            using (var scope = AppHost.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDatabaseContext>();
                try
                {
                    dbContext.Database.Migrate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"FATAL: Database initialization failed. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Application.Run(AppHost.Services.GetRequiredService<mainForm>());
            //Application.Run(AppHost.Services.GetRequiredService<TestForm>());
        }
    }
}