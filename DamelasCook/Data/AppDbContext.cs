using DamelasCook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DamelasCook.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }    
     public DbSet<Categoria> Categorias  { get; set; }
     public DbSet<Comentario> Comentarios { get; set; }
     public DbSet<Ingrediente> Ingredientes  { get; set; }
     public DbSet<Receita> Receitas  { get; set; }
     public DbSet<ReceitaIngrediente> ReceitaIngredientes  { get; set; }
     public DbSet<Usuario> Usuarios  { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ReceitaIngrediente>()
             .HasKey(ri => new { ri.ReceitaId, ri.IngredienteId });
    }

}
   
    