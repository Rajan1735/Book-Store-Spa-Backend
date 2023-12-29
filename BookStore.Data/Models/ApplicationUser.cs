using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.Models
{
    public class ApplicationUser:IdentityUser
    {
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
