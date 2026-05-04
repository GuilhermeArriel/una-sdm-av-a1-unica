namespace ValeAtivos324112890.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Localizacao { get; set; }
        public double CapacidadeProcessamento { get; set; }
        public DateTime DataUltimaManutencao { get; set; }
        public bool EmOperacao { get; set; }
    }
}