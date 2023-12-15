namespace OnlineShop.Data
{
    public class Product
    {
        public int? ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public DateTime DeliveryOn { get; set; }

        public string ImageUrl { get; set; } = null!;
    }
}
