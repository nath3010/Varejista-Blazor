using Microsoft.EntityFrameworkCore;

namespace VarejistaProduto.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
