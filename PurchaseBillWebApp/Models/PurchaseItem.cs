namespace PurchaseBillWebApp.Models
{
    public class PurchaseItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal Rate { get; set; }
        public int Quantity { get; set; }
    }
}
