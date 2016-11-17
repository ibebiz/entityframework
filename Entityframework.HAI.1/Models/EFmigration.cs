using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entityframework.HAI._1.Models
{
    public class EFmigration
    {
        [Table("Products")]
        public class Product
        {
            [Key]
            public Guid ID { get; set; }
            public string Name { get; set; }
            public string Content { get; set; }
            public DateTime CreateDate { get; set; }
            public float Price { get; set; }
            [ForeignKey("Category")]
            public Guid CategoryId { get; set; }
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
        public class User
        {
            public int UserId { get; set; }
            public DateTime SignInDate { get; set; }
        }
    }
}