using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}