using DependencyInjection.Models;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
