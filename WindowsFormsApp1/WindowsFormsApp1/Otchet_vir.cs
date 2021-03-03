using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Office = Microsoft.Office.Core;


namespace WindowsFormsApp1
{
    public partial class Otchet_vir : Form
    {
        SqlCommand scom;
        string znach = " ";

        public Otchet_vir()
        {
            InitializeComponent();
        }

        private void Filldgv(SqlConnection con)
        {
            string sc_getfilm = "set language english; Select sum(stoim) as 'Сумма продаж за " + znach + " месяц' from Bilet where MONTH(Data_time_pokup) = " + znach + ";";
            scom = new SqlCommand(sc_getfilm, con);
            DataSet datso = new DataSet("datso_seanses");
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(datso, "seanses");
            dataGridView1.DataSource = datso.Tables["seanses"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SFD.Filter = "Файлы Excel (*.xls; *.xlsx) | *.xls; *.xlsx";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Выручка";
                worksheet.Cells[1, 1] = "Выручка";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[2, i] = dataGridView1[i - 1, 0].Value;
                    worksheet.Columns[i].ColumnWidth = 30;
                }
                for (int i = 1; i < dataGridView1.RowCount; i++)
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1[j, i].Value;
                    }
                workbook.SaveAs(SFD.FileName, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            znach = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();

            if (znach != " ")
            {

                try
                {
                    Filldgv(conection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так(" + ex.Message);
                }
                finally
                {
                    conection.Close();
                    conection.Dispose();
                    dataGridView1.Refresh();
                }
            }
        }
    }
}
