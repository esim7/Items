using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EF
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RM1NBDJ;Database=ItemEdition;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var firstItem = new Item { Name = "IPhone XS Max", Type = "смартфон", Price = 465000, Weight = "382 грамм"};
            var secondItem = new Item { Name = "Galaxy S10", Type = "смартфон", Price = 389000, Weight = "295 грамм" };
            var thirdItem = new Item { Name = "Nokia 8800", Type = "сотовый телефон", Price = 250000, Weight = "225 грамм" };
            modelBuilder.Entity<Item>().HasData(firstItem, secondItem, thirdItem);
        }
    }
}
