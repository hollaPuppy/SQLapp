using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class AddSeans : Form
    {
        SqlCommand scom3;
        string sc_getPers = "select k.Naz_Kinoteatr, z.Cvet_Zal, f.Naz_Film, s.Data_time_Seans from Seans s join Kinoteatr k on k.ID_KInoteatr = s.ID_Kinoteatr join Zal z on z.ID_Zal = s.ID_Zal join Film f on f.ID_Film = s.ID_Film;";
        string sc_getKino = "select Naz_Kinoteatr from  Kinoteatr;";
        string sc_getZal = "select Cvet_Zal from  Zal;";
        string sc_getFilm = "select Naz_Film from  Film;";
        SqlConnection con;
        string Kinoteatr;
        string Zal;
        string Film;
        public AddSeans()
        {
            InitializeComponent();
            con = ClassSQL.GetConect();
            con.Open();
            try
            {
                Filldgv();
                Fill1com();
                Fill2com();
                Fill3com();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так(" + ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void Filldgv()
        {
            scom3 = new SqlCommand(sc_getPers, con);
            DataSet datso = new DataSet("Pokupdat");
            SqlDataAdapter da = new SqlDataAdapter(scom3);
            da.Fill(datso, "Pokup");
            dataGridView1.DataSource = datso.Tables["Pokup"];
        }

        private void Fill1com()
        {
            scom3 = new SqlCommand(sc_getKino, con);
            DataSet ds = new DataSet("Naz_kin");
            SqlDataAdapter dat = new SqlDataAdapter(scom3);
            dat.Fill(ds, "Naz_Kinoteatr");
            foreach (DataRow row in ds.Tables["Naz_Kinoteatr"].Rows)
            {
                comboBox1.Items.Add(row["Naz_Kinoteatr"]);
            }
        }

        private void Fill2com()
        {
            scom3 = new SqlCommand(sc_getZal, con);
            DataSet ds = new DataSet("Naz_Zal");
            SqlDataAdapter dat = new SqlDataAdapter(scom3);
            dat.Fill(ds, "Cvet_Zal");
            foreach (DataRow row in ds.Tables["Cvet_Zal"].Rows)
            {
                comboBox2.Items.Add(row["Cvet_Zal"]);
            }
        }

        private void Fill3com()
        {
            scom3 = new SqlCommand(sc_getFilm, con);
            DataSet ds = new DataSet("Naz_kinot");
            SqlDataAdapter dat = new SqlDataAdapter(scom3);
            dat.Fill(ds, "Naz_Film");
            foreach (DataRow row in ds.Tables["Naz_Film"].Rows)
            {
                comboBox3.Items.Add(row["Naz_Film"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = ClassSQL.GetConect();
            con.Open();
            Filldgv();
            con.Close();
            con.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = ClassSQL.GetConect();
            string sc_selectID = "select ID_KInoteatr from  Kinoteatr where Naz_Kinoteatr = '" + comboBox1.SelectedItem.ToString() + "';";
            con.Open();
            scom3 = new SqlCommand(sc_selectID, con);
            Kinoteatr = scom3.ExecuteScalar().ToString();
            con.Close();
            con.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = ClassSQL.GetConect();
            string sc_selectID = "select ID_Film from  Film where Naz_Film = '" + comboBox3.SelectedItem.ToString() + "';";
            con.Open();
            scom3 = new SqlCommand(sc_selectID, con);
            Film = scom3.ExecuteScalar().ToString();
            con.Close();
            con.Dispose();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = ClassSQL.GetConect();
            string sc_selectID = "select ID_Zal from Zal where Cvet_Zal = '" + comboBox2.SelectedItem.ToString() + "';";
            con.Open();
            scom3 = new SqlCommand(sc_selectID, con);
            Zal = scom3.ExecuteScalar().ToString();
            con.Close();
            con.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = ClassSQL.GetConect();
            string sc_insert = "insert into Seans (ID_Kinoteatr, ID_Zal, ID_Film, Data_time_Seans) values ('" + Kinoteatr + "', '" + Zal + "', '" + Film + "', '" + convDat(maskedTextBox1.Text) + "');";

            SqlConnection conection3 = ClassSQL.GetConect();
            con.Open();
            try
            {
                scom3 = new SqlCommand(sc_insert, con);
                scom3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось внести сеанс" + ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                MessageBox.Show("Добавление прошло успешно!", "Уведомление", MessageBoxButtons.OK);
            }

            string convDat(string oldDate)
            {
                string newdate;
                string data = oldDate.Split(' ')[0];
                string vreme = oldDate.Split(' ')[1];
                string[] a1 = new string[3];
                a1 = data.Split('-').ToArray();
                string god = a1[2];
                string mes = a1[1];
                string day = a1[0];

                newdate = god + "-" + mes + "-" + day + " " + vreme;
                return newdate;
            }
        }
    }
}

