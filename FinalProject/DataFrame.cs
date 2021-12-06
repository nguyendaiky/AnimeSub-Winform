using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace FinalProject
{
    class DataFrame
    {
        //Read datatable
        public static DataTable ReadExcel()
        {
            string url = Application.StartupPath + "\\Data.xlsx";

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            //if (excelApp == null)
            //{
            //    Console.WriteLine("Excel is not installed!!");
            //    return;
            //}

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            //Set DataTable Name and Columns Name
            myTable = new DataTable("MyDataTable");
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("NameSort", typeof(string));
            myTable.Columns.Add("NameOther", typeof(string));
            myTable.Columns.Add("NumEp", typeof(int));
            myTable.Columns.Add("NumMovie", typeof(int));
            myTable.Columns.Add("View", typeof(int));
            myTable.Columns.Add("Type", typeof(string));
            myTable.Columns.Add("Studio", typeof(string));
            myTable.Columns.Add("Season", typeof(string));
            myTable.Columns.Add("Director", typeof(string));

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 1].Value2); //string
                    myNewRow["NameSort"] = Convert.ToString(excelRange.Cells[i, 2].Value2); //string
                    myNewRow["NameOther"] = Convert.ToString(excelRange.Cells[i, 3].Value2);
                    myNewRow["NumEp"] = Convert.ToInt32(excelRange.Cells[i, 4].Value2); //int
                    myNewRow["NumMovie"] = Convert.ToInt32(excelRange.Cells[i, 5].Value2); //int
                    myNewRow["View"] = Convert.ToInt32(excelRange.Cells[i, 6].Value2); //int
                    myNewRow["Type"] = Convert.ToString(excelRange.Cells[i, 7].Value2); //
                    myNewRow["Studio"] = Convert.ToString(excelRange.Cells[i, 8].Value2); //
                    myNewRow["Season"] = Convert.ToString(excelRange.Cells[i, 9].Value2); //
                    try
                    {
                        myNewRow["Director"] = Convert.ToInt32(excelRange.Cells[i, 10].Value2); //
                    }
                    catch { myNewRow["Director"] = ""; }

                    myTable.Rows.Add(myNewRow);
                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }
        public static DataTable DataSet = ReadExcel();


        //get list from string
        private static List<string> selectionFilterFilm(DataTable table, string nameCol)
        {
            List<string> result = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                string[] type = row[nameCol].ToString().Split(',');
                foreach (string s in type)
                {
                    if (s[0] == ' ')
                    {
                        s.Remove(0, 1);
                    }
                    if (!result.Contains(s))
                    {
                        result.Add(s);
                    }
                }
            }

            return result;
        }
        //static string[] select = { "Type", "Studio" };
        //public static List<string> Type = selectionFilterFilm(DataSet, select[0]);
        //public static List<string> Studio = selectionFilterFilm(DataSet, select[1]);

    }
}
