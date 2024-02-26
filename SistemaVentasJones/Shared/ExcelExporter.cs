using System.Collections.Generic;
using OfficeOpenXml;

public class ExcelExporter
{
    public static byte[] ExportToExcel<T>(List<T> data)
    {
        using (var package = new ExcelPackage())
        {
            var workSheet = package.Workbook.Worksheets.Add("Sheet1");
            workSheet.Cells.LoadFromCollection(data, true);

            return package.GetAsByteArray();
        }
    }
}
