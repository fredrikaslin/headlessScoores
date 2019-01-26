using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models.Identity
{
    public class UserManager : UserManager<UserAccount, Guid>
    {
        public UserManager(IUserStore<UserAccount, Guid> store) : base(store)
        {
            UserValidator = new UserValidator<UserAccount, Guid>(this);
            PasswordValidator = new PasswordValidator();
            PasswordHasher = new PasswordHasher();

        }

        internal Club GetClub(string clubName)
        {
            throw new NotImplementedException();
        }
    }
}
