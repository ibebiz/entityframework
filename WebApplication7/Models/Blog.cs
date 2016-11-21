﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    [Table("Blog")]
    public class Blog
    {


        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }

        [Table("Categories")]
        public class Category
        {
            [Key]
            public Guid Id { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Blog> QLBlogs { get; set; }
        }
    
}