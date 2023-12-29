using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage =" user name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = " password is required")]
        public string? Password { get; set; }
    }
}
