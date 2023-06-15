using VarejistaProduto.Shared.Model;

namespace VarejistaProduto.Server.Repository.IRepository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task UpdateAsync(Produto entity);
    }
}
