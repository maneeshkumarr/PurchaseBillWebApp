using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseBillWebApp.Models;

namespace PurchaseBillWebApp.Pages
{
    public class InvoiceModel : PageModel
    {
        private readonly PurchaseContext _context;

        public InvoiceModel(PurchaseContext context)
        {
            _context = context;
        }

        public List<PurchaseItem> Items { get; set; } = new();
        public decimal SubTotal { get; set; }
        public decimal GSTAmount { get; set; }
        public decimal GrandTotal { get; set; }

        public void OnGet()
        {
            Items = _context.PurchaseItems.ToList();
            SubTotal = Items.Sum(i => i.Rate * i.Quantity);
            GSTAmount = SubTotal * 0.18M;
            GrandTotal = SubTotal + GSTAmount;
        }
    }
}
