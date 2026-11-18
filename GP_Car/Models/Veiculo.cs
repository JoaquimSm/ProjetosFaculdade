namespace GP_car.Models
{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public int Ano { get; set; }
        public string Status { get; set; } = "Disponivel"; // "Disponivel", "Alugado", "Manutencao"
        public string Cor { get; set; } = string.Empty;
    }
}
