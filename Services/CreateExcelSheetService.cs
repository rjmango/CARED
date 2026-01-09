using System.IO;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace CARED.Services
{
    public class CreateExcelSheetService
    {

        //public Task<Stream> CreateBillingStatementAsync(int year, int month)
        //{ 
        //    var workbook = new XLWorkbook();
        //    var ws = workbook.Worksheets.Add("Billing Statement");

        //    // Header row
        //    ws.Cell(1, 1).Value = "Year";
        //    ws.Cell(1, 2).Value = "Month";
        //    ws.Cell(1, 3).Value = "Description";
        //    ws.Cell(1, 4).Value = "Amount";

        //    // Example data row
        //    ws.Cell(2, 1).Value = year;
        //    ws.Cell(2, 2).Value = month;
        //    ws.Cell(2, 3).Value = "Sample procedure";
        //    ws.Cell(2, 4).Value = 123.45m;

        //    ws.Columns().AdjustToContents();

        //    var ms = new MemoryStream();
        //    workbook.SaveAs(ms);
        //    ms.Position = 0;

        //    return Task.FromResult<Stream>(ms);

        //}

        public Task<string> CreateBillingStatementFileAsync(int year, int month, string filePath)
        {
            var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Billing Statement");

            // Header row
            ws.Cell(1, 1).Value = "Year";
            ws.Cell(1, 2).Value = "Month";
            ws.Cell(1, 3).Value = "Description";
            ws.Cell(1, 4).Value = "Amount";

            // Example data row
            ws.Cell(2, 1).Value = year;
            ws.Cell(2, 2).Value = month;
            ws.Cell(2, 3).Value = "Sample procedure";
            ws.Cell(2, 4).Value = 123.45m;

            ws.Columns().AdjustToContents();

            // Ensure target directory exists
            var dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Save directly to path (will overwrite if exists)
            workbook.SaveAs(filePath);

            return Task.FromResult(filePath);
        }

    }
}
