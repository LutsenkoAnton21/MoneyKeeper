using Microsoft.Extensions.Options;
using MoneyKeeper.Core.Entities;
using MoneyKeeper.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKeeper.Core.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationContext dbContext;
        public TransactionRepository(ApplicationContext databaseOptions)
        {
            dbContext = databaseOptions;
        }
        public void CreateTransaction(Transaction transaction)
        { 

        }

        public Transaction GetTransactionById(int transactionId)
        {
            return dbContext.Transactions.FirstOrDefault(x => x.TransactionId == transactionId);
        }
    }
}
