using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Mesto : Form
    {
        SqlCommand sclCom;
        string id_s;
        string vib_mesto;
        string cena;
        int num_ryad = 1;
        int g;
        int m;
        int d;
        public static string itog_cena;
        public Mesto(string go, string og)
        {
            InitializeComponent();
            g = Int32.Parse(ViborSeans.god_pr);
            m = Int32.Parse(ViborSeans.mes_pr);
            d = Int32.Parse(ViborSeans.day_pr);
            if (Int32.Parse(og) == 5)
            {
                radioButton2.Visible = false;
            }
            id_s = go;
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так(" + ex.Message);
            }

        }
        private void LoadKolvo()
        {
           
            listBox1.Items.Clear();
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();

            string cs_date = "select * from Mesto where Zan_Mesto = 0 and ID_Seans = " + id_s + " and Num_ryad = " + num_ryad.ToString() + ";";
            sclCom = new SqlCommand(cs_date, conection);
            DataSet datset = new DataSet("mesta");
            SqlDataAdapter dat = new SqlDataAdapter(sclCom);
            dat.Fill(datset, "mesto");
            foreach (DataRow row in datset.Tables["mesto"].Rows)
            {
                listBox1.Items.Add(row["Num_mesto"]);
            }
            conection.Close();
            conection.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vib_mesto = listBox1.SelectedItem.ToString();
            button1.Visible = true;
            button2.Visible = true;
            string sc_getBal = "Select Kom_Mesto from Mesto where ID_Seans =  " + ViborSeans.idha + " and Num_mesto = " + vib_mesto + " ";
            SqlConnection conection2 = ClassSQL.GetConect();
            conection2.Open();
            sclCom = new SqlCommand(sc_getBal, conection2);
            
            cena = sclCom.ExecuteScalar().ToString();
            var date = new DateTime(g, m, d);
            if (cena == "True" && (DateTime.Today <= date))
            {
                label3.Text = "500";
            }
            else if (cena == "False" && (DateTime.Today <= date))
            {
                label3.Text = "300";
            }
            else if (cena == "True" && (DateTime.Today > date))
            {
                label3.Text = "150";
                label_mes.Visible = true;
                label_mes.Text = "Цена билета снижена \nв связи с окончанием \nпремьеры";
            }
            else if (cena == "False" && (DateTime.Today > date))
            {
                label3.Text = "100";
                label_mes.Visible = true;
                label_mes.Text = "Цена билета снижена \nв связи с окончанием \nпремьеры";
            }
            itog_cena = label3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Oplata = new Oplata(vib_mesto);
            Oplata.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdText;
            string cmdText2;
            SqlConnection conection = ClassSQL.GetConect();
            SqlConnection conectionn = ClassSQL.GetConect();
            conectionn.Open();
            conection.Open();
            cmdText = "insert into BIlet (ID_Mesto, ID_Pokup, Stoim, ID_Oplati, Bilet_Opl,Data_time_pokup) values ('" + vib_mesto + "', '" + PokupForm.id_pokupatel + "', '" + label3.Text + "', '2', '0', getdate())";
            cmdText2 = "update Mesto set Zan_Mesto = 1 where Num_mesto = " + vib_mesto + " and ID_Seans = " + ViborSeans.idha + ";";
            try
            {
                sclCom = new SqlCommand(cmdText, conection);
                sclCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с бронированием" + ex.Message);
            }
            finally
            {
                try
                {
                    sclCom = new SqlCommand(cmdText2, conectionn);
                    sclCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("проблема с местом" + ex.Message);
                }
                finally
                {
                    
                    conection.Close();
                    conection.Dispose();
                    conectionn.Close();
                    conectionn.Dispose();
                    MessageBox.Show("Бронирование успешно завершено", "Уведомление", MessageBoxButtons.OK);
                    MessageBox.Show("Ваше забронированое место: " + vib_mesto + " ", "Уведомление", MessageBoxButtons.OK);
                }
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            num_ryad = 1;
            LoadKolvo();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            num_ryad = 2;
            LoadKolvo();
        }
    }
}
