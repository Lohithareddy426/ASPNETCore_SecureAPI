using System.ComponentModel.DataAnnotations;

namespace SecureAPI.Models.TokenAuthModels
{
    public class AuthenticationRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
