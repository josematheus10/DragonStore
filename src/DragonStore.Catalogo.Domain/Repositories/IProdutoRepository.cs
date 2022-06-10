using DragonStore.Core.Data;

namespace DragonStore.Catalogo.Domain;

public interface IProdutoRepository : IRepository<Produto>
{
    Task<IEnumerable<Produto>> ObterTodos();
    Task<Produto> ObterPorId(Guid id);
    Task<IEnumerable<Produto>> ObterPorCategoria(Guid id);
    Task<IEnumerable<Categoria>> ObterCategorias();

    void Adicionar(Produto produto);
    void Atualizar(Produto produto);

    void Adicionar(Categoria categoria);
    void Atualizar(Categoria categoria);
}