using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
               new DiaryEntry
               {
                   Id = 1,
                   Title = "Driving",
                   Content = "Going for a Drive with my friends",
                   Created = new DateTime(2024, 04, 10, 10, 0, 0)
               },
                new DiaryEntry
                {
                   Id = 2,
                   Title = "Went Shopping",
                   Content = "Shopping and enjoying the day !",
                   Created = new DateTime(2024, 04, 11, 14, 30, 0)
                },
                new DiaryEntry
                {
                Id = 3,
                Title = "Went Playing",
                Content = "Playing makes the day better !",
                Created = new DateTime(2024, 04, 12, 17, 15, 0)
                }


                );
            
        }
    }
}
