namespace OnlineShop.Services.Contracts
{
    using OnlineShop.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IProductService
    {
        Task<Product[]> GetAllProductsAsync();
    }
}
