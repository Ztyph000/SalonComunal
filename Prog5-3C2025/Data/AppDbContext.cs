using Microsoft.EntityFrameworkCore;
using Prog5_3C2025.Models;

namespace Prog5_3C2025.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
       { 
        
       }
        public DbSet<TablaPrueba> TablaPrueba { get; set; } = default!;
    }
}