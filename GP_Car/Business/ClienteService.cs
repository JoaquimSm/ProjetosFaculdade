using GP_car.Data;
using GP_car.Models;
using System;
using System.Collections.Generic;

namespace GP_car.Business
{
    public class ClienteService
    {
        private readonly ClienteRepository _repo = new ClienteRepository();

        public void Salvar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new ArgumentException("O nome do cliente é obrigatório.");

            if (string.IsNullOrWhiteSpace(cliente.Cnh))
                throw new ArgumentException("A CNH do cliente é obrigatória.");

            cliente.Cnh = cliente.Cnh.Trim();

            if (_repo.CnhJaCadastrada(cliente.Cnh, cliente.IdCliente))
                throw new InvalidOperationException($"Já existe um cliente cadastrado com a CNH {cliente.Cnh}.");

            if (cliente.IdCliente == 0)
            {
                _repo.Inserir(cliente);
            }
            else
            {
                _repo.Atualizar(cliente);
            }
        }

        public void Excluir(int idCliente)
        {
            _repo.Excluir(idCliente);
        }

        public List<Cliente> ObterTodos() => _repo.ListarTodos();
    }
}
