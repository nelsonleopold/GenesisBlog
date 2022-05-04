using GenesisBlog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GenesisBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext<BlogUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GenesisBlog.Models.BlogPost> BlogPost { get; set; }
        public DbSet<GenesisBlog.Models.BlogPostComment> BlogPostComment { get; set; }
    }
}