using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Entities.DAL
{
    public class ExchangeContext : DbContext
    {

        public ExchangeContext() : base("ExchangeContext")
        {
        }

        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}