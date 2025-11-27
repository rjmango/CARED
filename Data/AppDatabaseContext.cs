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
        public AppDatabaseContext() : base()
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
            // --- Configuration for the Junction Table (TransactedProcedure) ---
            modelBuilder.Entity<TransactedProcedure>()
                .HasKey(tp => new { tp.TransactionID, tp.ProcedureID });

            modelBuilder.Entity<TransactedProcedure>()
                .HasOne(tp => tp.Transaction)
                .WithMany(t => t.TransactedProcedures)
                .HasForeignKey(tp => tp.TransactionID);

            modelBuilder.Entity<TransactedProcedure>()
                .HasOne(tp => tp.Procedure)
                .WithMany(p => p.TransactedProcedures)
                .HasForeignKey(tp => tp.ProcedureID);

            base.OnModelCreating(modelBuilder);
        }
    }
}