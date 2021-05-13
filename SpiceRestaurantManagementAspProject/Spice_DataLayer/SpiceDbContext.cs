using Spice_DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_DataLayer
{
    public class SpiceDbContext:DbContext
    {
        public SpiceDbContext(): base("Conn")
        {
                

        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } 

        public DbSet<OrderSummary> OrderSummaries { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
