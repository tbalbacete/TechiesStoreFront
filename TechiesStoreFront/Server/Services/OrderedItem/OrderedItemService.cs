using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.OrderedItemModels;

namespace TechiesStoreFront.Server.Services.OrderedItem
{
    public class OrderedItemService : IOrderedItemService
    {
        public Task<bool> CreateOrderedItemAsync(OrderedItemCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderedItemListItem>> GetAllOrderedItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderedItemDetail> GetOrderedItemByIdAsync(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
