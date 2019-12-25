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

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite(_config.GetConnectionString("DefaultConnection"));
        // }
    }
}
