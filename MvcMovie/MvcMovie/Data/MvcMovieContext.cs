using Microsoft.EntityFrameworkCore;

namespace MvcProduct.Models
{
    public class MvcProductContext : DbContext
    {
        public MvcProductContext (DbContextOptions<MvcProductContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProduct.Models.Product> Products { get; set; }
    }
}
