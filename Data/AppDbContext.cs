using Microsoft.EntityFrameworkCore;
using ProjetoDWA.Models;

namespace ProjetoDWA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Personagem> DWA { get; set; }
    }
}