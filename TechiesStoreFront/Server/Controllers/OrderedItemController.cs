using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Server.Services.OrderedItem;
using TechiesStoreFront.Shared.Models.OrderedItemModels;

namespace TechiesStoreFront.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedItemController : ControllerBase
    {
        private readonly IOrderedItemService _orderedItemService;

        public OrderedItemController(IOrderedItemService orderedItemService)
        {
            _orderedItemService = orderedItemService;
        }

        //May not need
        private void SetTransactionID(int transactionId)
        {
            _orderedItemService.SetTransactionId(transactionId);
        }

        //may not need
        private void SetProductId(int productId)
        {
            _orderedItemService.SetProductId(productId);
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderedItemCreate model)
        {
            if (model == null) return BadRequest();

            bool wasSuccess = await _orderedItemService.CreateOrderedItemAsync(model);

            if (wasSuccess) return Ok();

            else return UnprocessableEntity();
        }

        [HttpGet]
        public async Task<List<OrderedItemListItem>> Index()
        {
            var items = await _orderedItemService.GetAllOrderedItemsAsync();

            return items.ToList();
        }

        [HttpGet]
        public async Task<IActionResult> OrderedItem(int id)
        {
            var orderedItem = await _orderedItemService.GetOrderedItemByIdAsync(id);

            if (orderedItem == null) return NotFound();

            return Ok(orderedItem);
        }
    }
}
