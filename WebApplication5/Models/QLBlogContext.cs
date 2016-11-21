using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public partial class BlogContext : DbContext
    {
        public BlogContext()
            : base("BlogDb")
        {
        }

        public DbSet<WebApplication5.Models.QLBlog.BlogPost> BlogPosts { get; set; }
        public DbSet<WebApplication5.Models.QLBlog.Category> Categories { get; set; }

    }
}