using CARED.Data;
using CARED.Services;
using CARED.UserControls;
using DocumentFormat.OpenXml.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.ServiceProcess;
using CARED.Forms;

namespace CARED
{
    internal static class Program
    {
        public static IHost? AppHost { get; private set; }

        [STAThread]
        static async Task Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // 1. Show Splash Screen immediately
            using var splash = new SplashScreen();
            splash.Show();
            Application.DoEvents(); // Force UI to paint


            AppHost = Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
                {
                    // 1. EF Core DbContext Registration
                    // Register the AppDatabaseContext with the dependency injection container.
                    services.AddDbContext<AppDatabaseContext>(options =>
                    {

                        // db location is at %LocalAppData%/CARED -- Type this in file explorer to verify
                        // 1. Get the path to the AppData folder
                        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                        // 2. Define a subfolder for your app (e.g., LocalAppData/CARED)
                        string dbFolder = Path.Combine(appDataPath, "CARED");

                        // 3. Ensure the folder exists before EF Core tries to create the DB
                        if (!Directory.Exists(dbFolder))
                        {
                            Directory.CreateDirectory(dbFolder);
                        }

                        // 4. Combine to get the full file path
                        string dbPath = Path.Combine(dbFolder, "app_database.db");

                        options.UseSqlite($"Data Source={dbPath}");
                        options.LogTo(Console.WriteLine, LogLevel.Information);
                    });
                    // 2. Service Layer Registration
                    // If you have a User Service):
                    //services.AddTransient<IUserService, UserService>();

                    // --- Registration for your core entities ---
                    services.AddTransient<IProcedureService, ProcedureService>();
                    services.AddTransient<ITransactionService, TransactionService>();
                    //services.AddSingleton<RecordCacheService>();

                    // -- - Registration for your data providers ---
                    services.AddSingleton<IProcedureProvider>(sp => 
                    {
                        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "procedures.json");
                        return new JsonProcedureProvider(path);
                    });

                    // --- 3. WINFORMS REGISTRATION ---
                    services.AddTransient<mainForm>();
                    //services.AddTransient<TestForm>();

                    // --- Registration for your user controls ---
                    services.AddTransient<ExportRecordsUserControl>();
                    services.AddTransient<NewBillingUserControl>();
                    services.AddTransient<RetrieveRecordsUserControl>();
                    //services.AddTransient<ProcedureListRowUserControl>();

                })
                .Build();

            // --- Database Migration and Initialization ---
            using (var scope = AppHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<AppDatabaseContext>();

                var procedureProvider = services.GetRequiredService<IProcedureProvider>();

                try
                {
                    await dbContext.Database.MigrateAsync();

                    if(!dbContext.Procedures.Any())
                    {
                        var initialProcedures = await procedureProvider.GetProceduresAsync();

                        if (initialProcedures.Any())
                        { 
                            await dbContext.Procedures.AddRangeAsync(initialProcedures);
                            await dbContext.SaveChangesAsync();
                        }
                    }
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