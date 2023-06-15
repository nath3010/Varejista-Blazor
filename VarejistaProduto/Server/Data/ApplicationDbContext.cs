using Microsoft.EntityFrameworkCore;
using VarejistaProduto.Shared.Model;

namespace VarejistaProduto.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    Id = 1,
                    Nome = "Banana Nanica",
                    Descricao = "A Banana Nanica vai bem pura mesmo, banana com aveia, banana à milanesa e também pode ser utilizada para o preparo de bolos, tortas, entre outros. Fonte: Conquiste Sua Vida",
                    Quantidade = 20,
                    Tipo = "Orgânico",
                    PrecoVenda = 06.30m,
                    DataCadastro = DateTime.Now,
                },
                new Produto
                {
                    Id = 2,
                    Nome = "Uva Thompsom",
                    Descricao = "A Uva Thompson é uma das queridinhas espécies de uva sem sementes. Sua origem é turca ou grega, mas devido ao clima com muito sol e chuvas esporádicas, seu cultivo se adaptou muito bem ao clima brasileiro.",
                    Quantidade = 12,
                    Tipo = "Não orgânico",
                    PrecoVenda = 12.30m,
                    DataCadastro = DateTime.Now,
                },
                new Produto
                {
                    Id = 3,
                    Nome = "Batata Doce",
                    Descricao = "A batata doce é uma fonte de carboidrato saudável, famosa por ser o alimento predileto de quem quer ganhar massa muscular.",
                    Quantidade = 13,
                    Tipo = "Orgânico",
                    PrecoVenda = 05.40m,
                    DataCadastro = DateTime.Now,
                },
                new Produto
                {
                    Id = 4,
                    Nome = "Ovos Caipira",
                    Descricao = "Os Ovos Vermelhos Caipira Ito Vita são frescos, produzidos por galinhas criadas em espaços adequados aos seus comportamentos naturais como ciscar o chão, bater asas e se empoleirar.",
                    Quantidade = 6,
                    Tipo = "Orgânico",
                    PrecoVenda = 23.30m,
                    DataCadastro = DateTime.Now,
                },
                new Produto
                {
                    Id = 5,
                    Nome = "Tomate Italiano",
                    Descricao = "O tomate italiano tem uma consistência mais encorpada em relação aos outros tipos existentes.",
                    Quantidade = 30,
                    Tipo = "Não orgânico",
                    PrecoVenda = 10.30m,
                    DataCadastro = DateTime.Now,
                },
                new Produto
                {
                    Id = 6,
                    Nome = "Batata",
                    Descricao = "A batata é um alimento presente diariamente na mesa dos brasileiros, um alimento de fácil cultivo, existem variedades de batatas, com diferentes tamanhos e cores.",
                    Quantidade = 40,
                    Tipo = "Não orgânico",
                    PrecoVenda = 06.34m,
                    DataCadastro = DateTime.Now,
                });
        }
    }
}
