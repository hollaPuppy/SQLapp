using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LoorBilet : Form
    {
        SqlCommand scom;
        public LoorBilet()
        {
            InitializeComponent();
            SqlConnection conection = ClassSQL.GetConect();
            conection.Open();
            try
            {
                LoadBilet(conection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так" + ex.Message);
            }
            conection.Close();
            conection.Dispose();
        }
        private void LoadBilet(SqlConnection con)
        {
            string cs_getBilet = "select pok.Fam as Фамилия, pok.Nam as Имя, b.Stoim as Стоимость, s.Data_time_Seans as Дата_Сеанса, z.Cvet_Zal as Зал, m.Num_ryad as Номер_Ряда, m.Num_mesto as Номер_Места, m.Kom_Mesto as Комфортное_Место, op.Sposob_Oplati as Способ_оплаты, b.Data_time_pokup as Дата_покупки from BIlet B join Mesto m on m.ID_Mesto = b.ID_Mesto join Pokup pok on pok.ID_Pokup = b.ID_Pokup join Sposob_oplati op on op.ID_Oplati = b.ID_Oplati join Seans s on s.ID_Seans = m.ID_Seans join Zal z on z.ID_Zal = m.ID_Zal where b.ID_Pokup = " + PokupForm.id_pokupatel.ToString() + ";";
            try 
            { 
                scom = new SqlCommand(cs_getBilet, con);
                DataSet datso = new DataSet("datso_Bilets");
                SqlDataAdapter da = new SqlDataAdapter(scom);
                da.Fill(datso, "Bilets");
                dataGridView1.DataSource = datso.Tables["Bilets"];
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
