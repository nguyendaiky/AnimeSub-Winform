using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ExcelApp = Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet;

namespace FinalProject
{
    class DataFrame
    {

        public static DataTable new_DataFilm()
        {
            DataTable res = new DataTable();
            res.Columns.Add("Name", typeof(string));
            res.Columns.Add("NameSort", typeof(string));
            res.Columns.Add("NameOther", typeof(string));
            res.Columns.Add("NumEp", typeof(int));
            res.Columns.Add("NumMovie", typeof(int));
            res.Columns.Add("View", typeof(int));
            res.Columns.Add("Type", typeof(string));
            res.Columns.Add("Studio", typeof(string));
            res.Columns.Add("Season", typeof(string));
            res.Columns.Add("Director", typeof(string));
            res.Columns.Add("Rating", typeof(double));
            return res;
        }
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
            myTable.Columns.Add("Rating", typeof(double));
            myTable.Columns.Add("NumRating", typeof(int));

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
                    myNewRow["Director"] = Convert.ToString(excelRange.Cells[i, 10].Value2); //
                    myNewRow["Rating"] = Convert.ToDouble(excelRange.Cells[i, 11].Value2);
                    myNewRow["NumRating"] = Convert.ToInt32(excelRange.Cells[i, 12].Value2);

                    myTable.Rows.Add(myNewRow);
                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }

        public static void WriteExcel(string path, DataTable table)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("Sheet1");


            worksheet.InsertDataTable(table,
            new InsertDataTableOptions()
            {
                ColumnHeaders = true,
                StartRow = 0
            });

            workbook.Save(path);
        }
        public static DataTable DataSet = ReadExcel();


        //get list from string
        public static List<string> getDataFromCol(DataTable table, string nameCol)
        {
            List<string> result = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                string[] type = row[nameCol].ToString().Split(',');
                foreach (string s in type)
                {
                    if (!result.Contains(s.Trim()))
                    {
                        result.Add(s.Trim());
                    }
                }
            }

            return result;
        }
        public static Tuple<List<string>, List<string>> getSplitSeaseon(DataTable table)
        {
            List<string> lstSeason = new List<string>() { "Mùa Xuân", "Mùa Hạ", "Mùa Thu", "Mùa Đông"};
            List<int> lstYearInt = new List<int>();

            foreach (DataRow row in table.Rows)
            {
                string[] lstStr = row["Season"].ToString().Split('-');

                int year = Convert.ToInt32(lstStr[1]);

                if (!lstYearInt.Contains(year))
                    lstYearInt.Add(year);
            }
            lstYearInt.Sort();
            List<string> lstYearStr = lstYearInt.ConvertAll<string>(delegate (int i) { return i.ToString(); });


            Tuple<List<string>, List<string>> result = new Tuple<List<string>, List<string>>(lstSeason, lstYearStr);
            return result;
        }

        //data history
        public static List<string> ReadHistory()
        {
            List<string> res = new List<string>();
            string path = Application.StartupPath + "\\History\\" + UserData.currentUsername + ".txt";
            if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine();
                }
            }
            string[] readfile = File.ReadAllLines(path);
            foreach (string s in readfile)
            {
                if (s != "")
                {
                    res.Add(s);
                }
            }
            return res;
        }
        public static void WriteHistory()
        {
            string path = Application.StartupPath + "\\History\\" + UserData.currentUsername + ".txt";
            using (StreamWriter sr = new StreamWriter(path))
            {
                foreach (string name in History)
                {
                    sr.WriteLine(name);
                }
            }

        }
        public static List<string> History;

        //Data my store
        public static List<string> ReadMyStore()
        {
            List<string> res = new List<string>();
            string path = Application.StartupPath + "\\MyStore\\" + UserData.currentUsername + ".txt";
            if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine();
                }
            }
            string[] readfile = File.ReadAllLines(path);
            foreach (string s in readfile)
            {
                if (s != "")
                {
                    res.Add(s);
                }
            }
            return res;
        }
        public static void WriteMyStore()
        {
            string path = Application.StartupPath + "\\MyStore\\" + UserData.currentUsername + ".txt";
            using (StreamWriter sr = new StreamWriter(path))
            {
                foreach (string name in MyStore)
                {
                    sr.WriteLine(name);
                }
            }
        }
        public static List<string> MyStore;
    }
}
