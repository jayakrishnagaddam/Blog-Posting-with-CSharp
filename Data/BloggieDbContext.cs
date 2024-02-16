using Microsoft.EntityFrameworkCore;
using Blog_Posting_with_C_.Models.Domain;

namespace Bloggie.Web.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts{ get; set; }

        public DbSet<Tag> Tags{ get; set; }


    }
}
