using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModernGents_1.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Brugernavn")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Husk password")]
        public bool RememberMe { get; set; }
    }
}