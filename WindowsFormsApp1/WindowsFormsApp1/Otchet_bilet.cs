using System;

using System.Data;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Office = Microsoft.Office.Core;

namespace WindowsFormsApp1
{
    public partial class Otchet_bilet : Form
    {
        string znach = " ";
        SqlCommand scom;
        public Otchet_bilet()
        {

            InitializeComponent();
        }

        private void Filldgv(SqlConnection con)
        {
            string sc_getfilm = "set language english; Select * from Bilet where MONTH(Data_time_pokup) = " + znach + ";";
            scom = new SqlCommand(sc_getfilm, con);
            DataSet datso = new DataSet("datso_seanses");
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(datso, "seanses");
            dataGridView1.DataSource = datso.Tables["seanses"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SFD.Filter = "Файлы Excel (*.xls; *.xlsx) | *.xls; *.xlsx";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ID_Bilet";
                worksheet.Cells[1, 1] = "ID_Bilet";
                worksheet.Name = "ID_Seans";
                worksheet.Cells[1, 2] = "ID_Seans";
                worksheet.Name = "ID_Mesto";
                worksheet.Cells[1, 3] = "ID_Mesto";
                worksheet.Name = "ID_Pokup";
                worksheet.Cells[1, 4] = "ID_Pokup";
                worksheet.Name = "Stoim";
                worksheet.Cells[1, 5] = "Stoim";
                worksheet.Name = "ID_Oplati";
                worksheet.Cells[1, 6] = "ID_Oplati";
                worksheet.Name = "Bilet_Opl";
                worksheet.Cells[1, 7] = "Bilet_Opl";
                worksheet.Name = "Data_time_pokup";
                worksheet.Cells[1, 8] = "Data_time_pokup";

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

        private void button2_Click(object sender, EventArgs e)
        {
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
}
