using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;


namespace WindowsFormsApp1
{
    public partial class PokupatelAuto : Form
    {
        string sc_getCard = "select * from Card";
        string Num_card;
        string Balance;
        int id_Goroda = 0;
        SqlCommand scommand;


        public PokupatelAuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = ClassSQL.GetConect();
            connect.Open();
            try
            {
                EnterToSystem(connect);
            }
            catch
            {
                if (textBox_Card.Text == "")
                {
                    MessageBox.Show("Для авторизации нужно ввести номер карты");
                }
            }
            finally
            {
                connect.Close();
                connect.Dispose();
            }
        }

        private void EnterToSystem(SqlConnection trycon)
        {
            bool CardOk = false;
            int LogCard = Int32.Parse(textBox_Card.Text);
            scommand = new SqlCommand(sc_getCard, trycon);
            using (DbDataReader reader = scommand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (LogCard == reader.GetInt32(0))
                        {
                            CardOk = true;
                            Num_card = reader.GetString(1);
                            Balance = reader.GetString(2);
                        }

                    }
                    if (CardOk == true && comboBox1.SelectedIndex != 0)
                    {
                        Form FormPokup = new PokupForm(Num_card, Balance, id_Goroda);
                        FormPokup.Show();
                        this.Hide();
                        CardOk = false;
                    }
                    else
                    {
                        if (CardOk == false)
                        {
                            MessageBox.Show("Пользователь с таким логином и/или паролем не найден", "Ошибка", MessageBoxButtons.OK);
                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 ^ comboBox1.SelectedIndex == 2)
            {
                Form FormPokup = new PokupForm("0", "0", id_Goroda);
                FormPokup.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Нужно выбрать город", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Goroda = comboBox1.SelectedIndex;
        }

        private void PokupatelAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
