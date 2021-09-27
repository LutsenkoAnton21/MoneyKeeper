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
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoriesController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Category(int categoryId)
        {
            var result = _categoryService.GetCategoryById(categoryId);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Category(Category category)
        {
            _categoryService.CreateCategory(category);
            return Ok();
        }
    }
}
