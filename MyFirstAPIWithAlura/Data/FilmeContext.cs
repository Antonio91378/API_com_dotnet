using Microsoft.EntityFrameworkCore;
using MyFirstAPIWithAlura.Controllers;

namespace MyFirstAPIWithAlura.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Filme> Filmes { get; set; }
    }
}