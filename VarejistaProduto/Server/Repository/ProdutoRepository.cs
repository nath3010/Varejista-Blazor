using VarejistaProduto.Server.Data;
using VarejistaProduto.Server.Repository.IRepository;

namespace VarejistaProduto.Server.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        private readonly ApplicationDbContext _db;

        public ProdutoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task UpdateAsync(Produto entity)
        {
            _db.Produtos.Update(entity);
            await _db.SaveChangesAsync();

        }
    }
}
