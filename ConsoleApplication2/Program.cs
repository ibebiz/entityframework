using Entityframework.HAI._1.Migrations;
using Entityframework.HAI._1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductContext, Configuration>());
            CreateDabase();
            Them();
        }

        public static void Them()
        {
            using (var db = new ProductContext())
            {
                Guid id = Guid.NewGuid();

                var cat = new Entityframework.HAI._1.Models.EFmigration.Category { ID = id, Name = "abc" };
                db.Categories.Add(cat);
                var pro = new Entityframework.HAI._1.Models.EFmigration.Product {ID=id, Name = "Title1", Content = "Hello World!", CreateDate = new DateTime(2011, 1, 1), Category = cat };
             
                db.Products.Add(pro);

                int i = db.SaveChanges();
            }
        }
        public static void Xoa()
        {
            
         
        }

        public static void CreateDabase()
        {
            var context = new ProductContext();
            context.Database.Initialize(true);
        }
    }
}
