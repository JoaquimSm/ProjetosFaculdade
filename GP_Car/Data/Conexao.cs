using MySqlConnector;
using System.Data;

namespace GP_car.Data
{
    public static class Conexao
    {
        // Altere a senha e porta se necessário de acordo com o seu MySQL local
        private static string _connectionString = "Server=localhost;Port=3306;Database=gp_car_db;Uid=root;Pwd=1234;";

        public static string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value;
        }

        public static MySqlConnection ObterConexao()
        {
            var conn = new MySqlConnection(_connectionString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public static bool TestarConexao(out string mensagemErro)
        {
            mensagemErro = string.Empty;
            try
            {
                using var conn = ObterConexao();
                return true;
            }
            catch (System.Exception ex)
            {
                mensagemErro = ex.Message;
                return false;
            }
        }
    }
}
