using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurants_MVC.Models;

namespace Restaurants_MVC.Data
{
    public class Restaurants_MVCContext : DbContext
    {
        public Restaurants_MVCContext (DbContextOptions<Restaurants_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurants_MVC.Models.Customer> Customer { get; set; }

        public DbSet<Restaurants_MVC.Models.Food> Food { get; set; }

        public DbSet<Restaurants_MVC.Models.Order> Order { get; set; }

        public DbSet<Restaurants_MVC.Models.Staff> Staff { get; set; }
    }
}
