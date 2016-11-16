using Entityframework.HAI._1.Migrations;
using Entityframework.HAI._1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductContext, Configuration>());
            CreateDabase();
        }

        public static void CreateDabase()
        {
            var context = new ProductContext();
            context.Database.Initialize(true);
        }
    }
}
