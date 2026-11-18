using System;

namespace GP_car.Models
{
    public class Vistoria
    {
        public int IdVistoria { get; set; }
        public int IdAluguel { get; set; }
        public int KmAtual { get; set; }
        public string? DanosObservados { get; set; }
        public DateTime DataVistoria { get; set; }
    }
}
