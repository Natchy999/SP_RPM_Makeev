using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace lb3_33333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application excelApp = new Application();

            if (excelApp == null)
            {
                Console.WriteLine("Привет экселя не существует мы вырубаем программу");
                return;
            }

            Workbook excelBook = excelApp.Workbooks.Open(@"C:\Users\Acid\Documents\GitHub\SP_RPM\LB_3\Tablica999.xlsx"); //полный путь
            for (int shts = 1; shts <= excelBook.Sheets.Count; shts++)
            {
                _Worksheet excelSheet = excelBook.Sheets[shts];
                Range excelRange = excelSheet.UsedRange;

                int rows = excelRange.Rows.Count;
                int cols = excelRange.Columns.Count;

                for (int i = 1; i <= rows; i++)
                {
                    Console.WriteLine("\r\n");
                    for (int j = 1; j <= cols; j++)
                    {
                        if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            Console.Write(excelRange.Cells[i, j].Value2.ToString() + "\t");
                    }
                }
                Console.WriteLine("\n\n");
            }
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            //Console.ReadLine();
        }
    }
}
