using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CARED.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 1, "Globex", "CS-1001", new DateTime(2025, 12, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "PhilHealth", "Jane Smith 1", "Nurse Joy" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 2, "Soylent Corp", "CS-1002", new DateTime(2025, 12, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "Intellicare", "Alice Jones 2", "Dr. House" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 3, "Initech", "CS-1003", new DateTime(2025, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "Medicard", "Bob Brown 3", "Dr. Strange" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 4, "Umbrella Corp", "CS-1004", new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), "Etiqa", "Charlie Day 4", "Nurse Jackie" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 5, "Stark Ind", "CS-1005", new DateTime(2025, 12, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), "Maxicare", "Diana Prince 5", "Dr. Smith" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 6, "Acme Corp", "CS-1006", new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), "PhilHealth", "Evan Wright 6", "Nurse Joy" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 7, "Globex", "CS-1007", new DateTime(2025, 12, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), "Intellicare", "Fiona Gallagher 7", "Dr. House" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 8, "Soylent Corp", "CS-1008", new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), "Medicard", "John Doe 8", "Dr. Strange" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 9, "Initech", "CS-1009", new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Etiqa", "Jane Smith 9", "Nurse Jackie" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 10, "Umbrella Corp", "CS-1010", new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), "Maxicare", "Alice Jones 10", "Dr. Smith" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 11, "Stark Ind", "CS-1011", new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), "PhilHealth", "Bob Brown 11", "Nurse Joy" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 12, "Acme Corp", "CS-1012", new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), "Intellicare", "Charlie Day 12", "Dr. House" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 13, "Globex", "CS-1013", new DateTime(2025, 12, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), "Medicard", "Diana Prince 13", "Dr. Strange" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 14, "Soylent Corp", "CS-1014", new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "Etiqa", "Evan Wright 14", "Nurse Jackie" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 15, "Initech", "CS-1015", new DateTime(2025, 12, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "Maxicare", "Fiona Gallagher 15", "Dr. Smith" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 16, "Umbrella Corp", "CS-1016", new DateTime(2025, 12, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), "PhilHealth", "John Doe 16", "Nurse Joy" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 17, "Stark Ind", "CS-1017", new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), "Intellicare", "Jane Smith 17", "Dr. House" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 18, "Acme Corp", "CS-1018", new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Medicard", "Alice Jones 18", "Dr. Strange" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 19, "Globex", "CS-1019", new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Etiqa", "Bob Brown 19", "Nurse Jackie" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 20, "Soylent Corp", "CS-1020", new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "Maxicare", "Charlie Day 20", "Dr. Smith" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 21, "Initech", "CS-1021", new DateTime(2025, 12, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), "PhilHealth", "Diana Prince 21", "Nurse Joy" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 22, "Umbrella Corp", "CS-1022", new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "Intellicare", "Evan Wright 22", "Dr. House" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 23, "Stark Ind", "CS-1023", new DateTime(2025, 12, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "Medicard", "Fiona Gallagher 23", "Dr. Strange" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 24, "Acme Corp", "CS-1024", new DateTime(2025, 12, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "Etiqa", "John Doe 24", "Nurse Jackie" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 25, "Globex", "CS-1025", new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), "Maxicare", "Jane Smith 25", "Dr. Smith" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 26, "Soylent Corp", "CS-1026", new DateTime(2025, 12, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), "PhilHealth", "Alice Jones 26", "Nurse Joy" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 27, "Initech", "CS-1027", new DateTime(2025, 12, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "Intellicare", "Bob Brown 27", "Dr. House" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 28, "Umbrella Corp", "CS-1028", new DateTime(2025, 12, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), "Medicard", "Charlie Day 28", "Dr. Strange" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 29, "Stark Ind", "CS-1029", new DateTime(2025, 12, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), "Etiqa", "Diana Prince 29", "Nurse Jackie" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 30, "Acme Corp", "CS-1030", new DateTime(2025, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "Maxicare", "Evan Wright 30", "Dr. Smith" });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 8, 2 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 10, 4 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 6, 5 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 7, 6 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 12, 6 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 8, 7 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 9, 8 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 14, 8 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 10, 9 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 11, 10 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 16, 10 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 12, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 13, 12 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 18, 12 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 14, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 15, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 20, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 16, 15 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 17, 16 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 22, 16 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 18, 17 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 19, 18 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 24, 18 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 20, 19 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 21, 20 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 26, 20 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 22, 21 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 23, 22 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 28, 22 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 24, 23 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 25, 24 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 30, 24 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 26, 25 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 27, 26 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 32, 26 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 28, 27 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 29, 28 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 34, 28 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 30, 29 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 31, 30 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 36, 30 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 20, 14 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 16, 15 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 17, 16 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 22, 16 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 19, 18 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 24, 18 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 20, 19 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 21, 20 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 26, 20 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 22, 21 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 23, 22 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 28, 22 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 24, 23 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 25, 24 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 30, 24 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 26, 25 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 27, 26 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 32, 26 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 28, 27 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 29, 28 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 34, 28 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 30, 29 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 31, 30 });

            migrationBuilder.DeleteData(
                table: "TransactedProcedures",
                keyColumns: new[] { "ProcedureID", "TransactionID" },
                keyValues: new object[] { 36, 30 });

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

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "TransactionID",
                keyValue: 30);
        }
    }
}
