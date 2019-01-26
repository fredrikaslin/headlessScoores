using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class PlayerModel
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string ClubId { get; set; }
    }
}
