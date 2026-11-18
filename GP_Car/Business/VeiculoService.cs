using GP_car.Data;
using GP_car.Models;
using System;
using System.Collections.Generic;

namespace GP_car.Business
{
    public class VeiculoService
    {
        private readonly VeiculoRepository _repo = new VeiculoRepository();

        public void Salvar(Veiculo veiculo)
        {
            if (string.IsNullOrWhiteSpace(veiculo.Placa))
                throw new ArgumentException("A placa do veículo é obrigatória.");

            veiculo.Placa = veiculo.Placa.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(veiculo.Modelo))
                throw new ArgumentException("O modelo do veículo é obrigatório.");

            if (string.IsNullOrWhiteSpace(veiculo.Marca))
                throw new ArgumentException("A marca do veículo é obrigatória.");

            if (veiculo.Ano < 1950 || veiculo.Ano > DateTime.Now.Year + 1)
                throw new ArgumentException("O ano do veículo informado é inválido.");

            if (_repo.PlacaJaCadastrada(veiculo.Placa, veiculo.IdVeiculo))
                throw new InvalidOperationException($"Já existe um veículo cadastrado com a placa {veiculo.Placa}.");

            if (veiculo.IdVeiculo == 0)
            {
                if (string.IsNullOrEmpty(veiculo.Status))
                    veiculo.Status = "Disponivel";

                _repo.Inserir(veiculo);
            }
            else
            {
                _repo.Atualizar(veiculo);
            }
        }

        public void AlterarStatus(int idVeiculo, string novoStatus)
        {
            if (novoStatus != "Disponivel" && novoStatus != "Alugado" && novoStatus != "Manutencao")
                throw new ArgumentException("Status informado inválido. Use Disponivel, Alugado ou Manutencao.");

            var veiculo = _repo.ObterPorId(idVeiculo);
            if (veiculo == null)
                throw new InvalidOperationException("Veículo não encontrado.");

            if (veiculo.Status == "Alugado" && novoStatus != "Disponivel")
                throw new InvalidOperationException("Não é permitido alterar diretamente o status de um veículo que está alugado.");

            _repo.AtualizarStatus(idVeiculo, novoStatus);
        }

        public void Excluir(int idVeiculo)
        {
            var veiculo = _repo.ObterPorId(idVeiculo);
            if (veiculo != null && veiculo.Status == "Alugado")
                throw new InvalidOperationException("Não é possível excluir um veículo que se encontra alugado.");

            _repo.Excluir(idVeiculo);
        }

        public List<Veiculo> ObterTodos() => _repo.ListarTodos();
    }
}
