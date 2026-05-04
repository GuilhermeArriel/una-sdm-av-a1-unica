using Microsoft.EntityFrameworkCore;
using ValeAtivos324112890.Models;

namespace ValeAtivos324112890.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Equipamento> Equipamentos { get; set; }
    }
}