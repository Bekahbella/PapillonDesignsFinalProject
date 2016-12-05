namespace PapillonDesignsFinal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Jewelry> Jewelries { get; set; }
        public virtual DbSet<JewelryType> JewelryTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Jewelry>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Jewelry>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Jewelry>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Jewelry>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Jewelry>()
                .Property(e => e.ImageURL)
                .IsUnicode(false);

            modelBuilder.Entity<Jewelry>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Jewelry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JewelryType>()
                .Property(e => e.JewelryTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<JewelryType>()
                .HasMany(e => e.Jewelries)
                .WithRequired(e => e.JewelryType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);
        }
    }
}
