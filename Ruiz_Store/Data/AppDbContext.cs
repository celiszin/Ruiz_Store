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

        protected override void OnModelCreating(ModelBuild builder)
        {
            base.OnModelCreating(builder);

            #region Definindo nomes de Identity
            builder.Entity<IdentityUser>().ToTable("Usuario");
            builder.Entity<IdentityRole>().ToTable("Perfil");
            builder.Entity<IdentityUserRole<string>>().ToTable("Usuario_perfil");
            builder.Entity<IdentityUserClaim<string>>().ToTable("Usuario_regra");
            builder.Entity<IdentityUserLogin<string>>().ToTable("Usuario_login");
            builder.Entity<IdentityUserToken<string>>().ToTable("Usuario_token");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("perfil_regra");
            #endregion
        } 
}