using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKeeper.Core.Entities
{
    public class Category
    {
        public int CatedoryId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string CategoryTipe { get; set; }
    }
}
