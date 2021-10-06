using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKeeper.Core.Models
{
    [Microsoft.EntityFrameworkCore.Keyless]
    public class RegisterUserModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        //[DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

    }
}
