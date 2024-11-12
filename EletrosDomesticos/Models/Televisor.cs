namespace EletrosDomesticos.Models
{
    public class Televisor : EletroDomestico
    {
        public int TamanhoTela { get; set; }
        public bool EhSmart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo {Modelo}, Consumo: {ConsumoEnergetico}, Tela: {TamanhoTela}, Smart {(EhSmart? "Sim" : "Não")}";
        }
    }
}
