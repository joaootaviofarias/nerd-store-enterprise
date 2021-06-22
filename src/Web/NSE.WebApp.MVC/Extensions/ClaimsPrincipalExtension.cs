using System;
using System.Security.Claims;

namespace NSE.WebApp.MVC.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            return GetClaimValueByName(principal, "sub");
        }

        public static string GetUserEmail(this ClaimsPrincipal principal)
        {
            return GetClaimValueByName(principal, "email");
        }

        public static string GetUserToken(this ClaimsPrincipal principal)
        {
            return GetClaimValueByName(principal, "JWT");
        }

        private static string GetClaimValueByName(ClaimsPrincipal principal, string name)
        {
            if (principal is null)
            {
                throw new ArgumentException(nameof(principal));
            }

            var claim = principal.FindFirst(name);
            return claim?.Value;
        }
    }
}
