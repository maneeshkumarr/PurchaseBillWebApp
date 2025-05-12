using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PurchaseBillWebApp.Models
{
    public class PurchaseContextFactory : IDesignTimeDbContextFactory<PurchaseContext>
    {
        public PurchaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PurchaseContext>();
            optionsBuilder.UseSqlite("Data Source=app.db");

            return new PurchaseContext(optionsBuilder.Options);
        }
    }
}
