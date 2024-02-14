using Domaine.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class SortieContext : DbContext
    {
        public DbSet<Sortie> Sortie { get; set; }

        public SortieContext(DbContextOptions<SortieContext> options) : base(options) { }
    }
}
