using CARED.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARED.Data
{
    public class AppDatabaseContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<TransactedProcedure> TransactedProcedures { get; set; }

        // We use the parameterless constructor for direct instantiation
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {
        }

        // --- IMPORTANT: This is now used for the connection ---
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite and point to the database file
            optionsBuilder.UseSqlite("Data Source=app_database.db");

            // Optional: Enable detailed query logging for debugging
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
        // --------------------------------------------------------

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- 1. Default Value Configuration (Database Level) ---

            // Set Transaction.Date to the current timestamp upon insertion
            modelBuilder.Entity<Transaction>()
                .Property(t => t.Date)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            // Set defaults for the new Procedure descriptive fields
            modelBuilder.Entity<Procedure>()
                .Property(p => p.Group)
                .HasDefaultValue("N/A");

            modelBuilder.Entity<Procedure>()
                .Property(p => p.SubGroup)
                .HasDefaultValue("N/A");

            // --- 2. Data Seeding (Static Initial Data) ---
            // This calls the external static method to insert procedure data via migration.
            modelBuilder.Entity<Procedure>().HasData(ProcedureSeedData.GetInitialProcedures());

            // Add lightweight development seed data for Transactions (5 realistic entries)
            modelBuilder.Entity<Transaction>().HasData(
                new Transaction
                {
                    TransactionID = 1,
                    Insurer = "XY Health",
                    CsNo = "CS1001",
                    Date = new DateTime(2025, 12, 01, 09, 30, 00),
                    Name = "Juan Dela Cruz",
                    Personnel = "Nurse Maria",
                    Company = "Acme Corp"
                },
                new Transaction
                {
                    TransactionID = 2,
                    Insurer = "PhilCare",
                    CsNo = "CS1002",
                    Date = new DateTime(2025, 12, 02, 10, 15, 00),
                    Name = "Anna Santos",
                    Personnel = "Dr. Reyes",
                    Company = "Tech Solutions"
                },
                new Transaction
                {
                    TransactionID = 3,
                    Insurer = "Self-Pay",
                    CsNo = "CS1003",
                    Date = new DateTime(2025, 11, 28, 14, 45, 00),
                    Name = "Mark Tan",
                    Personnel = "Lab Tech John",
                    Company = "N/A"
                },
                new Transaction
                {
                    TransactionID = 4,
                    Insurer = "Generali",
                    CsNo = "CS1004",
                    Date = new DateTime(2025, 11, 30, 08, 00, 00),
                    Name = "Liza Cruz",
                    Personnel = "Reception",
                    Company = "FinCorp"
                },
                new Transaction
                {
                    TransactionID = 5,
                    Insurer = "MediCare",
                    CsNo = "CS1005",
                    Date = new DateTime(2025, 12, 03, 11, 00, 00),
                    Name = "Pedro Santos",
                    Personnel = "Dr. Lim",
                    Company = "HealthPlus"
                }
            );

            // Seed the junction table with 5 entries mapping each transaction to one procedure (realistic scenario)
            modelBuilder.Entity<TransactedProcedure>().HasData(
                new { TransactionID = 1, ProcedureID = 1 }, // Juan - URINALYSIS
                new { TransactionID = 2, ProcedureID = 2 }, // Anna - CBC
                new { TransactionID = 3, ProcedureID = 3 }, // Mark - CHEST PA
                new { TransactionID = 4, ProcedureID = 4 }, // Liza - UPPER ABDOMEN
                new { TransactionID = 5, ProcedureID = 5 }  // Pedro - ECG
            );

            // --- 3. Relationship Configuration ---

            // A. COMPOSITE PRIMARY KEY for the junction table
            modelBuilder.Entity<TransactedProcedure>()
                .HasKey(tp => new { tp.TransactionID, tp.ProcedureID });

            // B. Relationship to Transaction (Transaction is the 'many' side of the 1:M relationship)
            modelBuilder.Entity<TransactedProcedure>()
                .HasOne(tp => tp.Transaction)
                .WithMany(t => t.TransactedProcedures) // Uses the collection on Transaction model
                .HasForeignKey(tp => tp.TransactionID);

            // C. Relationship to Procedure (Procedure is the 'one' side of the 1:M relationship)
            // Use WithMany() with no argument because the navigation collection was removed from Procedure.cs.
            modelBuilder.Entity<TransactedProcedure>()
                .HasOne(tp => tp.Procedure)
                .WithMany()
                .HasForeignKey(tp => tp.ProcedureID);

            base.OnModelCreating(modelBuilder);
        }
    }
}