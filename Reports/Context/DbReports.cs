using Reports.Initializer;
using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reports.Context
{
    public class DbReports : DbContext
    {
        static DbReports()
        {
            Database.SetInitializer<DbReports>(new MyContextInitializer());
        }
        public DbReports()
           : base("con1")
        {
            
        }
        public DbSet<CountShippingOnDate> CountShippingOnDates { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<User> Users { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

    }
}