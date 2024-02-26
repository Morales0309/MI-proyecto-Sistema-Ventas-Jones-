// ExcelService.cs
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

public class ExcelService
{
    public void ExportToExcel<T>(IEnumerable<T> data, string fileName)
    {
        using (var package = new ExcelPackage())
        {
            var workSheet = package.Workbook.Worksheets.Add("Sheet1");

            // Aquí puedes agregar el código para generar las filas y columnas basado en tus datos MudBlazor
            // Por ejemplo, puedes usar un bucle para recorrer las filas y columnas de tu tabla MudBlazor.

            // Luego, puedes guardar el archivo Excel
            File.WriteAllBytes(fileName, package.GetAsByteArray());
        }
    }
}
