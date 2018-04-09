using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Data;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using System;

namespace NavValueCalculator
{
    class dATAeXPORTER
    {
        public void ExportToExcelWithFormat(System.Windows.Forms.DataGridView dataGridView1)
        {
            int rownum = 1;
            // intialize excel application
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            // creates a workbook
            Excel.Workbook excelbk = excelApp.Workbooks.Add(Type.Missing);
            //Add a Workseet named sheet1 to above workbook
            Excel.Worksheet xlWorkSheet1 = (Excel.Worksheet)excelbk.Worksheets["Sheet1"];

            //Add each column name of datagridview to the first row of Excel,
            //this will be the header text
            for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
            {
                Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
                xlRange.Value2 = dataGridView1.Columns[colCount].Name;
            }
            // for each row in the datagridview
            for (int rowCount = 0; rowCount < dataGridView1.Rows.Count; rowCount++)
            {
                //if the row is visible
                if (dataGridView1.Rows[rowCount].Visible == true)
                {
                    //increment the row number for excel
                    rownum = rownum + 1;
                    for (int colCount = 0; colCount < dataGridView1.Columns.Count; colCount++)
                    {
                        //create a excel range for the rownum and the columncount
                        Excel.Range xlRange = (Excel.Range)xlWorkSheet1.Cells[rownum, colCount + 1];
                        try
                        {
                            //add the gridview cell value to the cellrange
                            xlRange.Value2 =
                            dataGridView1.Rows[rowCount].Cells[colCount].Value.ToString();
                        }
                        catch (Exception)
                        {
                            try
                            {
                                xlRange.Value2 = "";
                            }
                            catch (Exception)
                            {

                            }
                        }
                        ////set the interior range of the xlrange to the defaultcell style of row  
                        //xlRange.Interior.Color = System.Drawing.ColorTranslator.ToOle
                        //    (dataGridView1.Rows[rowCount].DefaultCellStyle.BackColor);

                        ////set the font color  of the xlrange to the styletyle.ForeColor of row  
                        //xlRange.Font.Color = dataGridView1.Rows[rowCount].Cells
                        //            [colCount].Style.ForeColor.ToArgb();

                        if (dataGridView1.Rows[rowCount].Cells[colCount].Style.Font != null)
                        {
                            xlRange.Font.Bold =
                            dataGridView1.Rows[rowCount].Cells[colCount].Style.Font.Bold;
                            xlRange.Font.Italic =
                            dataGridView1.Rows[rowCount].Cells[colCount].Style.Font.Italic;
                            xlRange.Font.Underline =
                            dataGridView1.Rows[rowCount].Cells[colCount].Style.Font.Underline;
                            xlRange.Font.FontStyle =
                            dataGridView1.Rows[rowCount].Cells[colCount].Style.Font.FontFamily;
                        }
                    }
                }
            }
        }
    }
}