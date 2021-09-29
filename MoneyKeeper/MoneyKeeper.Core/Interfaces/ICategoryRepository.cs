using MoneyKeeper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKeeper.Core.Interfaces
{
    public interface ICategoryRepository
    {
        void CreateCategory(Category category);
        Category GetCategoryById(int categoryId);
    }
}
