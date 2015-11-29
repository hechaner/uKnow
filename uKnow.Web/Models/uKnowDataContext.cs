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

        public DbSet<Brand> Brands { get; set; }

        public DbSet<BrandBrandClassification> BrandBrandClassifications { get; set; }

        public DbSet<BrandClassification> BrandClassifications { get; set; }

        public DbSet<BrandType> BrandTypes { get; set; }

        public DbSet<Category> Categories { get; set; }   

        public DbSet<City> Citise { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<HotCity> HotCities { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<SearchRecord> SearchRecords { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<TeacherType> TeacherTypes { get; set; }




    }
}