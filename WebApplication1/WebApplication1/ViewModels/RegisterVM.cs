using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Surname { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
