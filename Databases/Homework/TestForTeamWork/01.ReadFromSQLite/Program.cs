using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;


namespace _01.ReadFromSQLite
{
    class Program
    {
        static void Main()
        {
            SQLiteConnection mDbConnection = new SQLiteConnection(@"Data Source=C:\Users\Nina\Documents\GitHub\TA-Pixie\SQLite_BunniverseDB\BunniverseDB.db;Version=3;");
            mDbConnection.Open();

            string sqlCommand = "select * from Ships order by Id ";
            SQLiteCommand command = new SQLiteCommand(sqlCommand, mDbConnection);

            SQLiteDataAdapter sqLiteAdapter = new SQLiteDataAdapter(sqlCommand, mDbConnection);
            DataTable sqLiteDataTable = new DataTable();
            sqLiteAdapter.Fill(sqLiteDataTable);

            MySqlConnection mySqlConnection = new MySqlConnection("SERVER=localhost;DATABASE=mydb;UID=root;PASSWORD=kR@asin88;");
            string MySQLquery = "select * from reports";

            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(MySQLquery, mySqlConnection);
            DataTable mySqlDataTable = new DataTable();
            mySqlAdapter.Fill(mySqlDataTable);
                       

            DirectoryInfo outputDir = new DirectoryInfo(@"D:\Dropbox\Krasi\Telerik\Databases\Homework\TestForTeamWork");
            Console.WriteLine("Creating file from SQLite Database");

            FileInfo newFile = new FileInfo(outputDir.FullName + @"\reportFromSQLite.xlsx");
            if (newFile.Exists)
            {
                newFile.Delete();  // ensures we create a new workbook
                newFile = new FileInfo(outputDir.FullName + @"\reportFromSQLite.xlsx");
            }

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                // add a new worksheet to the empty workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Ships");

                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "ShipName";
                worksheet.Cells[1, 3].Value = "TotalFuelConsumed";

                using (var range = worksheet.Cells[1, 1, 1, 3])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.BlanchedAlmond);
                    range.Style.Font.Color.SetColor(Color.Black);
                }

                worksheet.Cells[2, 1].Value = mySqlDataTable.Rows[0].ItemArray[0];
                worksheet.Cells[2, 2].Value = mySqlDataTable.Rows[0].ItemArray[1];
                worksheet.Cells[2, 3].Value = (int)mySqlDataTable.Rows[0].ItemArray[2] * (int)sqLiteDataTable.Rows[0].ItemArray[2];

                worksheet.Cells[3, 1].Value = mySqlDataTable.Rows[1].ItemArray[0];
                worksheet.Cells[3, 2].Value = mySqlDataTable.Rows[1].ItemArray[1];
                worksheet.Cells[3, 3].Value = mySqlDataTable.Rows[1].ItemArray[2];

                worksheet.Cells[4, 1].Value = mySqlDataTable.Rows[2].ItemArray[0];
                worksheet.Cells[4, 2].Value = mySqlDataTable.Rows[2].ItemArray[1];
                worksheet.Cells[4, 3].Value = mySqlDataTable.Rows[2].ItemArray[2];

                worksheet.Cells[5, 1].Value = mySqlDataTable.Rows[3].ItemArray[0];
                worksheet.Cells[5, 2].Value = mySqlDataTable.Rows[3].ItemArray[1];
                worksheet.Cells[5, 3].Value = mySqlDataTable.Rows[3].ItemArray[2];

                worksheet.Cells[6, 1].Value = mySqlDataTable.Rows[4].ItemArray[0];
                worksheet.Cells[6, 2].Value = mySqlDataTable.Rows[4].ItemArray[1];
                worksheet.Cells[6, 3].Value = mySqlDataTable.Rows[4].ItemArray[2];

                //for (int i = 1; i <= mySqlDataTable.Rows.Count; i++)
                //{
                //    for (int j = 1; j <= mySqlDataTable.Columns.Count; j++)
                //    {
                //        var data = mySqlDataTable.Rows[i - 1].ItemArray[j - 1];
                //        Console.WriteLine(data);
                //        worksheet.Cells[i + 1, j].Value = data;
                //    }
                //}
                package.Save();
            }
        }



    }
}
