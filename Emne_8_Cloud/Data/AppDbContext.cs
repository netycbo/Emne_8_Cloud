using Emne_8_Cloud.Data.Ententities;
using Microsoft.EntityFrameworkCore;

namespace Emne_8_Cloud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<RecordModel> Records { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecordModel>().HasData(
                new RecordModel
                {
                    Id = 1,
                    Title = "Hello",
                    Description = "World"
                },
                new RecordModel
                {
                    Id = 2,
                    Title = "The",
                    Description = "Who"
                }
            );
        }
    }
}
