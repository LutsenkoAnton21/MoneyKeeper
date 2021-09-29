using MoneyKeeper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKeeper.Core.Interfaces
{
    public interface ITransactionRepository
    {
        void CreateTransaction(Transaction transaction);
        Transaction GetTransactionById(int transactionId);
    }
}
