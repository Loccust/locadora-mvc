using Microsoft.EntityFrameworkCore;
using VideoStore.Model;

namespace VideoStore.Data
{
    public class VideoStoreDbContext : DbContext
    { 
        public VideoStoreDbContext(DbContextOptions<VideoStoreDbContext> options) : base(options) {}
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}