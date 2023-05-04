using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureAPI.Data;
using SecureAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme}")]
   //[Authorize(AuthenticationSchemes = "ApiKey")] --Uncomment if you want API KEY authentication
    public class CountriesController : ControllerBase
    {
        private UsersIdentityDbContext _context;
        private ILogger<CountriesController> _logger;
        public CountriesController(UsersIdentityDbContext context, ILogger<CountriesController> logger) {
        _context = context;
        _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCountries() {
            return Ok(_context.Countries.ToList());
        }

        [HttpPost]
        public IActionResult PostCountry(Country country )
        {
            _context.Countries.Add( country );
            _context.SaveChanges();
            return Ok(_context.Countries);
        }


    }
}
