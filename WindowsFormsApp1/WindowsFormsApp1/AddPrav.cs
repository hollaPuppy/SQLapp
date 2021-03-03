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
    public partial class AddPrav : Form
    {
        SqlCommand scom;
        string sc_getPers = "select * from Pokup;";
        string go;

        public AddPrav()
        {
            InitializeComponent();

            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();

            try
            {
                Filldgv(conection);
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
            scom = new SqlCommand(sc_getPers, con);

            DataSet datso = new DataSet("Pokupdat");
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(datso, "Pokup");

            dataGridView1.DataSource = datso.Tables["Pokup"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();

            Filldgv(conection);

            conection.Close();
            conection.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sc_writepokup = "insert into Pokup (Fam, Nam, Otc, Tel_num, Email) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "');";
            
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                scom = new SqlCommand(sc_writepokup, conection);
                scom.ExecuteNonQuery();
                conection.Close();
                conection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не записался покупатель" + ex.Message);
            }
            finally
            {

                try
                {
                    string sc_selectID = "select id_pokup from Pokup where Fam = '" + textBox1.Text + "' and Nam = '" + textBox2.Text + "' and Otc =  '" + textBox3.Text + "';";

                    SqlConnection conection2 = ClassSQL.GetConect();
                    conection2.Open();
                    scom = new SqlCommand(sc_selectID, conection2);
                    go = scom.ExecuteScalar().ToString();

                    conection2.Close();
                    conection2.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не нашелся айди" + ex.Message);
                }
                finally
                {
                    try
                    {
                        string sc_writecard = "insert into card(Num_Card, Balance) values(' " + go + " ', '0');";

                        SqlConnection conection3 = ClassSQL.GetConect();
                        conection3.Open();
                        scom = new SqlCommand(sc_writecard, conection3);
                        scom.ExecuteNonQuery();

                        conection3.Close();
                        conection3.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не создалась карта " + ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            string sc_UpCard = "update Pokup set ID_Card =  " + go + " where ID_Pokup = " + go + ";";

                            SqlConnection conection4 = ClassSQL.GetConect();
                            conection4.Open();
                            scom = new SqlCommand(sc_UpCard, conection4);
                            scom.ExecuteNonQuery();

                            conection4.Close();
                            conection4.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не создалась карта " + ex.Message);
                        }
                        finally
                        {
                            MessageBox.Show("Добавление прошло успешно!", "Уведомление", MessageBoxButtons.OK);
                            MessageBox.Show("Номер покупателя в системе: " + go + "", "Уведомление", MessageBoxButtons.OK);
                        }
                    }

                }
            
            }
            
            
        }
    }
}
