using Microsoft.EntityFrameworkCore;
using Bury_the_light.Data.Entities;
using System.Security.Claims;

namespace Bury_the_light.Data.Entities
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Deliveries> Deliveries { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Points_of_delivery> Points_of_delivery { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shopping_cart> Shopping_cart { get; set; }

    }
}
