using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entityframework.HAI._1.Models
{
    public class EFmigration
    {
        public class Product
        {
          
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Content { get; set; }
            public DateTime CreateDate { get; set; }
            
           
            public virtual Category Category { get; set; }
        }

       
        public class Category
        {
        
            public Guid ID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Product> Products { get; set; }
        }
        public class User
        {
            public int UserId { get; set; }
            public DateTime SignInDate { get; set; }
        }
    }
}