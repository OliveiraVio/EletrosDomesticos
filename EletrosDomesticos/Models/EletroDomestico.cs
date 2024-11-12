namespace EletrosDomesticos.Models
{
    public abstract class EletroDomestico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double ConsumoEnergetico { get; set; }

        public abstract string ExibirDetalhes();
    }
}
