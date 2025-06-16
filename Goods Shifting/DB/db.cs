using MySql.Data.MySqlClient;

namespace Goods_Shifting
{
    public class DBConnection
    {
        private static string connectionString = "server=localhost;user id=root;password=1234;database=e_shifting;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
