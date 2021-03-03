using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    class ClassSQL
    {
        public static SqlConnection GetConect()
        {
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=kino;Integrated Security=true";
            SqlConnection conect = new SqlConnection(connString);
            return conect;
        }
    }
}
