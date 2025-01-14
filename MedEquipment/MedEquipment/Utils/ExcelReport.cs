using ClosedXML.Excel;
using System.Data;

namespace MedEquipment.Utils
{
    public static class ExcelReport
    {
        private const string reportPath = "C:\\Reports";
        public static void CreateReport(DataGridView dataGridView, string reportName)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dt.Columns.Add(column.HeaderText);//, column.ValueType
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (dataGridView.Rows.Count > row.Index)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }
            }
            if (!Directory.Exists(reportPath))
            {
                Directory.CreateDirectory(reportPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, reportName);

                wb.Worksheet(1).Columns().AdjustToContents();
                string date = DateTime.Now.ToShortDateString().Replace('/', '-');
                wb.SaveAs(reportPath + "\\" + reportName + "-" + date + ".xlsx");
            }
            MessageBox.Show("Файл отчета сохранен в папку " + reportPath);

        }
    }
}
