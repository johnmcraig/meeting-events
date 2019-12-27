using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence
{
    public class DataDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public DataDbContext(DbContextOptions<DataDbContext> options, IConfiguration config) : base (options)
        {
            _config = config;
        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value { Id = 1, Name = "Value 101", Description = "A value with property of 101"},
                new Value { Id = 2, Name = "Value 102", Description = "A value with property of 102"},
                new Value { Id = 3, Name = "Value 103", Description = "A value with property of 103"}
            );
        }
    }
}
