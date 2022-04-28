using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Server.Data;
using TechiesStoreFront.Server.Models;
using TechiesStoreFront.Server.Services.Product;
using TechiesStoreFront.Shared.Models.ProductModels;

namespace TechiesStoreFront.Server.Services.Cart
{
    public class CartService : ICartService
    {
        public List<ProductEntity> SelectedItems { get; set; } = new ();

        private readonly ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddProductToCart(int productId)
        {
            var product = _context.Products.First(p => p.Id == productId);

            if (SelectedItems.Contains(product) is false)
            {
                SelectedItems.Add(product);
            }
        }
    }
}
