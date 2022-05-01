using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TechiesStoreFront.Server.Models;
using TechiesStoreFront.Server.Services.Transaction;
using TechiesStoreFront.Shared.Models.TransactionModels;

namespace TechiesStoreFront.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        private string GetUserId()
        {
            string userIdClaim = User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value;

            if (userIdClaim == null) return null;

            return userIdClaim;
        }

        public bool SetUserIdInService()
        {
            var userId = GetUserId();
            if (userId == null) return false;

            _transactionService.SetUserId(userId);

            return true;
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransactionCreate model)
        {
            if (model == null) return BadRequest();
            if (!SetUserIdInService()) return Unauthorized();

            bool wasSuccessful = await _transactionService.CreateTransactionAsync(model);

            if (wasSuccessful) return Ok();

            else return UnprocessableEntity();
        }

        [HttpGet]
        public async Task<List<TransactionListItem>> Index()
        {
            if (!SetUserIdInService()) return new List<TransactionListItem>();

            var transactions = await _transactionService.GetAllTransactionsAsync();

            return transactions.ToList();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Transaction(int id)
        {
            if (!SetUserIdInService()) return Unauthorized();

            var transaction = await _transactionService.GetTransactionByIdAsync(id);

            if (transaction == null) return NotFound();

            return Ok(transaction);
        }

        [HttpGet("last")]
        public async Task<TransactionDetail> LastTransaction()
        {
            if (!SetUserIdInService()) return null;

            var transaction = await _transactionService.GetLastTransactionAsync();

            if (transaction == null) return null;

            return transaction;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!SetUserIdInService()) return Unauthorized();

            var transaction = await _transactionService.GetTransactionByIdAsync(id);

            if (transaction == null) return NotFound();

            bool wasSuccessful = await _transactionService.DeleteTransactionAsync(id);

            if (!wasSuccessful) return BadRequest();

            return Ok();
        }
    }
}
