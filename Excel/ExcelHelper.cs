using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Library.Excel
{
    class ExcelHelper
    {
        public static void ExportToExcel<T>(List<T> data, string filePath, string sheetName = "Data")
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(sheetName);

                var properties = typeof(T).GetProperties();

                for (int i = 0; i < properties.Length; i++)
                {
                    var cell = worksheet.Cell(1, i + 1);
                    cell.Value = properties[i].Name;

                    cell.Style.Font.Bold = true;
                    cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    cell.Style.Border.OutsideBorderColor = XLColor.Black;
                    cell.Style.Font.Bold = true;
                }

                for (int row = 0; row < data.Count; row++)
                {
                    for (int col = 0; col < properties.Length; col++)
                    {
                        var cell = worksheet.Cell(row + 2, col + 1);
                        var value = properties[col].GetValue(data[row]);
                        cell.Value = value.ToString() ?? "";

                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        cell.Style.Border.OutsideBorderColor = XLColor.Black;
                    }
                }

                var range = worksheet.Range(1, 1, data.Count + 1, properties.Length);
                var table = range.CreateTable();
                table.Theme = XLTableTheme.TableStyleDark9;

                worksheet.Columns().AdjustToContents();

                workbook.SaveAs(string.Concat(filePath,".xlsx"));
            }

            MessageBox.Show($"Excel file is ready: {filePath}");
        }
    }
}
