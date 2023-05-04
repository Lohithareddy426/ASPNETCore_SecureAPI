using Microsoft.AspNetCore.Identity;
using SecureAPI.Data;
using SecureAPI.Models;

namespace SecureAPI.Services
{
    public class ApiKeyService
    {
        private readonly UsersIdentityDbContext _context;

        public ApiKeyService(UsersIdentityDbContext context)
        {
            _context = context;
        }

        public UserApiKey CreateApiKey(IdentityUser user)
        {
            var newApiKey = new UserApiKey
            {
                User = user,
                Value = GenerateApiKeyValue()
            };

            _context.UserApiKeys.Add(newApiKey);

            _context.SaveChanges();

            return newApiKey;
        }

        private string GenerateApiKeyValue() =>
            $"{Guid.NewGuid().ToString()}-{Guid.NewGuid().ToString()}";
    }
}
