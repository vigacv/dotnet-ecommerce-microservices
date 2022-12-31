using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityService
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                   {
                       ClientId = "shopping_mvc_client",
                       ClientName = "Shopping MVC Web App",
                       AllowedGrantTypes = GrantTypes.Hybrid,
                       RequirePkce = false,
                       AllowRememberConsent = false,
                       RedirectUris = new List<string>()
                       {
                           "https://localhost:5006/signin-oidc"
                       },
                       PostLogoutRedirectUris = new List<string>()
                       {
                           "https://localhost:5006/signout-callback-oidc"
                       },
                       ClientSecrets = new List<Secret>
                       {
                           new Secret("secret".Sha256())
                       },
                       AllowedScopes = new List<string>
                       {
                           IdentityServerConstants.StandardScopes.OpenId,
                           IdentityServerConstants.StandardScopes.Profile
                       }
                   }
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
            };
        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            {

            };
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
              new IdentityResources.OpenId(),
              new IdentityResources.Profile(),
            };
        public static List<TestUser> TestUsers =>
            new List<TestUser>
            {
            };
    }
}