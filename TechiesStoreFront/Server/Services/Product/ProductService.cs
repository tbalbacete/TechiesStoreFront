using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.ProductModels;

namespace TechiesStoreFront.Server.Services.Product
{
    public class ProductService : IProductService
    {
        public Task<bool> CreateProductAsync(ProductCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductListItem>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDetail> GetProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductAsync(ProductEdit model)
        {
            throw new NotImplementedException();
        }
    }
}
