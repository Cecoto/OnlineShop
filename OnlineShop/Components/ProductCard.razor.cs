namespace OnlineShop.Components
{
    using Microsoft.AspNetCore.Components;
    using OnlineShop.Data;

    public partial class ProductCard
    {
        [Parameter]
        public Product Product { get; set; } = null!;
     
    }
}
