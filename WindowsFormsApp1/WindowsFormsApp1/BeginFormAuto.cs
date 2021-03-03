using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace WindowsFormsApp1
{
    public partial class BeginFormAuto : Form
    {
        SqlCommand scomand;
        string sc_getPers = "select * from Personal";
        int id_pers;
        int id_dolj;



        public BeginFormAuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conect = ClassSQL.GetConect();
            conect.Open();
            try
            {
                EnterToSystem(conect);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так(");
            }
            finally
            {
                conect.Close();
                conect.Dispose();
            }
        }

        private void EnterToSystem(SqlConnection con)
        {
            bool yap = false;
            string Login = textBoxLogin.Text;
            string Parol = textBoxPassword.Text;
            scomand = new SqlCommand(sc_getPers, con);
            using (DbDataReader reader = scomand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Login == reader.GetString(10) && Parol == reader.GetString(11))
                        {
                            yap = true;
                            id_dolj = reader.GetInt32(2);
                            id_pers = reader.GetInt32(0);
                        }

                    }
                    if (yap == true)
                    {
                        reader.Close();
                            Form main = new PersFrom(id_pers, id_dolj);
                            main.Show();
                            this.Hide();
                        yap = false;
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином и/или паролем не найден", "Ошибка", MessageBoxButtons.OK);
                        reader.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Pokupatel = new PokupatelAuto();
            Pokupatel.Show();
            this.Hide();
        }
    }
}
