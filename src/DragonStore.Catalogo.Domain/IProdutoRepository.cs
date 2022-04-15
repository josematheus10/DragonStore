using DragonStore.Core.Data;

namespace DragonStore.Catalogo.Domain;

public interface IProdutoRepository : IRepository<Produto>
{
    Task<IEnumerable<Produto>> ObterTodos();

    Task<Produto> ObterPorId(Guid id);

    Task<IEnumerable<Produto>> ObterPorCategoria(int id);

    Task<IEnumerable<Categoria>> ObterVategorias();

    void Adicionar(Produto produto);
    void Atualizar(Produto produto);

    void Adicionar(Categoria categoria);
    void Atualizar(Categoria categoria);
}