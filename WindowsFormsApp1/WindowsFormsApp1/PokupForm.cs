using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace WindowsFormsApp1
{
    public partial class PokupForm : Form
    {
        SqlConnection con;
        SqlCommand scom;
        string sc_getKinoteatr = "select * from Kinoteatr";
        string sc_getName = "select * from Pokup";
        string sc_getseansYar = "select s.Data_time_Seans, f.Naz_Film, z.Cvet_Zal, f.Prodol_Film, f.Vozrast_ogran, k.Gorod from seans s join Film f on f.ID_Film = s.ID_Film  join Zal z on z.ID_Zal = s.ID_Zal join Kinoteatr k  on k.ID_KInoteatr = s.ID_Kinoteatr where Gorod = 'Ярославль' and Data_time_Seans>= getdate() order by Data_time_Seans ASC;";
        string sc_getseansVol = "select s.Data_time_Seans, f.Naz_Film, z.Cvet_Zal, f.Prodol_Film, f.Vozrast_ogran, k.Gorod from seans s join Film f on f.ID_Film = s.ID_Film  join Zal z on z.ID_Zal = s.ID_Zal join Kinoteatr k  on k.ID_KInoteatr = s.ID_Kinoteatr where Gorod = 'Вологда' and Data_time_Seans>= getdate() order by Data_time_Seans ASC";
        
        int id_k;
        int id_c;
        int id_b;
        public static int id_pokupatel = 18;
        string pathimg;
        public PokupForm(string Num_card, string Balance, int id_Goroda)
        {
            InitializeComponent();

            id_k = id_Goroda;
            id_c = Int32.Parse(Num_card);
            id_b = Int32.Parse(Balance);

            con = ClassSQL.GetConect();
            con.Open();
            try
            {
                if (Num_card != "0")
                {
                    FullName();
                    button2.Visible = true;
                }
                    EnterToSys();
                    LoadSeans();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так" + ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            SqlConnection conection4 = ClassSQL.GetConect();
            conection4.Open();
            string sc_getimg = "Select Img_kinoteatra from kinoteatr where ID_KInoteatr = " + id_k + " ";
            scom = new SqlCommand(sc_getimg, conection4);
            pathimg = scom.ExecuteScalar().ToString();
            pictureBox1.Image = Image.FromFile(pathimg);
        }

        private void EnterToSys()
        {
            scom = new SqlCommand(sc_getKinoteatr, con);
            using (DbDataReader reader = scom.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(id_c == 0)
                        {
                            label_Info.Text = "Информация доступна для авторизированных пользователей";
                            label2.ForeColor = Color.FromName("InactiveCaption");
                            label7.ForeColor = Color.FromName("InactiveCaption");
                            label9.ForeColor = Color.FromName("InactiveCaption");
                            label6.ForeColor = Color.FromName("InactiveCaption");
                            label3.ForeColor = Color.FromName("InactiveCaption");
                            label_Naz_Kinoteatra.Text = reader.GetString(1);
                            label_Naz_Gorod.Text = reader.GetString(2);
                        }
                        else if (id_k == reader.GetInt32(0) && id_c != 0)
                        {

                            label_Card.Text = id_c.ToString();
                            label_Balance.Text = id_b.ToString();
                            label_Naz_Kinoteatra.Text = reader.GetString(1);
                            label_Naz_Gorod.Text = reader.GetString(2);
                        }

                    }
                   
                }
            }
        }
        private void FullName()
        {
            scom = new SqlCommand(sc_getName, con);
            using (DbDataReader reader = scom.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (id_c == reader.GetInt32(4))
                        {
                            id_pokupatel = reader.GetInt32(0);
                            label_Name.Text = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                            label_Mail.Text = reader.GetString(6);
                            label_Nomer.Text = reader.GetString(5);
                        }
                    }

                }
            }
        }

        private void LoadSeans()
        {
                try
                {
                if(id_k == 1)
                    scom = new SqlCommand(sc_getseansYar, con);
                else
                {
                    scom = new SqlCommand(sc_getseansVol, con);
                }
                DataSet datso = new DataSet("datso_seanses");
                SqlDataAdapter da = new SqlDataAdapter(scom);
                da.Fill(datso, "seanses");
                dataGridView1.DataSource = datso.Tables["seanses"];
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {

                }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form BiletBuyForm = new ViborSeans(id_k, 0);
            BiletBuyForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Это афиша", "Ошибка", MessageBoxButtons.OK);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form Spravka = new Spravka();
            Spravka.Show();
        }

        private void PokupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form LoorBilet = new LoorBilet();
            LoorBilet.Show();
        }
    }
}
