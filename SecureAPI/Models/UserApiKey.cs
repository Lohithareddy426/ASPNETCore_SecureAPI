using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SecureAPI.Models
{
    [Index(nameof(Value), IsUnique = true)]
    public class UserApiKey
    {
        [JsonIgnore]
        public int ID { get; set; }

        [Required]
        public string Value { get; set; }

        [JsonIgnore]
        [Required]
        public string UserID { get; set; }

        [JsonIgnore]
        public IdentityUser User { get; set; }
    }
}