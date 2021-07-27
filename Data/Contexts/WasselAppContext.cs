using System;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Runtime.ConstrainedExecution;

namespace Data.Contexts
{
    public class WasselAppContext : DbContext
    {
        IHttpContextAccessor httpContextAccessor;

        public DbSet<Item> Item { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<Location> Location { get; set; }

        public WasselAppContext(DbContextOptions<WasselAppContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.httpContextAccessor = httpContextAccessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           

        }
    }
}
