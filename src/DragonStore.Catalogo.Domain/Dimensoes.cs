using DragonStore.Core.DomainObjects;

namespace DragonStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Profundidade { get; set; }

        public Dimensoes(double altura, double largura, double profundidade)
        {
            Validacoes.ValidarSeMenorQue(altura, 1, "O campo Altura não pode ser menor ou igual a 0");
            Validacoes.ValidarSeMenorQue(largura, 1, "O campo Largura não pode ser menor ou igual a 0");
            Validacoes.ValidarSeMenorQue(profundidade, 1, "O campo profundidade não pode ser menor ou igual a 0");
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }

        public string DescricaoFormatada()
        {
            return $"LxAxP: {Largura} x {Altura} x {Profundidade}";
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}
