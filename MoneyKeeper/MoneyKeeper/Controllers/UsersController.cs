using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    /// <summary>
    /// lol kek controller for User Manager
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("[controller]")]  
    public class UsersController : ControllerBase
    {
        private readonly UserService _usersService;
        public UsersController(UserService usersService)
        {
            _usersService = usersService;
        }
        /// <summary>
        /// приймає юзера
        /// </summary>
        /// <param name="userId"> Id юзера
        /// </param>
        /// <returns></returns>             
        [HttpGet]
        [AllowAnonymous]
        public IActionResult User(string userId)
        {
            var result = _usersService.GetUserById(userId);
            return Ok(result);
        }
        /// <summary>
        /// создає юзера
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <response code="201">Create dgbjlgdbbljgbb</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public IActionResult User(User user)
        {
            _usersService.CreateUser(user);
            return Ok();
        }
    }
}
