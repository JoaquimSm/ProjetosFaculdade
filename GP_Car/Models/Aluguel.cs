using System;

namespace GP_car.Models
{
    public class Aluguel
    {
        public int IdAluguel { get; set; }
        public int IdCliente { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public decimal? ValorTotal { get; set; }

        // Propriedades de navegação/exibição
        public string? NomeCliente { get; set; }
        public string? PlacaVeiculo { get; set; }
        public string? ModeloVeiculo { get; set; }
    }
}
