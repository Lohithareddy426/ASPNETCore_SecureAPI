using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SecureAPI.Models;

namespace SecureAPI.Data
{
    public class UsersIdentityDbContext : IdentityUserContext<IdentityUser>
    {
        public UsersIdentityDbContext(DbContextOptions<UsersIdentityDbContext> options) :base(options)
        {         
        }

        public DbSet<Weather> WeatherInfo { get; set; }
        public DbSet<UserApiKey> UserApiKeys { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
