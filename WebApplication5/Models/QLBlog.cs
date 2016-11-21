using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class QLBlog
    {
        public class BlogPost
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime PublishDate { get; set; }
            public virtual Category Category { get; set; }
        }

        public class Category
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public virtual ICollection<BlogPost> BlogPosts { get; set; }
        }
    }
}