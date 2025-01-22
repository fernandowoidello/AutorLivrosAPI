using AutorLivrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AutorLivrosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) // opcoes de conexoes<opcoes utilizadas> (options-informacoes contidas)
        {

        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }

    }
}
