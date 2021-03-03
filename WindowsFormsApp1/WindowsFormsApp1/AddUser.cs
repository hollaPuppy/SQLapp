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
    public partial class AddUser : Form
    {
        SqlCommand scom;
        SqlConnection con;
        string sc_getPers = "select p.ID_Pers, k.Naz_Kinoteatr, d.Naz_Dolj, p.Gorod, p.Ulitsa, p.Dom, p.Kvartira, p.Fam, p.Nam, p.Otc, p.Login, p.Parol, p.Num_Tel, p.Email, p.Pass_Dan from Personal p  join Kinoteatr k on k.ID_KInoteatr = p.ID_Kinoteatr join Doljnost d on d.ID_Dolj = p.ID_Dolj;";
        string sc_getKin = "select Naz_Kinoteatr from Kinoteatr;";
        string sc_getdolj = "select Naz_Dolj from Doljnost;";
        int id_kin;
        int id_dolj;

        public AddUser()
        {
            InitializeComponent();

            con = ClassSQL.GetConect();
            con.Open();
            try
            {
                Filldgv();
                FillKin();
                FillDolj();
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
            scom = new SqlCommand(sc_getPers, con);
            DataSet datso = new DataSet("persdat");
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(datso, "pers");
            dataGridView1.DataSource = datso.Tables["pers"];

        }

        private void FillKin()
        {
            scom = new SqlCommand(sc_getKin, con);
            DataSet ds = new DataSet("Naz_films");
            SqlDataAdapter dat = new SqlDataAdapter(scom);
            dat.Fill(ds, "Film");
            foreach (DataRow row in ds.Tables["Film"].Rows)
            {
                comboBox1.Items.Add(row["Naz_Kinoteatr"]);
            }

        }
        private void FillDolj()
        {
            scom = new SqlCommand(sc_getdolj, con);
            DataSet ds = new DataSet("Naz_prav");
            SqlDataAdapter dat = new SqlDataAdapter(scom);
            dat.Fill(ds, "Pravoobladatel");
            foreach (DataRow row in ds.Tables["Pravoobladatel"].Rows)
            {
                comboBox2.Items.Add(row["Naz_Dolj"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string sc_writepers = "insert into Personal (ID_Kinoteatr, ID_Dolj, Gorod, Ulitsa, Dom, Kvartira, Fam, Nam, Otc, Login, Parol, Num_Tel, Email, Pass_Dan) values ('" + id_kin.ToString() + "', '" + id_dolj.ToString() + "', '" + textBox_go.Text + "', '" + textBox_ul.Text + "', '" + textBox_dom.Text + "', '" + textBox_kv.Text + "', '" + textBox_fam.Text + "', '" + textBox_nam.Text + "', '" + textBox_otc.Text + "', '" + textBox_log.Text + "', '" + textBox_pass.Text + "', '" + textBox_mob.Text + "', '" + textBox_mail.Text + "', '" + textBox_pasp.Text + "');";
             SqlConnection conection = ClassSQL.GetConect();
             conection.Open();
             try
             {
                 scom = new SqlCommand(sc_writepers, conection);
                 scom.ExecuteNonQuery();
                 MessageBox.Show("Добавление прошло успешно!", "Уведомление", MessageBoxButtons.OK);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("не записалось!" + ex.Message);
             }
             conection.Close();
             conection.Dispose();

        
        }

    private void button2_Click(object sender, EventArgs e)
        {
            con = ClassSQL.GetConect();
            con.Open();

            Filldgv();

            con.Close();
            con.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                id_kin = 1;
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                id_kin = 2;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    id_dolj = 1;

                }
                if (comboBox2.SelectedIndex == 1)
                {
                    id_dolj = 8;
                }
            }
        }
    }
}

