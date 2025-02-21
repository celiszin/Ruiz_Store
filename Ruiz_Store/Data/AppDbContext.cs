using Ruiz_Store.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFramework

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(DbContextOpition<AppDbContext> options) : base(options)
    {
    }

        public DbSet<Categoria> Categoria  { get; set; }
        public DbSet<Produtos> Produtos  { get; set; }
        public DbSet<ProdutoFotos> ProdutoFotos { get; set; }
        public DbSet<Usuarios> Usuarios {get; set;}
}