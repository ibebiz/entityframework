﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entityframework.HAI._1.Models
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
            : base("ProductDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductContext, Entityframework.HAI._1.Migrations.Configuration>("ProductDb"));
            
        }

        public DbSet<Entityframework.HAI._1.Models.EFmigration.Product> Products { get; set; }
        public DbSet<Entityframework.HAI._1.Models.EFmigration.Category> Categories { get; set; }
        public DbSet<Entityframework.HAI._1.Models.EFmigration.User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}