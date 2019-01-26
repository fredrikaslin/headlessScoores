using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class UserModel
    {
        public string ClubId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
