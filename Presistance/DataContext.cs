using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;


namespace Presistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }
    }
}
