using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Project.Models
{
    public class Customer
    {
        public Customer()
        {
            this.OrderEntries = new List<OrderEntry>();
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Phone { get; set; }
        public string Picture { get; set; }
        public bool MaritialStatus { get; set; }
        //nav
        public virtual ICollection<OrderEntry> OrderEntries { get; set; }

    }
    public class Product
    {
        public Product()
        {
            this.OrderEntries = new List<OrderEntry>();
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        //nav
        public virtual ICollection<OrderEntry> OrderEntries { get; set; }
    }
    public class OrderEntry
    {
        public int OrderEntryId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        //nav
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderEntry> OrderEntries { get; set; }
    }
}
