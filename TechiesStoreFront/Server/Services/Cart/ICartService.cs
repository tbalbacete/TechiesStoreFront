using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechiesStoreFront.Server.Services.Cart
{
    public interface ICartService
    {
        void AddProductToCart(int productId);
    }
}
