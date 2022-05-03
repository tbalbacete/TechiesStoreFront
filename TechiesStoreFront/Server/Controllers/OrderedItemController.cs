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

        //POST: api/OrderedItem
        [HttpPost]
        public async Task<IActionResult> Create(OrderedItemCreate model)
        {
            if (model == null) return BadRequest();

            bool wasSuccess = await _orderedItemService.CreateOrderedItemAsync(model);

            if (wasSuccess) return Ok();

            else return UnprocessableEntity();
        }

        //GET: api/OrderedItem
        [HttpGet]
        public async Task<List<OrderedItemListItem>> Index()
        {
            var items = await _orderedItemService.GetAllOrderedItemsAsync();

            return items.ToList();
        }

        //GET: api/OrderedItem/1
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderedItem(int id)
        {
            var orderedItem = await _orderedItemService.GetOrderedItemByIdAsync(id);

            if (orderedItem == null) return NotFound();

            return Ok(orderedItem);
        }

        // GET: api/OrderedItem/getAll/1
        [HttpGet("getAll/{transactionId}")]
        public async Task<List<OrderedItemListItem>> OrderedItems(int transactionId)
        {
            var items = await _orderedItemService.GetAllOrderedItemsByTransactionIdAsync(transactionId);

            return items.ToList();
        }

        //PUT: api/OrderedItem/1
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(int id, OrderedItemEdit model)
        {
            if (model == null || !ModelState.IsValid) return BadRequest();

            bool wasSuccess = await _orderedItemService.UpdateOrderedItemAsync(model);

            if(!wasSuccess) return BadRequest();

            return Ok();
        }

        //DELETE: api/OrderedItem/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var orderedItem = await _orderedItemService.GetOrderedItemByIdAsync(id);

            if (orderedItem == null) return NotFound();

            bool wasSuccessful = await _orderedItemService.DeleteOrderedItemAsync(id);

            if(!wasSuccessful) return BadRequest();

            return Ok();
        }

    }
}
