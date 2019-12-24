using System;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base (options)
        {
            
        }
    }
}
