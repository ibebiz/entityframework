using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public partial class BlogContext : DbContext
    {
        public BlogContext()
            : base("BlogDb")
        {
        }

        public DbSet<QLBlog> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
      

    }
}