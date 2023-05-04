using System.ComponentModel.DataAnnotations;

namespace SecureAPI.Models
{
    public class Country
    {
        
        public int id { get; set; }
        [Required]
        public string country_code { get; set; }
        [Required]
        public string country_name { get; set; }
        [Required]
        public string language { get; set; }
        [Required]
        public string currency { get; set; }
    }
}
