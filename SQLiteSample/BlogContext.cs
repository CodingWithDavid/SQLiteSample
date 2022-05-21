using Microsoft.EntityFrameworkCore;

namespace SQLiteSample
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Blogs.db");
    }
}
