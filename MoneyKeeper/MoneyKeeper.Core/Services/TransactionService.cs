using MoneyKeeper.Core.Entities;
using MoneyKeeper.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKeeper.Core.Services
{
    public class TransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public void CreateTransaction(Transaction transaction)
        {
            _transactionRepository.CreateTransaction(transaction);
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return _transactionRepository.GetTransactionById(transactionId);
        }
    }
}
