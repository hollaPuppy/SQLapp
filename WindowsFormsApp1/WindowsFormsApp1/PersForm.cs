using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace WindowsFormsApp1
{
    public partial class PersFrom : Form
    {
        SqlCommand scom;
        string sc_getName = "select p.ID_Pers, k.Gorod, k.Naz_Kinoteatr, d.Naz_Dolj, d.Oklad, p.Fam, p.Nam, p.Otc, p.Num_Tel, p.Email, p.Pass_Dan from Personal p join Kinoteatr k on k.ID_KInoteatr = p.ID_Kinoteatr join Doljnost d on d.ID_Dolj = p.ID_Dolj;";
        public static int id_p;
        public static int id_d;
        int id_pol;
        int id_g;
        int id_like_pers = 18;
        SqlConnection conection;
        public PersFrom(int id_pers, int id_dolj)
        {
            
            InitializeComponent();
            PokupForm.id_pokupatel = id_like_pers;
            id_p = id_pers;
            id_d = id_dolj;
            id_pol = id_dolj;
            conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                    FillInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так((" + ex.Message);
            }
            finally
            {
                conection.Close();
                conection.Dispose();
            }
            if (id_d == 8)
            {
                button7.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }




        }

        private void FillInfo()
        {
            scom = new SqlCommand(sc_getName, conection);
            using (DbDataReader reader = scom.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (id_p == reader.GetInt32(0))
                        {
                            label_Gor.Text = reader.GetString(1);
                            label_Kino.Text = reader.GetString(2);
                            label_Dolj.Text = reader.GetString(3);
                            label_oklad.Text = reader.GetDecimal(4).ToString();
                            label_FIO.Text = reader.GetString(5) + " " + reader.GetString(6) + " " + reader.GetString(7);
                            label_Num.Text = reader.GetString(8);
                            label_mail.Text = reader.GetString(9);
                            label_pass.Text = reader.GetString(10);

                        }
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label_Gor.Text == "Ярославль")
            {
                id_g = 1;
            }
            else if (label_Gor.Text == "Вологда")
            {
                id_g = 2;
            }
            Form BiletBuyForm = new ViborSeans(id_g, id_pol);
            BiletBuyForm.Show();
        }

        private void PersFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Form AddFilm = new AddFilm();
            AddFilm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form AddSeans = new AddSeans();
            AddSeans.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form AddPrav = new AddPrav();
            AddPrav.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            Form AddUser = new AddUser();
            AddUser.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form Otchet_vir = new Otchet_vir();
            Otchet_vir.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form Otchet_bilet = new Otchet_bilet();
            Otchet_bilet.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Spravka = new Spravka();
            Spravka.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form AddSeans = new AddSeans();
            AddSeans.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form AddMesto = new AddMesto();
            AddMesto.Show();
        }
    }
}
