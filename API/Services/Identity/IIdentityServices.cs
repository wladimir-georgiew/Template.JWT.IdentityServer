using API.Data.Models;

namespace API.Services.Identity
{
    public interface IIdentityServices
    {
        public string GetEncryptedJWT(User user, string secret);
    }
}
