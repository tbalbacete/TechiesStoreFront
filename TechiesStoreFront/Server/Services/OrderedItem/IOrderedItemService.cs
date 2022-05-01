using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.OrderedItemModels;

namespace TechiesStoreFront.Server.Services.OrderedItem
{
    public interface IOrderedItemService
    {
        Task<bool> CreateOrderedItemAsync(OrderedItemCreate model);
        Task<IEnumerable<OrderedItemListItem>> GetAllOrderedItemsAsync();
        Task<OrderedItemDetail> GetOrderedItemByIdAsync(int itemId);
    }
}
