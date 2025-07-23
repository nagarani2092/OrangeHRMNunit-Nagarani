using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.TestSuits
{
    public class ZDemo1Test
    {
        [Test]
        public void ExeclTest()
        {
            XLWorkbook book = new XLWorkbook(@"C:\\Users\\I8566\\Downloads\DataDrivenExcel.xlsx");
            var sheet = book.Worksheet("AddEmployeeTest");
            var range = sheet.RangeUsed();
            int rowCount = range.RowCount();
            var columnCount = range.ColumnCount();

            //total number of testcases

            object[] main = new object[rowCount-1];

            for(int r=2;r<=rowCount;r++)
            {
                string[] data = new string[columnCount];
                for(int c=1;c<=5;c++)
                {
                    string celValue = range.Cell(r, c).GetString();
                    Console.WriteLine(celValue);
                    data[c-1] = celValue;

                }
                main[r - 2] = data;
            }
           
            book.Dispose();

        }
    }
}
