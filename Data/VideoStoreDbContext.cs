using Microsoft.EntityFrameworkCore;
using VideoStore.Model;

namespace VideoStore.Data
{
    public class VideoStoreDbContext : DbContext
    { 
        public VideoStoreDbContext(DbContextOptions<VideoStoreDbContext> options) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rent> Rents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Rent>().ToTable("Rents");
        }
    }
}