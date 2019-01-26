using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models.Identity
{
    public class SignInManager : SignInManager<UserAccount, Guid>
    {
        public SignInManager(UserManager<UserAccount, Guid> userManager, IAuthenticationManager authenticationManager)
                     : base(userManager, authenticationManager) { }

        public void SignOut()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}
