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

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 1, 182.00m, "LABORATORY TESTS", "URINALYSIS", "I. CLINICAL MICROSCOPY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 2, 182.00m, "LABORATORY TESTS", "STOOL", "I. CLINICAL MICROSCOPY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 3, 275.00m, "LABORATORY TESTS", "FECAL OCCULT BLOOD", "I. CLINICAL MICROSCOPY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 4, 385.00m, "LABORATORY TESTS", "PT (SERUM)", "II. SEROLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 5, 242.00m, "LABORATORY TESTS", "BLOOD TYPING", "II. SEROLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 6, 440.00m, "LABORATORY TESTS", "VDRL", "II. SEROLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 7, 440.00m, "LABORATORY TESTS", "HBsAg", "II. SEROLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 8, 440.00m, "LABORATORY TESTS", "Anti- HBs", "II. SEROLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 9, 2024.00m, "LABORATORY TESTS", "NS1, IgM/IgG", "II. SEROLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 10, 770.00m, "LABORATORY TESTS", "HIV SCREENING", "II. SEROLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 11, 300.00m, "LABORATORY TESTS", "CBC", "III. HEMATOLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 12, 193.00m, "LABORATORY TESTS", "CLOTTING TIME", "III. HEMATOLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 13, 193.00m, "LABORATORY TESTS", "BLEEDING TIME", "III. HEMATOLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 14, 220.00m, "LABORATORY TESTS", "ESR", "III. HEMATOLOGY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 15, 825.00m, "LABORATORY TESTS", "LIPID PANEL with FBS", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 16, 330.00m, "LABORATORY TESTS", "GLUCOSE/FBS/RBS", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 17, 363.00m, "LABORATORY TESTS", "CHOLESTEROL", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 18, 385.00m, "LABORATORY TESTS", "TRIGLYCERIDES", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 19, 385.00m, "LABORATORY TESTS", "HDL", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 20, 330.00m, "LABORATORY TESTS", "CREATININE", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 21, 303.00m, "LABORATORY TESTS", "BUA", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 22, 303.00m, "LABORATORY TESTS", "BUN", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 23, 303.00m, "LABORATORY TESTS", "SGPT", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 24, 303.00m, "LABORATORY TESTS", "SGOT", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 25, 352.00m, "LABORATORY TESTS", "ALKALINE PHOSPHATASE", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 26, 770.00m, "LABORATORY TESTS", "HbA1C", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 27, 770.00m, "LABORATORY TESTS", "OGTT 75g 2HRS", "IV. BLOOD CHEMISTRY" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 28, 640.00m, "IMAGING SERVICES", "SKULL AP AND LATERAL", "I. HEAD" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 29, 790.00m, "IMAGING SERVICES", "PARANASAL SINUS (CALDWELL @ WATERS)", "I. HEAD" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 30, 440.00m, "IMAGING SERVICES", "SHOULDER AP", "II. UPPER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 31, 640.00m, "IMAGING SERVICES", "FOREARMS AP LATERAL", "II. UPPER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 32, 640.00m, "IMAGING SERVICES", "ELBOW AP LATERAL", "II. UPPER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 33, 640.00m, "IMAGING SERVICES", "WRIST AP LATERAL", "II. UPPER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 34, 790.00m, "IMAGING SERVICES", "HAND PA OBLIQUE and LATERAL", "II. UPPER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 35, 640.00m, "IMAGING SERVICES", "HUMERUS APL", "II. UPPER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 36, 640.00m, "IMAGING SERVICES", "LEG (TIBIA FIBULA) AP LATERAL", "III. LOWER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 37, 640.00m, "IMAGING SERVICES", "KNEE AP AND LATERAL", "III. LOWER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 38, 640.00m, "IMAGING SERVICES", "ANKLE AP OBLIQUE and LATERAL", "III. LOWER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 39, 640.00m, "IMAGING SERVICES", "FOOT AP, OBLIQUE and LATERAL", "III. LOWER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 40, 640.00m, "IMAGING SERVICES", "FOOT LATERAL", "III. LOWER EXTREMITIES" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 41, 790.00m, "IMAGING SERVICES", "CERVICAL SPINE APL", "IV. VERTEBRAL COLUMN" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 42, 790.00m, "IMAGING SERVICES", "CERVICAL SPINE (open mouth) APL", "IV. VERTEBRAL COLUMN" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 43, 790.00m, "IMAGING SERVICES", "LUMBOSACRAL", "IV. VERTEBRAL COLUMN" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 44, 790.00m, "IMAGING SERVICES", "THORACIC SPINE", "IV. VERTEBRAL COLUMN" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 45, 790.00m, "IMAGING SERVICES", "PELVIC XRAY", "IV. VERTEBRAL COLUMN" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 46, 340.00m, "IMAGING SERVICES", "CHEST PA", "V. THORACIC" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 47, 640.00m, "IMAGING SERVICES", "CHEST PAL", "V. THORACIC" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 48, 340.00m, "IMAGING SERVICES", "CHEST AP(Pedia)", "V. THORACIC" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 49, 640.00m, "IMAGING SERVICES", "CHEST APL (Pedia)", "V. THORACIC" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 50, 340.00m, "IMAGING SERVICES", "CHEST LATERAL", "V. THORACIC" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 51, 340.00m, "IMAGING SERVICES", "CHEST APICOLORDOTIC", "V. THORACIC" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 52, 506.00m, "IMAGING SERVICES", "ECG 12L WITH RS", "VI. OTHERS" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 53, 1650.00m, "ULTRASOUND SERVICES", "WHOLE ABDOMEN", "I. GENERAL" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 54, 1100.00m, "ULTRASOUND SERVICES", "UPPER ABDOMEN", "I. GENERAL" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 55, 990.00m, "ULTRASOUND SERVICES", "LOWER ABDOMEN", "I. GENERAL" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 56, 990.00m, "ULTRASOUND SERVICES", "KUB", "I. GENERAL" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 57, 1155.00m, "ULTRASOUND SERVICES", "KUB + PROSTATE", "I. GENERAL" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 58, 1100.00m, "ULTRASOUND SERVICES", "HBT", "I. GENERAL" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 59, 1000.00m, "ULTRASOUND SERVICES", "TRANSVAGINAL", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 60, 1000.00m, "ULTRASOUND SERVICES", "PREGNANT PELVIS/TRANS AB UTZ", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 61, 1500.00m, "ULTRASOUND SERVICES", "PELVIC UTZ W/ CERVICAL LENGTH", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 62, 1200.00m, "ULTRASOUND SERVICES", "BIOPHYSICAL PROFILE", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 63, 2000.00m, "ULTRASOUND SERVICES", "DOPPLER VELOCIMETRY", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 64, 2000.00m, "ULTRASOUND SERVICES", "CONGENITAL ANOMALY SCAN", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 65, 2500.00m, "ULTRASOUND SERVICES", "CAS W/ CERVICAL LENGTH", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 66, 1000.00m, "ULTRASOUND SERVICES", "4D UTZ PIC ALONE", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 67, 2100.00m, "ULTRASOUND SERVICES", "W/ BIOMETRY", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 68, 2900.00m, "ULTRASOUND SERVICES", "WITH BIOMETRY CD AND PIC", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 69, 1300.00m, "ULTRASOUND SERVICES", "1ST TRINUCHAL SCREEN", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 70, 1200.00m, "ULTRASOUND SERVICES", "TRANSRECTAL", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 71, 1000.00m, "ULTRASOUND SERVICES", "NON PREGNANT PELVIS", "II. OB ULTRASOUND" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 72, 5300.00m, "ULTRASOUND SERVICES", "POST BRONCHIAL SPIROMETRY", "III. OTHERS" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 73, 3900.00m, "ULTRASOUND SERVICES", "24H ABPM", "III. OTHERS" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 74, 4400.00m, "ULTRASOUND SERVICES", "24H HOLTER MONITORING", "III. OTHERS" });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureID", "Amount", "Group", "ProcedureName", "SubGroup" },
                values: new object[] { 75, 3300.00m, "ULTRASOUND SERVICES", "ABI", "III. OTHERS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "ProcedureID",
                keyValue: 75);

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
