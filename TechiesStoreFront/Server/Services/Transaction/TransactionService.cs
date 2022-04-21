using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.TransactionModels;

namespace TechiesStoreFront.Server.Services.Transaction
{
    public class TransactionService : ITransactionService
    {
        public Task<bool> CreateTransactionAsync(TransactionCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTransactionAsync(int transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransactionListItem>> GetAllTransactionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TransactionDetail> GetTransactionByIdAsync(int transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
