using Microsoft.EntityFrameworkCore;
using NewsletterWebApi.Model;

namespace NewsletterWebApi.Context
{
    public class NewsletterDb : DbContext
    {
        public NewsletterDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
    }
}
