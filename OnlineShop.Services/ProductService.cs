namespace OnlineShop.Services
{
    using Microsoft.AspNetCore.Components;
    using OnlineShop.Data;
    using OnlineShop.Services.Contracts;
    using System.Net.Http.Json;
    using System.Threading.Tasks;
    using static System.Net.WebRequestMethods;

    public class ProductService : IProductService
    {
        

        public async Task<Product[]> GetAllProductsAsync()
        {
            return await Http.GetFromJsonAsync<Product[]>("sample-data/products.json");
        }
    }
}
