using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Entityframework.HAI._1.Models.ProductContext())
            {
                Guid id = Guid.NewGuid();

                var cat = new Entityframework.HAI._1.Model.EFtest.Category { ID = id, Name = "abc" };
                var post = new Entityframework.HAI._1.Model.EFtest.Product { Name = "Title2", Content = "Hello World!", CreateDate = new DateTime(2011, 1, 1), Category = cat };

                db.Categories.Add(cat);
                db.Products.Add(post);

                int i = db.SaveChanges();
                Console.WriteLine("{0} records added...", i);
                Console.ReadLine();
            }

           
        }

      
    }
}
