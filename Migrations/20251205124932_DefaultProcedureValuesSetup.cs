using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CARED.Migrations
{
    public partial class DefaultProcedureValuesSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Procedures",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "N/A");

            migrationBuilder.AddColumn<string>(
                name: "SubGroup",
                table: "Procedures",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "N/A");

            // Seed only five procedures for development testing
            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[,]
                {
                    { 1, 182.00m, "LABORATORY TESTS", "URINALYSIS", "I. CLINICAL MICROSCOPY" },
                    { 2, 300.00m, "LABORATORY TESTS", "CBC", "III. HEMATOLOGY" },
                    { 3, 340.00m, "IMAGING SERVICES", "CHEST PA", "V. THORACIC" },
                    { 4, 1100.00m, "ULTRASOUND SERVICES", "UPPER ABDOMEN", "I. GENERAL" },
                    { 5, 506.00m, "IMAGING SERVICES", "ECG 12L WITH RS", "VI. OTHERS" }
                });

            // Seed five transactions for development
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[,]
                {
                    { 1, "Acme Corp", "CS1001", new DateTime(2025, 12, 1, 9, 30, 0), "XY Health", "Juan Dela Cruz", "Nurse Maria" },
                    { 2, "Tech Solutions", "CS1002", new DateTime(2025, 12, 2, 10, 15, 0), "PhilCare", "Anna Santos", "Dr. Reyes" },
                    { 3, "N/A", "CS1003", new DateTime(2025, 11, 28, 14, 45, 0), "Self-Pay", "Mark Tan", "Lab Tech John" },
                    { 4, "FinCorp", "CS1004", new DateTime(2025, 11, 30, 8, 0, 0), "Generali", "Liza Cruz", "Reception" },
                    { 5, "HealthPlus", "CS1005", new DateTime(2025, 12, 3, 11, 0, 0), "MediCare", "Pedro Santos", "Dr. Lim" }
                });

            // Seed the junction table with mappings between the above transactions and procedures
            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "TransactionID", "ProcedureID" },
                values: new object[,]
                {
                    { 1, 1 }, // Juan - URINALYSIS
                    { 2, 2 }, // Anna - CBC
                    { 3, 3 }, // Mark - CHEST PA
                    { 4, 4 }, // Liza - UPPER ABDOMEN
                    { 5, 5 }  // Pedro - ECG
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Delete the seeded junction rows first
            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "TransactionID", "ProcedureID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "TransactionID", "ProcedureID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "TransactionID", "ProcedureID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "TransactionID", "ProcedureID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "TransactionID", "ProcedureID" },
                keyValues: new object[] { 5, 5 });

            // Delete the seeded transactions
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 5);

            // Delete the seeded procedures
            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Group",
                table: "Procedures");

            migrationBuilder.DropColumn(
                name: "SubGroup",
                table: "Procedures");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Transactions",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");
        }
    }
}
