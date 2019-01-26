using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class UserAccount //: IUser<Guid>
    {
        public UserAccount()
        {
            Players = new HashSet<Player>();
        }

        public virtual Guid Id { get; set; }
        public virtual string UserName { get; set; } //Emailaddress
        public virtual string PasswordHash { get; set; }
        public virtual Guid? ResetPasswordToken { get; set; }
        public virtual DateTime? ResetPasswordTimer { get; set; }
        public virtual ISet<Player> Players { get; set; }
    }
}
