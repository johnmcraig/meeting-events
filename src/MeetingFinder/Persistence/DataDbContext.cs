using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Persistence
{
    public class DataDbContext : IdentityDbContext<AppUser>
    {
        private readonly IConfiguration _config;

        public DataDbContext(DbContextOptions<DataDbContext> options, IConfiguration config) : base (options)
        {
            _config = config;
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Value>()
            .HasData(
                new Value { Id = 1, Name = "Value 101", Description = "A value with property of 101"},
                new Value { Id = 2, Name = "Value 102", Description = "A value with property of 102"},
                new Value { Id = 3, Name = "Value 103", Description = "A value with property of 103"}
            );
        }
    }
}
