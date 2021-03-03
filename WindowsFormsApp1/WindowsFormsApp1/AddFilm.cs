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

namespace WindowsFormsApp1
{
    public partial class AddFilm : Form
    {
        SqlCommand scom;
        string sc_getfilm = "select f.ID_Film, f.Data_Prem, f.Naz_Film, j.Naz_Janr, f.Prodol_Film, f.Vozrast_ogran, pr.Name_Pravoob, f.Data_end_premier from Film f  join Janr j on j.ID_Janr = f.ID_Janr join Pravoobladatel pr on pr.ID_Pravoob = f.ID_Pravoob;";
        string sc_getprav = "select Name_Pravoob from Pravoobladatel;";
        string sc_getjanr = "select Naz_Janr from Janr order by ID_Janr asc;";
        int prav = 1;
        int janr = 1;

        public AddFilm()
        {
            InitializeComponent();
           
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                Filldgv(conection);
                Filljanr(conection);
                FillPrav(conection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так(" + ex.Message);
            }
            finally
            {
                conection.Close();
                conection.Dispose();
            }
        }
        private void Filldgv (SqlConnection con)
        {
            scom = new SqlCommand(sc_getfilm, con);
            DataSet datso = new DataSet("datso_seanses");
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(datso, "seanses");
            dataGridView1.DataSource = datso.Tables["seanses"];
        }

        string convDat(string oldDate)
        {
            string[] a1 = new string[3];
            a1 = oldDate.Split(',').ToArray();
            string god = a1[2];
            string mes = a1[1];
            string day = a1[0];

            string newdate = day  + "." + mes + "." + god;
            return newdate;
        }

        private void Filljanr(SqlConnection con)
        {
            scom = new SqlCommand(sc_getjanr, con);
            DataSet ds = new DataSet("Naz_films");
            SqlDataAdapter dat = new SqlDataAdapter(scom);
            dat.Fill(ds, "Film");
            foreach (DataRow row in ds.Tables["Film"].Rows)
            {
                comboBox1.Items.Add(row["Naz_Janr"]);
            }

        }

        private void FillPrav(SqlConnection con)
        {
            scom = new SqlCommand(sc_getprav, con);
            DataSet ds = new DataSet("Naz_prav");
            SqlDataAdapter dat = new SqlDataAdapter(scom);
            dat.Fill(ds, "Pravoobladatel");
            foreach (DataRow row in ds.Tables["Pravoobladatel"].Rows)
            {
                comboBox2.Items.Add(row["Name_Pravoob"]);
            }

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Обновить_Click(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            Filldgv(conection);
            conection.Close();
            conection.Dispose();
        }
            private void button1_Click(object sender, EventArgs e)
            {
                prav += comboBox2.SelectedIndex;
                janr += comboBox1.SelectedIndex;
                string sc_writefilm = "insert into Film (Data_Prem, Naz_Film, ID_Janr, Prodol_Film, Vozrast_ogran,ID_Pravoob, Data_end_premier) values ('" + convDat(maskedTextBox1.Text)+ "', '" + textBox1.Text + "', '" + janr.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + prav.ToString() + "', '" + convDat(maskedTextBox2.Text) + "');";
                SqlConnection conection = ClassSQL.GetConect();
                conection.Open();
                try
                {
                scom = new SqlCommand(sc_writefilm, conection);
                scom.ExecuteNonQuery();
                MessageBox.Show("Добавление прошло успешно!", "Уведомление", MessageBoxButtons.OK);
                }
                 catch (Exception ex)
                {
                MessageBox.Show("не записалось!" + ex.Message);
                }
                conection.Close();
                conection.Dispose();
                prav = 1;
                janr = 1;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

    }
}
