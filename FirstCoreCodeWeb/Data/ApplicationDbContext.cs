using FirstCoreCodeWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstCoreCodeWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        public DbSet<Category> Categories { get; set; }

    }
}
