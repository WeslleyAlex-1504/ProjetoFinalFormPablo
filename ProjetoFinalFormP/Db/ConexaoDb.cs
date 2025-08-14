using MySql.Data.MySqlClient;

namespace Sistema.Database
{
    public class Conexao
    {
        private const string connectionString = "server=mysql-weslleyalex.alwaysdata.net;port=3306;database=weslleyalex_123;user=410618_weslley;password=Ben10123;";

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }
    }
}
