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
    public partial class AddMesto : Form
    {
        SqlCommand scom;
        string sc_getMesto = "select m.ID_Mesto, z.Cvet_Zal, m.Num_ryad, m.Num_mesto, m.Zan_Mesto, m.Kom_Mesto, s.Data_time_Seans from Mesto m join Zal z on z.ID_Zal = m.ID_Zal join Seans s on s.ID_Seans = m.ID_Seans;";
        string sc_getCvet = "select Cvet_Zal from Zal;";
        string sc_getDat = "select Data_time_Seans from Seans;";
        string Zal;
        string Seans;
        public AddMesto()
        {
            InitializeComponent();
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                Filldgv(conection);
                Filljanr(conection);
                FillDat(conection);
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
        private void Filldgv(SqlConnection con)
        {
            scom = new SqlCommand(sc_getMesto, con);
            DataSet datso = new DataSet("datso_Mesto");
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(datso, "Mesto");
            dataGridView1.DataSource = datso.Tables["Mesto"];
        }
        private void Filljanr(SqlConnection con)
        {
            scom = new SqlCommand(sc_getCvet, con);
            DataSet ds = new DataSet("Cvet_Zal");
            SqlDataAdapter dat = new SqlDataAdapter(scom);
            dat.Fill(ds, "Zal");
            foreach (DataRow row in ds.Tables["Zal"].Rows)
            {
                comboBox1.Items.Add(row["Cvet_Zal"]);
            }

        }
        private void FillDat(SqlConnection con)
        {
            scom = new SqlCommand(sc_getDat, con);
            DataSet ds = new DataSet("Data_time_Seans");
            SqlDataAdapter dat = new SqlDataAdapter(scom);
            dat.Fill(ds, "Seans");
            foreach (DataRow row in ds.Tables["Seans"].Rows)
            {
                comboBox2.Items.Add(row["Data_time_Seans"]);
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            string sc_insert = "insert into mesto (ID_Zal, Num_ryad, Num_mesto, Zan_Mesto, Kom_Mesto, ID_Seans) values (" + Zal + ", '"+ textBox1.Text+ "', '" + textBox2.Text + "', '0', '" + textBox3.Text + "',  " + Seans + ")";
            if(textBox3.Text == "0" | textBox3.Text == "1")
            {
                scom = new SqlCommand(sc_insert, conection);
                scom.ExecuteNonQuery();
                MessageBox.Show("Место успешно добавлено", "Уведомление", MessageBoxButtons.OK);
                conection.Close();
                conection.Dispose();
            }
            else
            {
                MessageBox.Show("Комфортность места определяется 1 или 0", "Уведомление", MessageBoxButtons.OK);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            string sc_selectIDZal = "select ID_Zal from Zal where Cvet_Zal = '"+comboBox1.SelectedItem.ToString()+"';";
            scom = new SqlCommand(sc_selectIDZal, conection);
            Zal = scom.ExecuteScalar().ToString();
            conection.Close();
            conection.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            string sc_selectIDSeans = "select ID_Seans from Seans where Data_time_Seans = '"+ comboBox2.SelectedItem.ToString() + "';";
            scom = new SqlCommand(sc_selectIDSeans, conection);
            Seans = scom.ExecuteScalar().ToString();
            conection.Close();
            conection.Dispose();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            string sc_delMesto = "Delete from Mesto where ID_Mesto = " + textBox4.Text.ToString() + ";";
            try
            {
                scom = new SqlCommand(sc_delMesto, conection);
                scom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с удалением" + ex.Message);
            }
            finally
            {
                conection.Close();
                conection.Dispose();
                MessageBox.Show("Место удалено", "Уведомление", MessageBoxButtons.OK);
            }
        }
    }
}
