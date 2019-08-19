using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopPt1.Models
{
    public class NewUser
    {
        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0 - 9a - zA - Z][-\w] *[0 - 9a - zA - Z] *\.)+[a-zA-Z0-9]{2,17})$")]
        public string Email { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$")]
        public string PhoneNumber { get; set; }

        [StringLength(30, ErrorMessage = "Must be between 3 and 30 characters", MinimumLength = 3)]
        [Required]
        public string Password { get; set; }
    }
}
