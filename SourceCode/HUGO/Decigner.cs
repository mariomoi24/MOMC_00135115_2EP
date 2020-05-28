using System.Data;
using Npgsql;


namespace HUGO
{
    public static class Decigner
    {
        private static string host = "127.0.0.1",
            database = "Parcial 2",
            userID = "postgres",
            password = "UCA25";

        private static string sConnection =
            $"Host={host};Port=5432;Database{database};UserID{userID};Password{password};";

        public static DataTable ExecuteQuery(string query)
        {
          NpgsqlConnection connection = new NpgsqlConnection(sConnection);
          DataSet ds = new DataSet();
          
          connection.Open();
          
          NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
          da.Fill(ds);
          
          connection.Close();

          return ds.Tables[0];

        }

        public static void ExecuteNomQuery(string act)
        {
            NpgsqlConnection connection= new NpgsqlConnection(sConnection);
            
            connection.Open();
            
            NpgsqlCommand command= new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            
            connection.Close();


        }
    }
    
}