using Microsoft.EntityFrameworkCore;

namespace PurchaseBillWebApp.Models
{
    public class PurchaseContext : DbContext
    {
        public PurchaseContext(DbContextOptions<PurchaseContext> options)
            : base(options)
        {
        }

        public DbSet<PurchaseItem> PurchaseItems { get; set; }
    }
}
