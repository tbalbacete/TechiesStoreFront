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
        Task<IEnumerable<OrderedItemListItem>> GetAllOrderedItemsByTransactionIdAsync(int transactionId);
        Task<OrderedItemDetail> GetOrderedItemByIdAsync(int itemId);
        Task<bool> UpdateOrderedItemAsync(OrderedItemEdit model);
        Task<bool> DeleteOrderedItemAsync(int id);

    }
}
