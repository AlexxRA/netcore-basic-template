using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }

    
}