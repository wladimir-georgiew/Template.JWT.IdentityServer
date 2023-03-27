using System.Linq;
using System.Security.Claims;

namespace API.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetId(this ClaimsPrincipal user) =>
            user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
    }
}
