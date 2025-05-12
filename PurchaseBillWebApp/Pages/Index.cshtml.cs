using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseBillWebApp.Models;

namespace PurchaseBillWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PurchaseContext _context;

        public IndexModel(PurchaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PurchaseItem NewItem { get; set; } = new();

        public List<PurchaseItem> Items { get; set; } = new();

        public void OnGet()
        {
            Items = _context.PurchaseItems.ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.PurchaseItems.Add(NewItem);
            _context.SaveChanges();

            return RedirectToPage();
        }

        public IActionResult OnPostClear()
        {
            var allItems = _context.PurchaseItems.ToList();
            _context.PurchaseItems.RemoveRange(allItems);
            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
