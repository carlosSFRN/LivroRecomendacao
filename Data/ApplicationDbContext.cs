using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LivroRecomendacao.Models;

namespace LivroRecomendacao.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LivroRecomendacao.Models.Livro>? Livro { get; set; }
        public DbSet<LivroRecomendacao.Models.Autor>? Autor { get; set; }
        public DbSet<LivroRecomendacao.Models.Genero>? Genero { get; set; }
        public DbSet<LivroRecomendacao.Models.Favorito>? Favorito { get; set; }
    }
}