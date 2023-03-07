using Microsoft.Office.Interop.Excel;

class Program
{
    static void Main()
    {
        int[] X = { 3, -1, 4, -2, 7, -5, 8, -6, 2, -9 };

        var negativeElements = X.Where(x => x < 0).ToArray();

        var nonNegativeElements = X.Where(x => x >= 0).ToArray();

        var result = negativeElements.Concat(nonNegativeElements).ToArray();

        const string filePath = @"D:\result1.xlsx";
        var excel = new Microsoft.Office.Interop.Excel.Application();

        var wb = excel.Workbooks.Open(filePath);
        var ws = (Worksheet)wb.Worksheets[1];

        var cellRange = ws.Range["A1:H1"];
        cellRange.set_Value(XlRangeValueDataType.xlRangeValueDefault, result);

        wb.SaveAs(filePath);
        wb.Close();

        Console.WriteLine("Result saved to " + filePath);
    }
}
