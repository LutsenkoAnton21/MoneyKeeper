using Microsoft.Extensions.Options;
using MoneyKeeper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyKeeper.Core.Interfaces;

namespace MoneyKeeper.Core.Repositories 
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseOptions _options;
        public CategoryRepository(IOptions<DatabaseOptions> databaseOptions)
        {
            _options = databaseOptions.Value;
        }
        public void CreateCategory(Category category)
        { ///192.13.123.4 connection
            //INSERT INTO CLIENT VALUES .....
        }

        public Category GetCategoryById(int categoryId)
        {
            ///192.13.123.4 connection
            /////SELECT * FROM CLIENT WHERE ClientId = @clientId
            return new Category { Name = "Test" };
        }
    }
}
