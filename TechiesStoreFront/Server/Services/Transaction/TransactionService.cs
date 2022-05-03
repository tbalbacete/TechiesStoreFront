using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Server.Data;
using TechiesStoreFront.Server.Models;
using TechiesStoreFront.Shared.Models.TransactionModels;

namespace TechiesStoreFront.Server.Services.Transaction
{
    public class TransactionService : ITransactionService
    {
        private readonly ApplicationDbContext _context;
        private string _userId;

        public TransactionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateTransactionAsync(TransactionCreate model)
        {
            var transactionEntity = new TransactionEntity
            {
                UserId = _userId,
                AmountSpent = model.AmountSpent,
                DateofTransaction = DateTime.Now
            };

            _context.Transactions.Add(transactionEntity);
            var numberofChanges = await _context.SaveChangesAsync();

            return numberofChanges == 1;
        }


        public async Task<IEnumerable<TransactionListItem>> GetAllTransactionsForUserAsync()
        {
            var transactionQuery = _context.Transactions.Where(t => t.UserId == _userId)
                .Select(t => new TransactionListItem
                {
                    Id = t.Id,
                    AmountSpent = t.AmountSpent,
                    DateOfTransaction = t.DateofTransaction
                });

            return await transactionQuery.ToListAsync();
        }

        public async Task<IEnumerable<TransactionListItem>> GetAllTransactionsAsync()
        {
            var transactionQuery = _context.Transactions.Select(t => new TransactionListItem
                {
                    Id = t.Id,
                    UserId = t.UserId,
                    AmountSpent = t.AmountSpent,
                    DateOfTransaction = t.DateofTransaction
                });

            return await transactionQuery.ToListAsync();
        }

        public async Task<TransactionDetail> GetTransactionByIdAsync(int transactionId)
        {
            var transactionEntity = await _context.Transactions.FirstOrDefaultAsync(t => t.Id == transactionId && t.UserId == _userId);

            if (transactionEntity == null) return null;

            var transactionDetail = new TransactionDetail
            {
                Id = transactionEntity.Id,
                AmountSpent = transactionEntity.AmountSpent,
                DateOfTransaction = transactionEntity.DateofTransaction
            };

            return transactionDetail;
        }

        public async Task<TransactionDetail> GetLastTransactionAsync()
        {
            var transactionEntity = _context.Transactions.OrderByDescending(t => t.Id).First();

            if (transactionEntity == null) return null;

            var transactionDetail = new TransactionDetail
            {
                Id = transactionEntity.Id,
                AmountSpent = transactionEntity.AmountSpent,
                DateOfTransaction = transactionEntity.DateofTransaction
            };

            return transactionDetail;
        }

        public async Task<bool> DeleteTransactionAsync(int transactionId)
        {
            var transactionEntity = await _context.Transactions.FindAsync(transactionId);

            //if (transactionEntity?.UserId != _userId) return false;

            _context.Transactions.Remove(transactionEntity);

            return await _context.SaveChangesAsync() == 1;
        }

        public void SetUserId(string userId) => _userId = userId;

        
    }
}
