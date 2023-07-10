using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using WepAPI_Restaurant_Management.Models;

namespace WepAPI_Restaurant_Management.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Guest> Guest { get; set; }

        public DbSet<GuestTable> GuestTable { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Unit> Units { get; set; }

        public DbSet<UnitType> UnitType { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<ItemImage> ItemImage { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        public DbSet<Location> Location { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
