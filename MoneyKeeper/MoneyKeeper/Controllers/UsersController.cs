using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoneyKeeper.Core;
using MoneyKeeper.Core.Entities;
using MoneyKeeper.Core.Models;
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
        public UsersController(UserService usersService, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _usersService = usersService;
            _userManager = userManager;
            _signInManager = signInManager;
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
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[AllowAnonymous]
        //[HttpPost]
        //public IActionResult User(User user)
        //{
        //    _usersService.CreateUser(user);
        //    return Ok();
        //}

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        //public UsersController(UserManager<User> userManager, SignInManager<User> signInManager)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}
        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return Ok();
        //}
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> Register(User model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        User user = new User { Email = model.Email, UserName = model.Email };
        //        var result = await _userManager.CreateAsync(user);
        //    }
        //    return Ok(model);
        //}
       
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterUserModel model)
        {
            
            User user = new User { Email = model.Email, UserName = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // установка куки
                await _signInManager.SignInAsync(user, false);
                return Ok();
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Ok(model);
        }
    }
}
