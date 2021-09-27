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
        private readonly DatabaseOptions _options;
        public TransactionRepository(IOptions<DatabaseOptions> databaseOptions)
        {
            _options = databaseOptions.Value;
        }
        public void CreateTransaction(Transaction transaction)
        { 

        }

        public Transaction GetTransactionById(int transactionId)
        {
            return new Transaction { Amount = 12345 };
        }
    }
}
