using Microsoft.EntityFrameworkCore;
using Sales_NET8.Web.Data.Entities;
using Sales_NET8.Web.Models;
using System.Collections.Generic;

namespace Sales_NET8.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }

        public DbSet<Category> Categories { get; set; }
    }
}
