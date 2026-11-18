using GP_car.Models;
using MySqlConnector;
using System.Collections.Generic;

namespace GP_car.Data
{
    public class VeiculoRepository
    {
        public void Inserir(Veiculo v)
        {
            using var conn = Conexao.ObterConexao();
            string query = @"INSERT INTO veiculo (placa, modelo, marca, categoria, ano, status, cor) 
                             VALUES (@placa, @modelo, @marca, @categoria, @ano, @status, @cor)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@placa", v.Placa.ToUpper());
            cmd.Parameters.AddWithValue("@modelo", v.Modelo);
            cmd.Parameters.AddWithValue("@marca", v.Marca);
            cmd.Parameters.AddWithValue("@categoria", v.Categoria);
            cmd.Parameters.AddWithValue("@ano", v.Ano);
            cmd.Parameters.AddWithValue("@status", v.Status);
            cmd.Parameters.AddWithValue("@cor", v.Cor);
            cmd.ExecuteNonQuery();
        }

        public void Atualizar(Veiculo v)
        {
            using var conn = Conexao.ObterConexao();
            string query = @"UPDATE veiculo 
                             SET modelo = @modelo, marca = @marca, categoria = @categoria, 
                                 ano = @ano, status = @status, cor = @cor 
                             WHERE id_veiculo = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@modelo", v.Modelo);
            cmd.Parameters.AddWithValue("@marca", v.Marca);
            cmd.Parameters.AddWithValue("@categoria", v.Categoria);
            cmd.Parameters.AddWithValue("@ano", v.Ano);
            cmd.Parameters.AddWithValue("@status", v.Status);
            cmd.Parameters.AddWithValue("@cor", v.Cor);
            cmd.Parameters.AddWithValue("@id", v.IdVeiculo);
            cmd.ExecuteNonQuery();
        }

        public void AtualizarStatus(int idVeiculo, string novoStatus)
        {
            using var conn = Conexao.ObterConexao();
            string query = "UPDATE veiculo SET status = @status WHERE id_veiculo = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", novoStatus);
            cmd.Parameters.AddWithValue("@id", idVeiculo);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int idVeiculo)
        {
            using var conn = Conexao.ObterConexao();
            string query = "DELETE FROM veiculo WHERE id_veiculo = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idVeiculo);
            cmd.ExecuteNonQuery();
        }

        public List<Veiculo> ListarTodos()
        {
            var lista = new List<Veiculo>();
            using var conn = Conexao.ObterConexao();
            string query = "SELECT id_veiculo, placa, modelo, marca, categoria, ano, status, cor FROM veiculo ORDER BY marca, modelo";
            using var cmd = new MySqlCommand(query, conn);
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Veiculo
                {
                    IdVeiculo = dr.GetInt32("id_veiculo"),
                    Placa = dr.GetString("placa"),
                    Modelo = dr.GetString("modelo"),
                    Marca = dr.GetString("marca"),
                    Categoria = dr.IsDBNull(dr.GetOrdinal("categoria")) ? "" : dr.GetString("categoria"),
                    Ano = dr.GetInt32("ano"),
                    Status = dr.GetString("status"),
                    Cor = dr.IsDBNull(dr.GetOrdinal("cor")) ? "" : dr.GetString("cor")
                });
            }
            return lista;
        }

        public Veiculo? ObterPorId(int idVeiculo)
        {
            using var conn = Conexao.ObterConexao();
            string query = "SELECT id_veiculo, placa, modelo, marca, categoria, ano, status, cor FROM veiculo WHERE id_veiculo = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idVeiculo);
            using var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return new Veiculo
                {
                    IdVeiculo = dr.GetInt32("id_veiculo"),
                    Placa = dr.GetString("placa"),
                    Modelo = dr.GetString("modelo"),
                    Marca = dr.GetString("marca"),
                    Categoria = dr.IsDBNull(dr.GetOrdinal("categoria")) ? "" : dr.GetString("categoria"),
                    Ano = dr.GetInt32("ano"),
                    Status = dr.GetString("status"),
                    Cor = dr.IsDBNull(dr.GetOrdinal("cor")) ? "" : dr.GetString("cor")
                };
            }
            return null;
        }

        public bool PlacaJaCadastrada(string placa, int idDesconsiderar = 0)
        {
            using var conn = Conexao.ObterConexao();
            string query = "SELECT COUNT(*) FROM veiculo WHERE placa = @placa AND id_veiculo != @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@placa", placa.ToUpper());
            cmd.Parameters.AddWithValue("@id", idDesconsiderar);
            long count = (long)(cmd.ExecuteScalar() ?? 0L);
            return count > 0;
        }
    }
}
