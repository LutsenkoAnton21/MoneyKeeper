using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoneyKeeper.Core.Entities;
using MoneyKeeper.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyKeeper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionService _transactionService;
        public TransactionsController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public IActionResult Transaction(int transactionId)
        {
            var result = _transactionService.GetTransactionById(transactionId);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Transaction(Transaction transaction)
        {
            _transactionService.CreateTransaction(transaction);
            return Ok();
        }
    }
}
