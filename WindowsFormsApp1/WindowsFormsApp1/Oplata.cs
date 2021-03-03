using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace WindowsFormsApp1
{
    public partial class Oplata : Form
    {
        SqlCommand sclCom;
        int id_pok;
        int num_card;
        double stoim;
        double skidka;
        double skidka2;
        string mestechko;
        bool skid_get = false;

        public Oplata(string vib_mesto)
        {
            InitializeComponent();
            id_pok = PokupForm.id_pokupatel;
            mestechko = vib_mesto;
            if (id_pok == 0)
            {
                label_info.Text = "Покупатель неизвестен";
                label9.Visible = false;
                label10.Visible = false;
                label7.Visible = false;
            }
            else if (id_pok == -1)
            {
                label_Name.Text += "admin";
                label_Fam.Text += "admin";
                label_Otc.Text += "admin";
                label_numcard.Text += "999";
                label_Bal.Text += "99999";
            }
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                GetName(conection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!!!" + ex.Message);
            }
            finally
            {
                conection.Close();
                conection.Dispose();
            }
            textBox_sum.Text = Mesto.itog_cena;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cmdText;
            string cmdText2;
            string cmdText3;
            SqlConnection conection = ClassSQL.GetConect();
            SqlConnection conectionn = ClassSQL.GetConect();
            SqlConnection conection3 = ClassSQL.GetConect();
            conectionn.Open();
            conection.Open();
            conection3.Open();
            cmdText = "insert into BIlet (ID_Mesto, ID_Pokup, Stoim, ID_Oplati, Bilet_Opl,Data_time_pokup) values ( '" + mestechko + "', '" + id_pok + "', '" + skidka.ToString() + "', '2', '1', getdate())";
            cmdText2 = "update Mesto set Zan_Mesto = 1 where Num_mesto = " + mestechko + " and ID_Seans = " + ViborSeans.idha + ";";
            cmdText3 = "update Card set Balance = '" + skidka2.ToString() + "' where ID_Card = " + id_pok.ToString() + ";";
            try
            {
            sclCom = new SqlCommand(cmdText, conection);
            sclCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("упс" + ex.Message);
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
                    MessageBox.Show("упс" + ex.Message);
                }
                finally
                {
                    if(id_pok != 0 )
                    try
                    {
                            if (skid_get == false)
                            {
                                skidka2 = Int32.Parse(textBox_sum.Text) * 1.3;
                            }
                            sclCom = new SqlCommand(cmdText3, conection3);
                            sclCom.ExecuteNonQuery();
                            conection3.Close();
                            conection3.Dispose();
                        }
                    catch (Exception ex)
                    {
                            MessageBox.Show(" упс " + ex.Message);
                    }
                    else
                    conection.Close();
                    conection.Dispose();
                    conectionn.Close();
                    conectionn.Dispose();
                    MessageBox.Show("Оплата прошла успешно!", "Уведомление", MessageBoxButtons.OK);
                    MessageBox.Show("Ваше купленое место: "+ mestechko + " ", "Уведомление", MessageBoxButtons.OK);
                }
            }
        }

        private void GetName(SqlConnection con)
        {
            string sc_getPokup = "Select * from Pokup where ID_Pokup = " + id_pok + " ";
            sclCom = new SqlCommand(sc_getPokup, con);
            using (DbDataReader reader = sclCom.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (id_pok == reader.GetInt32(0))
                        {
                            label_Name.Text += reader.GetString(1);
                            label_Fam.Text += reader.GetString(2);
                            label_Otc.Text += reader.GetString(3);
                            label_numcard.Text += reader.GetInt32(4).ToString();
                            num_card = reader.GetInt32(4);
                            try
                            {
                                LoadCard();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка в загрузке информации:" + ex.Message);
                            }
                            finally
                            {
                            }
                        }
                        
                    }

                }
            }

        }


        private void LoadCard()
        {
            string sc_getBal = "select * from Card where id_Card = " + num_card.ToString() + " ";
            SqlConnection conection2 = ClassSQL.GetConect();
            conection2.Open();

            sclCom = new SqlCommand(sc_getBal, conection2);
            using (DbDataReader reader = sclCom.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((num_card) == reader.GetInt32(0))
                        {
                            label_Bal.Text += reader.GetValue(2).ToString();
                        }
                    }
                }
            }
            conection2.Close();
            conection2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            skid_get = true;
            if (id_pok == 0)
            {
                MessageBox.Show("Доступно только дл авторизированных пользователей", "Уведомление", MessageBoxButtons.OK);
            }
            else
            {
                stoim = Int32.Parse(textBox_sum.Text);
                stoim = stoim * 0.3;
                if(Int32.Parse(label_Bal.Text) < stoim)
                {
                    MessageBox.Show("На вашем счету недостаточно бонусных рублей", "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    skidka = Int32.Parse(textBox_sum.Text) - stoim;
                    textBox_sum.Text = skidka.ToString();
                    skidka2 = Int32.Parse(label_Bal.Text) - stoim;
                    label_Bal.Text = skidka2.ToString();
                    MessageBox.Show("Скидка успешко применена", "Уведомление", MessageBoxButtons.OK);

                }
            }
        }

        private void Oplata_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
