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
    public class UsersController : ControllerBase
    {
        private readonly UserService _usersService;
        public UsersController(UserService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public IActionResult User(int userId)
        {
            var result = _usersService.GetUserById(userId);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Client(User user)
        {
            _usersService.CreateUser(user);
            return Ok();
        }
    }
}
