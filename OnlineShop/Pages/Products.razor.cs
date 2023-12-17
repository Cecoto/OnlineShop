namespace OnlineShop.Pages
{
    using Microsoft.AspNetCore.Components;
    using OnlineShop.Data;
    using System.Collections.Generic;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public partial class Products
    {
        [Inject]
        public HttpClient? Http { get; set; }

        private ICollection<Product>? products;

        protected override async Task OnInitializedAsync()
        {
            products = await Http.GetFromJsonAsync<Product[]>("sample-data/products.json");
        }

    }
}