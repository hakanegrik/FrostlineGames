using System;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Entities
{
    public class Context : DbContext
    {
      

        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
