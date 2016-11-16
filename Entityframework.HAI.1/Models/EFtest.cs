using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Entityframework.HAI._1.Model
{
    public class EFtest
    {
        [Table("Products")]
        public class Product
        {
            [Key]
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Content { get; set; }
            public DateTime CreateDate { get; set; }
            [ForeignKey("Category")]
            public Guid CategoryID { get; set; }
            public virtual Category Category { get; set; }
        }

        [Table("Categories")]
        public class Category
        {
            [Key]
            public Guid ID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Product> Products { get; set; }
        }
    }
   
}