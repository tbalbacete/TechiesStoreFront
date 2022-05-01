using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Server.Data;
using TechiesStoreFront.Server.Models;
using TechiesStoreFront.Shared.Models.OrderedItemModels;

namespace TechiesStoreFront.Server.Services.OrderedItem
{
    public class OrderedItemService : IOrderedItemService
    {
        private readonly ApplicationDbContext _context;

        public OrderedItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateOrderedItemAsync(OrderedItemCreate model)
        {
            var orderedItemEntity = new OrderedItemEntity
            {
                TransactionId = model.TransactionId,
                ProductId = model.ProductId,
                QuantityOrdered = model.QuantityOrdered
            };

            _context.OrderedItems.Add(orderedItemEntity);
            var numberofChanges = await _context.SaveChangesAsync();

            return numberofChanges == 1;
        }

        public async Task<IEnumerable<OrderedItemListItem>> GetAllOrderedItemsAsync()
        {
            var orderedItemQuery = _context.OrderedItems.Select(i => new OrderedItemListItem
            {
                TransactionId = i.TransactionId,
                ProductId = i.ProductId,
                QuantityOrdered = i.QuantityOrdered
            });

            return await orderedItemQuery.ToListAsync();
        }

        public async Task<OrderedItemDetail> GetOrderedItemByIdAsync(int itemId)
        {
            var orderedItemEntity = await _context.OrderedItems.FirstOrDefaultAsync(i => i.Id == itemId);

            if (orderedItemEntity == null) return null;

            var detail = new OrderedItemDetail
            {
                Id = orderedItemEntity.Id,
                TransactionId = orderedItemEntity.TransactionId,
                ProductId = orderedItemEntity.ProductId,
                QuantityOrdered = orderedItemEntity.QuantityOrdered
            };

            return detail;
        }
    }
}
