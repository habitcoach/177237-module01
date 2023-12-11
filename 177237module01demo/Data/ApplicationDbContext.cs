using _177237module01demo.Model;
using Microsoft.EntityFrameworkCore;

namespace _177237module01demo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
