using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.ProductModels;

namespace TechiesStoreFront.Server.Services.Product
{
    public interface IProductService
    {
        Task<bool> CreateProductAsync(ProductCreate model);
        Task<IEnumerable<ProductListItem>> GetAllProductsAsync();
        Task<IEnumerable<ProductDetail>> GetAllProductsByCategoryIdAsync(int categoryId);
        Task<ProductDetail> GetProductByIdAsync(int productId);
        Task<bool> UpdateProductAsync(ProductEdit model);
        Task<bool> DeleteProductAsync(int productId);
    }
}
