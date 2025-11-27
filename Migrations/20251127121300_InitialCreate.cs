using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CARED.Migrations
{
    public partial class InitialCreate : Migration
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
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
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
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
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
