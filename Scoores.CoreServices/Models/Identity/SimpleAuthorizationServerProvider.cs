using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models.Identity
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            string activeClubId = context.Parameters.Where(f => f.Key == "ActiveClubId").Select(f => f.Value).SingleOrDefault()[0];
            context.OwinContext.Set<string>("ActiveClubId", activeClubId);

            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            UserAccount user;
            Player player;
            string clubId = context.OwinContext.Get<string>("ActiveClubId");

            using (var session = NhHelper.NhHelper.OpenSession())
            {
                using (IdentityStore identityStore = new IdentityStore(session))
                {
                    using (UserManager userManager = new UserManager(NhHelper.NhHelper.Users))
                    {
                        user = await userManager.FindAsync(context.UserName, context.Password);

                        if (user == null)
                        {
                            context.SetError("invalid_grant", " Login failed - Email or password is incorrect.");
                            return;
                        }

                        player = user.Players.FirstOrDefault(x => x.Club.Id == new Guid(clubId));

                        if (player == null)
                        {
                            context.SetError("invalid_grant", "User does not exist in the selected club.");
                            return;
                        }
                    }
                }
            }
            var props = new AuthenticationProperties(new Dictionary<string, string>
            {
                {
                    "userName", player.PlayerName
                },
                {
                    "playerId", player.Id.ToString()
                }
            });
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("clubId", clubId));
            identity.AddClaim(new Claim("role", "user"));

            var ticket = new AuthenticationTicket(identity, props);


            SetClubCookie(context, clubId);

            context.Validated(ticket);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        private void SetClubCookie(OAuthGrantResourceOwnerCredentialsContext context, string clubId)
        {
            if (string.IsNullOrEmpty(clubId)) return;

            context.Response.Cookies.Append("FavClub", clubId, new CookieOptions { HttpOnly = false });
        }
    }
}
