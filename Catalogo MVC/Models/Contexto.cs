using Microsoft.EntityFrameworkCore;
using SQLitePCL; // Adicione esta linha

namespace Catalogo_MVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            Batteries.Init(); // Inicializa o SQLite
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
    }
}
