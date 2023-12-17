namespace OnlineShop.Components
{
    using Microsoft.AspNetCore.Components;
    using OnlineShop.Data;
    using Telerik.Blazor.Components;
    using Telerik.Blazor;
    using Telerik.SvgIcons;

    public partial class ProductCard
    {
        [Parameter]
        public Product Product { get; set; } = null!;

        public TelerikNotification NotificationReference { get; set; } = null!;

        public void AddNotification()
        {
            NotificationReference.Show(new NotificationModel()
            {
                Text = "Product added to your shopping card.",
                CloseAfter = 3000,
            }) ;
        }
    }
}
