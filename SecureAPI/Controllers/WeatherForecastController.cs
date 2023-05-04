using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureAPI.Data;
using SecureAPI.Models;

namespace SecureAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = $"{JwtBearerDefaults.AuthenticationScheme}")]
    public class WeatherForecastController : ControllerBase
    {     
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly UsersIdentityDbContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, UsersIdentityDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpPost]
        public IActionResult PostWeatherInfo(Weather weather )
        {
            _context.WeatherInfo.Add( weather );
            _context.SaveChanges();
            return Ok(_context.WeatherInfo);
        }

        [HttpGet]
        public IActionResult GetWeatherInfo()
        {            
            return Ok(_context.WeatherInfo.ToList());
        }


    }
}