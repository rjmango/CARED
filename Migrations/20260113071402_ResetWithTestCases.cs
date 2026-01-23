using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CARED.Migrations
{
    public partial class ResetWithTestCases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProcedureName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Group = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, defaultValue: "N/A"),
                    SubGroup = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, defaultValue: "N/A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Insurer = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CsNo = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Personnel = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Company = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "TransactedProcedures",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProcedureID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactedProcedures", x => new { x.TransactionID, x.ProcedureID });
                    table.ForeignKey(
                        name: "FK_TransactedProcedures_Procedures_ProcedureID",
                        column: x => x.ProcedureID,
                        principalTable: "Procedures",
                        principalColumn: "ProcedureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactedProcedures_Transactions_TransactionID",
                        column: x => x.TransactionID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 1, 182.00m, "LABORATORY", "URINALYSIS", "CLINICAL MICROSCOPY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 2, 300.00m, "LABORATORY", "CBC", "HEMATOLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 3, 340.00m, "IMAGING", "CHEST PA", "THORACIC" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 4, 1100.00m, "ULTRASOUND", "UPPER ABDOMEN", "GENERAL" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 5, 506.00m, "IMAGING", "ECG 12L WITH RS", "OTHERS" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 6, 106.00m, "STRESS TEST", "TEST PROCEDURE 6", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 7, 107.00m, "STRESS TEST", "TEST PROCEDURE 7", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 8, 108.00m, "STRESS TEST", "TEST PROCEDURE 8", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 9, 109.00m, "STRESS TEST", "TEST PROCEDURE 9", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 10, 110.00m, "STRESS TEST", "TEST PROCEDURE 10", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 11, 111.00m, "STRESS TEST", "TEST PROCEDURE 11", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 12, 112.00m, "STRESS TEST", "TEST PROCEDURE 12", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 13, 113.00m, "STRESS TEST", "TEST PROCEDURE 13", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 14, 114.00m, "STRESS TEST", "TEST PROCEDURE 14", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 15, 115.00m, "STRESS TEST", "TEST PROCEDURE 15", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 16, 116.00m, "STRESS TEST", "TEST PROCEDURE 16", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 17, 117.00m, "STRESS TEST", "TEST PROCEDURE 17", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 18, 118.00m, "STRESS TEST", "TEST PROCEDURE 18", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 19, 119.00m, "STRESS TEST", "TEST PROCEDURE 19", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 20, 120.00m, "STRESS TEST", "TEST PROCEDURE 20", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 21, 121.00m, "STRESS TEST", "TEST PROCEDURE 21", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 22, 122.00m, "STRESS TEST", "TEST PROCEDURE 22", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 23, 123.00m, "STRESS TEST", "TEST PROCEDURE 23", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 24, 124.00m, "STRESS TEST", "TEST PROCEDURE 24", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 25, 125.00m, "STRESS TEST", "TEST PROCEDURE 25", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 26, 126.00m, "STRESS TEST", "TEST PROCEDURE 26", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 27, 127.00m, "STRESS TEST", "TEST PROCEDURE 27", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 28, 128.00m, "STRESS TEST", "TEST PROCEDURE 28", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 29, 129.00m, "STRESS TEST", "TEST PROCEDURE 29", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 30, 130.00m, "STRESS TEST", "TEST PROCEDURE 30", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 31, 131.00m, "STRESS TEST", "TEST PROCEDURE 31", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 32, 132.00m, "STRESS TEST", "TEST PROCEDURE 32", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 33, 133.00m, "STRESS TEST", "TEST PROCEDURE 33", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 34, 134.00m, "STRESS TEST", "TEST PROCEDURE 34", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 35, 135.00m, "STRESS TEST", "TEST PROCEDURE 35", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 36, 136.00m, "STRESS TEST", "TEST PROCEDURE 36", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 37, 137.00m, "STRESS TEST", "TEST PROCEDURE 37", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 38, 138.00m, "STRESS TEST", "TEST PROCEDURE 38", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 39, 139.00m, "STRESS TEST", "TEST PROCEDURE 39", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 40, 140.00m, "STRESS TEST", "TEST PROCEDURE 40", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 41, 141.00m, "STRESS TEST", "TEST PROCEDURE 41", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 42, 142.00m, "STRESS TEST", "TEST PROCEDURE 42", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 43, 143.00m, "STRESS TEST", "TEST PROCEDURE 43", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 44, 144.00m, "STRESS TEST", "TEST PROCEDURE 44", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 45, 145.00m, "STRESS TEST", "TEST PROCEDURE 45", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 46, 146.00m, "STRESS TEST", "TEST PROCEDURE 46", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 47, 147.00m, "STRESS TEST", "TEST PROCEDURE 47", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 48, 148.00m, "STRESS TEST", "TEST PROCEDURE 48", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 49, 149.00m, "STRESS TEST", "TEST PROCEDURE 49", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 50, 150.00m, "STRESS TEST", "TEST PROCEDURE 50", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 51, 151.00m, "STRESS TEST", "TEST PROCEDURE 51", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 52, 152.00m, "STRESS TEST", "TEST PROCEDURE 52", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 53, 153.00m, "STRESS TEST", "TEST PROCEDURE 53", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 54, 154.00m, "STRESS TEST", "TEST PROCEDURE 54", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 55, 155.00m, "STRESS TEST", "TEST PROCEDURE 55", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 56, 156.00m, "STRESS TEST", "TEST PROCEDURE 56", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 57, 157.00m, "STRESS TEST", "TEST PROCEDURE 57", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 58, 158.00m, "STRESS TEST", "TEST PROCEDURE 58", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 59, 159.00m, "STRESS TEST", "TEST PROCEDURE 59", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 60, 160.00m, "STRESS TEST", "TEST PROCEDURE 60", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 61, 161.00m, "STRESS TEST", "TEST PROCEDURE 61", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 62, 162.00m, "STRESS TEST", "TEST PROCEDURE 62", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 63, 163.00m, "STRESS TEST", "TEST PROCEDURE 63", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 64, 164.00m, "STRESS TEST", "TEST PROCEDURE 64", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 65, 165.00m, "STRESS TEST", "TEST PROCEDURE 65", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 66, 166.00m, "STRESS TEST", "TEST PROCEDURE 66", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 67, 167.00m, "STRESS TEST", "TEST PROCEDURE 67", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 68, 168.00m, "STRESS TEST", "TEST PROCEDURE 68", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 69, 169.00m, "STRESS TEST", "TEST PROCEDURE 69", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 70, 170.00m, "STRESS TEST", "TEST PROCEDURE 70", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 71, 171.00m, "STRESS TEST", "TEST PROCEDURE 71", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 72, 172.00m, "STRESS TEST", "TEST PROCEDURE 72", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 73, 173.00m, "STRESS TEST", "TEST PROCEDURE 73", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 74, 174.00m, "STRESS TEST", "TEST PROCEDURE 74", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 75, 175.00m, "STRESS TEST", "TEST PROCEDURE 75", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 76, 176.00m, "STRESS TEST", "TEST PROCEDURE 76", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 77, 177.00m, "STRESS TEST", "TEST PROCEDURE 77", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 78, 178.00m, "STRESS TEST", "TEST PROCEDURE 78", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 79, 179.00m, "STRESS TEST", "TEST PROCEDURE 79", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 80, 180.00m, "STRESS TEST", "TEST PROCEDURE 80", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 81, 181.00m, "STRESS TEST", "TEST PROCEDURE 81", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 82, 182.00m, "STRESS TEST", "TEST PROCEDURE 82", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 83, 183.00m, "STRESS TEST", "TEST PROCEDURE 83", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 84, 184.00m, "STRESS TEST", "TEST PROCEDURE 84", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 85, 185.00m, "STRESS TEST", "TEST PROCEDURE 85", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 86, 186.00m, "STRESS TEST", "TEST PROCEDURE 86", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 87, 187.00m, "STRESS TEST", "TEST PROCEDURE 87", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 88, 188.00m, "STRESS TEST", "TEST PROCEDURE 88", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 89, 189.00m, "STRESS TEST", "TEST PROCEDURE 89", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 90, 190.00m, "STRESS TEST", "TEST PROCEDURE 90", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 91, 191.00m, "STRESS TEST", "TEST PROCEDURE 91", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 92, 192.00m, "STRESS TEST", "TEST PROCEDURE 92", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 93, 193.00m, "STRESS TEST", "TEST PROCEDURE 93", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 94, 194.00m, "STRESS TEST", "TEST PROCEDURE 94", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 95, 195.00m, "STRESS TEST", "TEST PROCEDURE 95", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 96, 196.00m, "STRESS TEST", "TEST PROCEDURE 96", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 97, 197.00m, "STRESS TEST", "TEST PROCEDURE 97", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 98, 198.00m, "STRESS TEST", "TEST PROCEDURE 98", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 99, 199.00m, "STRESS TEST", "TEST PROCEDURE 99", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 100, 200.00m, "STRESS TEST", "TEST PROCEDURE 100", "GENERATED" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 1, "Test Corp", "CS-1", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 2, "Test Corp", "CS-2", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 3, "Test Corp", "CS-3", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 4, "Test Corp", "CS-4", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 5, "Test Corp", "CS-5", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 6, "Test Corp", "CS-6", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 7, "Test Corp", "CS-7", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 8, "Test Corp", "CS-8", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 9, "Test Corp", "CS-9", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 10, "Test Corp", "CS-10", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "Standard Patient", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 11, "Test Corp", "CS-11", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "THE MONSTER (60 ITEMS)", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 12, "Test Corp", "CS-12", new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "TINY NEIGHBOR (1 ITEM)", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 13, "Test Corp", "CS-13", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "EDGE CASE LEFT (35 ITEMS)", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionID", "Company", "CsNo", "Date", "Insurer", "Name", "Personnel" },
                values: new object[] { 14, "Test Corp", "CS-14", new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Insurer", "EDGE CASE RIGHT (35 ITEMS)", "Dr. Test" });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 5 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 6 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 7 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 7 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 8 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 8 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 8 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 9 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 9 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 9 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 10 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 10 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 10 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 1, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 2, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 3, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 4, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 5, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 6, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 7, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 8, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 9, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 10, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 11, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 12, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 13, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 14, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 15, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 16, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 17, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 18, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 19, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 20, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 21, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 22, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 23, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 24, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 25, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 26, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 27, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 28, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 29, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 30, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 31, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 32, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 33, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 34, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 35, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 36, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 37, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 38, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 39, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 40, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 41, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 42, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 43, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 44, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 45, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 46, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 47, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 48, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 49, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 50, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 51, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 52, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 53, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 54, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 55, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 56, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 57, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 58, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 59, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 60, 11 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 5, 12 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 10, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 11, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 12, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 13, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 14, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 15, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 16, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 17, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 18, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 19, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 20, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 21, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 22, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 23, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 24, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 25, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 26, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 27, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 28, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 29, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 30, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 31, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 32, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 33, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 34, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 35, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 36, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 37, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 38, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 39, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 40, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 41, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 42, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 43, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 44, 13 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 10, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 11, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 12, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 13, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 14, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 15, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 16, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 17, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 18, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 19, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 20, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 21, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 22, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 23, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 24, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 25, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 26, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 27, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 28, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 29, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 30, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 31, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 32, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 33, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 34, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 35, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 36, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 37, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 38, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 39, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 40, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 41, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 42, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 43, 14 });

            migrationBuilder.InsertData(
                table: "TransactedProcedures",
                columns: new[] { "ProcedureID", "TransactionID" },
                values: new object[] { 44, 14 });

            migrationBuilder.CreateIndex(
                name: "IX_TransactedProcedures_ProcedureID",
                table: "TransactedProcedures",
                column: "ProcedureID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactedProcedures");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
