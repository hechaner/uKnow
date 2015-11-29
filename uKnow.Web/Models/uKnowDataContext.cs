using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace uKnow.Web.Models
{
    public class uKnowDataContext : DbContext
    {
        public uKnowDataContext()
            : base("uKnowConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<City> Citise { get; set; }
        public DbSet<HotCity> HotCities { get; set; }
    }
}