using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.DAL.Entities;

namespace ToyShop.DAL.Context
{
    public class ToyShopContext : DbContext
    {
        public ToyShopContext(DbContextOptions<ToyShopContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<ToyCategory> ToyCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Thiết lập bảng Customer
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.CustomerID);

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.PhoneNumber)
                .IsUnique();

            // Thiết lập bảng Invoice
            modelBuilder.Entity<Invoice>()
                .HasKey(i => i.InvoiceID);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);

            // Thiết lập bảng InvoiceDetail
            modelBuilder.Entity<InvoiceDetail>()
                .HasKey(id => id.InvoiceDetailID);

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(id => id.Invoice)
                .WithMany(i => i.InvoiceDetails)
                .HasForeignKey(id => id.InvoiceID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(id => id.Toy)
                .WithMany(t => t.InvoiceDetails)
                .HasForeignKey(id => id.ToyID)
                .OnDelete(DeleteBehavior.Restrict);

            // Thiết lập bảng Toy
            modelBuilder.Entity<Toy>()
                .HasKey(t => t.ToyID);

            modelBuilder.Entity<Toy>()
                .HasOne(t => t.ToyCategory)
                .WithMany(tc => tc.Toys)
                .HasForeignKey(t => t.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);

            // Thiết lập bảng ToyCategory
            modelBuilder.Entity<ToyCategory>()
                .HasKey(tc => tc.CategoryID);
        }
    }
}
