using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoneyKeeper.Core;
using MoneyKeeper.Core.Entities;
using MoneyKeeper.Core.Models;
using MoneyKeeper.Core.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;


namespace MoneyKeeper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly UserService _usersService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, UserService usersService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _usersService = usersService;
        }
        //[HttpGet]
        //public async Task<IActionResult> Register(string email)
        //{
        //    var result = _usersServ.GetUserById(email);
        //    return Ok(result);
        //}

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser(RegisterUserModel model)
        {

            User user = new User { Email = model.Email, UserName = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //// установка куки
                //await _signInManager.SignInAsync(user, false);
                //return Ok();
                //var identity = GetIdentity(username, password);
                //var now = DateTime.UtcNow;
                //var jwt = new JwtSecurityToken(
                //   issuer: AuthOptions.ISSUER,
                //   audience: AuthOptions.AUDIENCE,
                //   notBefore: now,
                //   claims: identity.Claims,
                //   expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                //   signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
                //var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
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
        //[HttpPost("Login")]
        //public async Task<IActionResult> Login(string email)
        //{

        //    var result = _usersService.GetUserById(email);
        //    await _signInManager.SignInAsync(result, false);
        //    return Ok(result);
        //}

        [HttpPost("Login")]       
        public async Task<IActionResult> Login([FromBody]LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, false);
                if (result.Succeeded)
                {                                    
                    return Ok();                   
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }
            return Ok(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Logout()
        //{
        //    // удаляем аутентификационные куки
        //    await _signInManager.SignOutAsync();
        //    return Ok();
        //}

    }
}
