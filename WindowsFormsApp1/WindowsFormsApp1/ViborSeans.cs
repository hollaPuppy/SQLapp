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

    public partial class ViborSeans : Form
    {
        SqlCommand sclCom;

       
        
        string Filmc;
        SqlConnection conection;
        int gorod;
        string go;
        string og;
        public static string god_pr;
        public static string mes_pr;
        public static string day_pr;
        public static string idha;
        public static string dat_seans;

        public ViborSeans(int id_g, int id_pol)
        {
            InitializeComponent();

            gorod = id_g;
            conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                string sc_getFilm = "select f.Naz_Film from Film f join Seans s on s.ID_Film = f.ID_Film where Data_time_Seans >= getdate()  and ID_Kinoteatr =  " + gorod.ToString() + "";
                sclCom = new SqlCommand(sc_getFilm, conection);
                DataSet ds = new DataSet("Naz_films");
                SqlDataAdapter dat = new SqlDataAdapter(sclCom);
                dat.Fill(ds, "Films");
                foreach (DataRow row in ds.Tables["Films"].Rows)
                {
                    listBox1.Items.Add(row["Naz_Film"]);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conection.Close();
                conection.Dispose();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            SqlConnection conection3 = ClassSQL.GetConect();
            conection3.Open();
            string cs_film = "Select ID_Film from Film where Naz_Film = '" + listBox1.SelectedItem.ToString()+ "';";
            sclCom = new SqlCommand(cs_film, conection3);
            Filmc = sclCom.ExecuteScalar().ToString();
            conection3.Close();
            conection3.Dispose();
            string sc_getDate = "Select Data_time_Seans from Seans where Data_time_Seans >= getdate() and ID_Kinoteatr = "+ gorod.ToString() + " and ID_Film = " + Filmc.ToString() + " ; ";
            conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                    sclCom = new SqlCommand(sc_getDate, conection);
                    DataSet datset = new DataSet("dates");
                    SqlDataAdapter dat = new SqlDataAdapter(sclCom);
                    dat.Fill(datset, "Date");
                    foreach (DataRow row in datset.Tables["Date"].Rows)
                    {
                        listBox2.Items.Add(row["Data_time_Seans"]);
                    }

            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                    conection.Close();
                    conection.Dispose();
            }
            listBox2.Visible = true;
            label3.Visible = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label_Kolvo.Visible = true;
            button_Vibor.Visible = true;
            try
            {
                LoadKolvo();
                LoadData_prem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то с загрузкой сеансов" + ex.Message);
            }
            finally
            {
            }
        }

        
        string convDat(string oldDate)
        {
            string newdate;
            string data = oldDate.Split(' ')[0];
            string vreme = oldDate.Split(' ')[1];
            string[] a1 = new string[3];
            a1 = data.Split('.').ToArray();
            string god = a1[2];
            string mes = a1[1];
            string day = a1[0];

            newdate = god + "-" + mes + "-" + day + " " + vreme;
            return newdate;
        }
        private void LoadData_prem()
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            string cs_dat_prem = "select f.Data_end_premier from Film f join Seans s on s.ID_Film = f.ID_Film where ID_Seans = " + go + ";";
            sclCom = new SqlCommand(cs_dat_prem, conection);
            string DatePrem = sclCom.ExecuteScalar().ToString();
            string data = DatePrem.Split(' ')[0];
            string[] a1 = new string[3];
            a1 = data.Split('.').ToArray();
            god_pr = a1[2];
            mes_pr = a1[1];
            day_pr = a1[0];
            conection.Close();
            conection.Dispose();
        }
        private void LoadKolvo()
        {
            SqlConnection conection = ClassSQL.GetConect();
            SqlConnection conection3 = ClassSQL.GetConect();
            conection.Open();
            conection3.Open();
            string cs_date = "set language english; select ID_Seans from Seans where Data_time_Seans = '"+convDat(listBox2.SelectedItem.ToString())+"' ;";
            dat_seans = convDat(listBox2.SelectedItem.ToString());
            sclCom = new SqlCommand(cs_date, conection);
            go = sclCom.ExecuteScalar().ToString();
            idha = go;


            string cs_truemesto = "select count(ID_Mesto) from Mesto where Zan_Mesto = 0 and ID_Seans = " + go + ";";
            sclCom = new SqlCommand(cs_truemesto, conection);
            string truemesto = sclCom.ExecuteScalar().ToString();
            label_Kolvo.Text = (Int32.Parse(truemesto)).ToString();
            conection.Close();
            conection.Dispose();
            conection3.Close();
            conection3.Dispose();
        }


        private void button_Vibor_Click(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                string cmdText;
                cmdText = "set language english;select ID_Zal from Seans where ID_Seans = " + idha + " ";
                sclCom = new SqlCommand(cmdText, conection);
                og = sclCom.ExecuteScalar().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в залах" + ex.Message);
            }
            conection.Close();
            conection.Dispose();
            Form Mesto = new Mesto(go, og);
            Mesto.Show();
            this.Hide();
        }

        private void ViborSeans_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
