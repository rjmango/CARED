using CARED.Data;
using CARED.Models;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CARED.Services
{
    public static class CreateExcelService
    {
        public static void GenerateChargeSlips(int targetYear, int targetMonth, string defaultFileName)
        {
            // 1. ASK USER WHERE TO SAVE
            string finalFilePath = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Save Charge Slips";
                sfd.FileName = defaultFileName;
                if (sfd.ShowDialog() != DialogResult.OK) return;
                finalFilePath = sfd.FileName;
            }

            // 2. GENERATE EXCEL
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Charge Slips");
                ws.Style.Font.FontName = "Arial";
                ws.Style.Font.FontSize = 11;

                // PAGINATION CONFIGURATION
                const int MAX_ROWS_PER_PAGE = 70;
                int rowsUsedOnCurrentPage = 0;

                using (var context = new AppDatabaseContext())
                {
                    var entries = context.Transactions
                        .Where(t => t.Date.Year == targetYear && t.Date.Month == targetMonth)
                        .Include(t => t.TransactedProcedures)
                            .ThenInclude(tp => tp.Procedure)
                        .OrderBy(t => t.Date)
                        .ToList();

                    if (entries.Any())
                    {
                        int currentRow = 1;

                        // MAIN LOOP: Process in pairs (Left & Right)
                        for (int i = 0; i < entries.Count; i += 2)
                        {
                            // A. PREPARE DATA
                            var leftTrans = entries[i];
                            var rightTrans = (i + 1 < entries.Count) ? entries[i + 1] : null;

                            int countLeft = leftTrans.TransactedProcedures.Count;
                            int countRight = (rightTrans != null) ? rightTrans.TransactedProcedures.Count : 0;

                            int maxItemsInPair = Math.Max(countLeft, countRight);
                            int slipHeight = 13 + maxItemsInPair;

                            // B. CHECK FOR "HUGE SLIP" OR PAGE OVERFLOW
                            bool isHugeSlip = slipHeight > MAX_ROWS_PER_PAGE;

                            if (isHugeSlip)
                            {
                                if (rowsUsedOnCurrentPage > 0)
                                {
                                    ws.PageSetup.AddHorizontalPageBreak(currentRow - 1);
                                    rowsUsedOnCurrentPage = 0;
                                }

                                int endRow = PrintPair(ws, leftTrans, rightTrans, currentRow, maxItemsInPair);
                                ws.PageSetup.AddHorizontalPageBreak(endRow);

                                currentRow = endRow + 1;
                                rowsUsedOnCurrentPage = 0;
                            }
                            else
                            {
                                if (rowsUsedOnCurrentPage + slipHeight > MAX_ROWS_PER_PAGE)
                                {
                                    ws.PageSetup.AddHorizontalPageBreak(currentRow - 1);
                                    rowsUsedOnCurrentPage = 0;
                                }

                                int endRow = PrintPair(ws, leftTrans, rightTrans, currentRow, maxItemsInPair);

                                currentRow = endRow + 3;
                                rowsUsedOnCurrentPage += (slipHeight + 3);
                            }
                        }

                        ws.Columns().AdjustToContents();
                        ws.PageSetup.Margins.Top = 0.5;
                        ws.PageSetup.Margins.Bottom = 0.5;
                    }
                    else
                    {
                        ws.Cell("A1").Value = "No entries found.";
                    }
                }

                // 3. SAVE AND OPEN
                try
                {
                    workbook.SaveAs(finalFilePath);
                    Process.Start(new ProcessStartInfo(finalFilePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File saved, but could not open automatically.\n{ex.Message}");
                }
            }
        }

        // --- HELPER 1: Manages the Pair Printing ---
        private static int PrintPair(IXLWorksheet ws, Transaction left, Transaction right, int startRow, int maxItems)
        {
            // Print Left
            int leftEnd = PrintSingleSlip(ws, left, startRow, "A", "B", maxItems);

            // Print Right (if exists)
            int rightEnd = startRow;
            if (right != null)
            {
                rightEnd = PrintSingleSlip(ws, right, startRow, "D", "E", maxItems);
            }

            return Math.Max(leftEnd, rightEnd);
        }

        // --- HELPER 2: Prints the actual content (UPDATED FOR FORMULAS) ---
        private static int PrintSingleSlip(IXLWorksheet ws, Transaction t, int startRow, string c1, string c2, int targetItemCount)
        {
            int r = startRow;

            // HEADER
            ws.Cell($"{c1}{r}").Value = "CARED AND CURE HUB";
            ws.Cell($"{c1}{r}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range($"{c1}{r}:{c2}{r}").Merge();

            ws.Cell($"{c1}{r + 1}").Value = "Basement 2, Ayala Center Cebu. Cell # 09276771451";
            ws.Cell($"{c1}{r + 1}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range($"{c1}{r + 1}:{c2}{r + 1}").Merge();

            ws.Cell($"{c1}{r + 3}").Value = "CHARGE SLIP";
            ws.Cell($"{c1}{r + 3}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range($"{c1}{r + 3}:{c2}{r + 3}").Merge();

            // INFO
            ws.Cell($"{c1}{r + 5}").Value = $"CS No: {t.CsNo}      DATE: {t.Date:MM/dd/yyyy}";
            ws.Cell($"{c1}{r + 6}").Value = t.Name;
            ws.Cell($"{c1}{r + 7}").Value = t.Personnel;
            ws.Cell($"{c1}{r + 8}").Value = t.Company;

            // COLUMNS
            ws.Cell($"{c1}{r + 10}").Value = "LABORATORY REQUEST";
            ws.Cell($"{c1}{r + 10}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell($"{c2}{r + 10}").Value = "AMOUNT";
            ws.Cell($"{c2}{r + 10}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            r += 11; // Items start here

            // TRACKING START ROW FOR FORMULA
            int itemStartRow = r;

            // ITEMS
            int itemsPrinted = 0;
            foreach (var item in t.TransactedProcedures)
            {
                ws.Cell($"{c1}{r}").Value = item.Procedure.ProcedureName;
                ws.Cell($"{c1}{r}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"{c2}{r}").Value = item.Procedure.Amount;
                ws.Cell($"{c2}{r}").Style.NumberFormat.Format = "#,##0.00";
                ws.Cell($"{c2}{r}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                r++;
                itemsPrinted++;
            }

            // PADDING (Vital for alignment)
            r += (targetItemCount - itemsPrinted);

            // Determine the last row of data (including padding)
            int itemEndRow = r - 1;

            // FOOTER
            r++; // Move to Total Row
            ws.Cell($"{c1}{r}").Value = "TOTAL";
            ws.Cell($"{c1}{r}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            // *** FORMULA CHANGE ***
            // Instead of putting the 'sum' variable, we put a SUM formula.
            // We include the full range (itemStartRow to itemEndRow) so if user adds text in padding, it calculates.
            ws.Cell($"{c2}{r}").FormulaA1 = $"=SUM({c2}{itemStartRow}:{c2}{itemEndRow})";

            ws.Cell($"{c2}{r}").Style.NumberFormat.Format = "#,##0.00";
            ws.Cell($"{c2}{r}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell($"{c2}{r}").Style.Font.Bold = true;
            ws.Cell($"{c2}{r}").Style.Border.TopBorder = XLBorderStyleValues.Thin;

            return r;
        }

        public static void GenerateBillingStatement(int targetYear, int targetMonth, string bsName, string hmo, string defaultFileName)
        {
            // 1. ASK USER WHERE TO SAVE
            string finalFilePath = "";

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Save Billing Statement";
                sfd.FileName = defaultFileName;
                if (sfd.ShowDialog() != DialogResult.OK) return;
                finalFilePath = sfd.FileName;
            }

            // 2. GENERATE THE EXCEL FILE
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Billing Statement");

                // --- GLOBAL STYLE SETTINGS ---
                ws.Style.Font.FontName = "Arial";
                ws.Style.Font.FontSize = 12;

                // --- HEADER SECTION ---
                ws.Cell("A1").Value = "CARED AND CURE HUB INC";
                ws.Cell("A1").Style.Font.Bold = true;
                ws.Cell("A2").Value = "Basement 2, Ayala Center Cebu Cell # 0927-677-1451";

                using (var context = new AppDatabaseContext())
                {
                    var entriesInAMonth = context.Transactions
                        .Where(t => t.Date.Year == targetYear && t.Date.Month == targetMonth)
                        .Include(t => t.TransactedProcedures)
                            .ThenInclude(tp => tp.Procedure)
                        .OrderBy(t => t.Date)
                        .ToList();

                    if (entriesInAMonth.Any())
                    {
                        ws.Cell("A4").Value = "BILLING STATEMENT: " + bsName;
                        ws.Cell("A4").Style.Font.Bold = true;

                        ws.Cell("A5").Value = $"DATE: {DateTime.Now:MMMM dd, yyyy}";
                        ws.Cell("A5").Style.Font.Bold = true;

                        string monthName = new DateTime(targetYear, targetMonth, 1).ToString("MMM").ToUpper();
                        int lastDay = DateTime.DaysInMonth(targetYear, targetMonth);

                        ws.Cell("A7").Value = $"DATE COVERED: {monthName} 1-{lastDay}, {targetYear}";
                        ws.Cell("A7").Style.Font.Bold = true;

                        ws.Cell("A9").Value = "TO: CLAIMS DEPARTMENT";
                        ws.Cell("A9").Style.Font.Bold = true;
                        ws.Cell("A10").Value = hmo;
                        ws.Cell("A10").Style.Font.Bold = true;

                        ws.Cell("A12").Value = "Re: Please find below the list of laboratory services done.";
                        ws.Range("A1:F1").Merge();
                        ws.Range("A2:F2").Merge();
                        ws.Range("A4:F4").Merge();
                        ws.Range("A5:F5").Merge();
                        ws.Range("A7:F7").Merge();
                        ws.Range("A9:F9").Merge();
                        ws.Range("A10:F10").Merge();
                        ws.Range("A12:F12").Merge();

                        // --- TABLE HEADERS ---
                        ws.Cell("A14").Value = "DATE";
                        ws.Cell("B14").Value = "CS #";
                        ws.Cell("C14").Value = "NAME";
                        ws.Cell("D14").Value = "PROCEDURE";
                        ws.Cell("E14").Value = "AMOUNT";
                        ws.Cell("F14").Value = "TOTAL";
                        ws.Cell("F14").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                        ws.Range("A14:F14").Style.Font.Bold = true;

                        int row = 15;

                        // Keep track of where data starts for the Grand Total formula
                        int dataStartRow = 15;

                        foreach (var transaction in entriesInAMonth)
                        {
                            ws.Cell($"A{row}").Value = transaction.Date;
                            ws.Cell($"A{row}").Style.DateFormat.Format = "MM/dd/yyyy";

                            if (transaction.TransactedProcedures != null)
                            {
                                ws.Cell($"B{row}").Value = transaction.CsNo;
                                ws.Cell($"C{row}").Value = transaction.Name;

                                // Track start row for this specific transaction's sum
                                int procStartRow = row;

                                foreach (var transactedItem in transaction.TransactedProcedures)
                                {
                                    ws.Cell($"D{row}").Value = transactedItem.Procedure.ProcedureName;

                                    ws.Cell($"E{row}").Value = transactedItem.Procedure.Amount;
                                    ws.Cell($"E{row}").Style.NumberFormat.Format = "#,##0.00";

                                    row++;
                                }

                                int procEndRow = row - 1;

                                // Step back to align Total (same as your original logic)
                                row--;

                                // *** FORMULA CHANGE 1: PER PATIENT TOTAL ***
                                // Formula: SUM(E_start : E_end)
                                ws.Cell($"F{row}").FormulaA1 = $"=SUM(E{procStartRow}:E{procEndRow})";
                                ws.Cell($"F{row}").Style.NumberFormat.Format = "#,##0.00";

                                ws.Cell($"G{row}").Value = transaction.Personnel;
                                ws.Cell($"H{row}").Value = transaction.Company;

                                row++;
                            }
                        }

                        // --- SUMMARY SECTION ---
                        int lastDataRow = row - 1;

                        ws.Cell($"C{row + 1}").Value = "TOTAL AMOUNT BILLED";
                        ws.Cell($"C{row + 1}").Style.Font.Bold = true;

                        // *** FORMULA CHANGE 2: GRAND TOTAL ***
                        // Sum the 'Total' column (F). Empty cells are ignored by Excel SUM, 
                        // so we can sum the whole range from 15 to end.
                        ws.Cell($"F{row + 1}").FormulaA1 = $"=SUM(F{dataStartRow}:F{lastDataRow})";
                        ws.Cell($"F{row + 1}").Style.NumberFormat.Format = "#,##0.00";
                        ws.Cell($"F{row + 1}").Style.Font.Bold = true;

                        // *** FORMULA CHANGE 3: TAX ***
                        // Tax = (Grand Total Cell) * 0.02
                        // Grand Total is at F{row + 1}
                        ws.Cell($"C{row + 2}").Value = "LESS 2% WITHHELD TAX";
                        ws.Cell($"F{row + 2}").FormulaA1 = $"=F{row + 1}*0.02";
                        ws.Cell($"F{row + 2}").Style.NumberFormat.Format = "#,##0.00";

                        // *** FORMULA CHANGE 4: NET TOTAL ***
                        // Net = (Grand Total) - (Tax)
                        ws.Cell($"C{row + 3}").Value = "TOTAL";
                        ws.Cell($"C{row + 3}").Style.Font.Bold = true;

                        ws.Cell($"F{row + 3}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        ws.Cell($"F{row + 3}").FormulaA1 = $"=F{row + 1}-F{row + 2}";
                        ws.Cell($"F{row + 3}").Style.NumberFormat.Format = "#,##0.00";
                        ws.Cell($"F{row + 3}").Style.Font.Bold = true;

                        // Signatories
                        ws.Cell($"C{row + 5}").Value = "PREPARED BY:";
                        ws.Cell($"F{row + 5}").Value = "NOTED BY:";

                        ws.Cell($"C{row + 6}").Value = "MA. GERALDINE P. TONGCO";
                        ws.Cell($"F{row + 6}").Value = "DR PEDRO BENEDICT GO";
                        ws.Cell($"C{row + 6}").Style.Font.Bold = true;
                        ws.Cell($"F{row + 6}").Style.Font.Bold = true;

                        ws.Cell($"C{row + 7}").Value = "BILLING IN-CHARGE";
                        ws.Cell($"F{row + 7}").Value = "FINANCE OFFICER";

                        ws.Column("A").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                        ws.Columns().AdjustToContents();
                    }
                    else
                    {
                        ws.Cell("A4").Value = "No entries found for this month.";
                    }
                }

                // 3. SAVE FILE
                workbook.SaveAs(finalFilePath);
            }

            // 4. OPEN THE SAVED FILE
            try
            {
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(finalFilePath) { UseShellExecute = true };
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File saved successfully at:\n{finalFilePath}\n\nHowever, we couldn't open it automatically.", "Success");
            }
        }
    }
}