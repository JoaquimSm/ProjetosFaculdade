using GP_car.Models;
using MySqlConnector;
using System.Collections.Generic;

namespace GP_car.Data
{
    public class ClienteRepository
    {
        public void Inserir(Cliente c)
        {
            using var conn = Conexao.ObterConexao();
            string query = @"INSERT INTO cliente (nome, cnh, telefone, endereco) 
                             VALUES (@nome, @cnh, @telefone, @endereco)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@cnh", c.Cnh);
            cmd.Parameters.AddWithValue("@telefone", c.Telefone);
            cmd.Parameters.AddWithValue("@endereco", c.Endereco);
            cmd.ExecuteNonQuery();
        }

        public void Atualizar(Cliente c)
        {
            using var conn = Conexao.ObterConexao();
            string query = @"UPDATE cliente 
                             SET nome = @nome, cnh = @cnh, telefone = @telefone, endereco = @endereco 
                             WHERE id_cliente = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@cnh", c.Cnh);
            cmd.Parameters.AddWithValue("@telefone", c.Telefone);
            cmd.Parameters.AddWithValue("@endereco", c.Endereco);
            cmd.Parameters.AddWithValue("@id", c.IdCliente);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int idCliente)
        {
            using var conn = Conexao.ObterConexao();
            string query = "DELETE FROM cliente WHERE id_cliente = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idCliente);
            cmd.ExecuteNonQuery();
        }

        public List<Cliente> ListarTodos()
        {
            var lista = new List<Cliente>();
            using var conn = Conexao.ObterConexao();
            string query = "SELECT id_cliente, nome, cnh, telefone, endereco FROM cliente ORDER BY nome";
            using var cmd = new MySqlCommand(query, conn);
            using var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente
                {
                    IdCliente = dr.GetInt32("id_cliente"),
                    Nome = dr.GetString("nome"),
                    Cnh = dr.GetString("cnh"),
                    Telefone = dr.IsDBNull(dr.GetOrdinal("telefone")) ? "" : dr.GetString("telefone"),
                    Endereco = dr.IsDBNull(dr.GetOrdinal("endereco")) ? "" : dr.GetString("endereco")
                });
            }
            return lista;
        }

        public bool CnhJaCadastrada(string cnh, int idDesconsiderar = 0)
        {
            using var conn = Conexao.ObterConexao();
            string query = "SELECT COUNT(*) FROM cliente WHERE cnh = @cnh AND id_cliente != @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cnh", cnh);
            cmd.Parameters.AddWithValue("@id", idDesconsiderar);
            long count = (long)(cmd.ExecuteScalar() ?? 0L);
            return count > 0;
        }
    }
}
