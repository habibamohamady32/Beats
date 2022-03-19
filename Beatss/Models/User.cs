using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Beatss.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid Username")]
        public string Username { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Invalid Password", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}