using DragonStore.Core.DomainObjects;

namespace DragonStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; }
        public string Descricao { get; }

        public ICollection<Produto> Produtos { get; set; }

        protected Categoria() { }

        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
            Validar();
        }

        public override string ToString()
        {
            return Nome;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome da categoria não pode estar vazio");
            Validacoes.ValidarSeVazio(Descricao, "O campo Descrição da categoria não pode estar vazio");
        }
    }
}
