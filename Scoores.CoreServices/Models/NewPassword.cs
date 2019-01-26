using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class NewPassword
    {
        public Guid PlayerId { get; set; }
        public Guid Token { get; set; }
        public string Password { get; set; }
    }
}
