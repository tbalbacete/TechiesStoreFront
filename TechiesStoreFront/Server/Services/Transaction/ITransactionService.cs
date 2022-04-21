﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechiesStoreFront.Shared.Models.TransactionModels;

namespace TechiesStoreFront.Server.Services.Transaction
{
    public interface ITransactionService
    {
        Task<bool> CreateTransactionAsync(TransactionCreate model);
        Task<IEnumerable<TransactionListItem>> GetAllTransactionsAsync();
        Task<TransactionDetail> GetTransactionByIdAsync(int transactionId);
        Task<bool> DeleteTransactionAsync(int transactionId);
    }
}