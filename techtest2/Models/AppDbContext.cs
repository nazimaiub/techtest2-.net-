using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techtest2.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Trade> trades { get; set; }
        public DbSet<Level> levels { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<tradingInfo> tradingInfoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trade>().HasData(
                new Trade
                {
                    id = 1,
                    tradeName = "MS INTERNATIONAL"
                },
                new Trade
                {
                    id = 2,
                    tradeName = "RAHIM INTERNATIONAL"
                }

            );
            modelBuilder.Entity<Level>().HasData(
                new Level
                {
                    id = 1,
                    levelName = "HIGH",
                    tradeId=1
                },
                new Level
                {
                    id = 2,
                    levelName = "MEDIUM",
                    tradeId = 2
                },
                new Level
                {
                    id = 3,
                    levelName = "LOW",
                    tradeId = 1
                }

            );
            modelBuilder.Entity<Language>().HasData(
                new Language
                {
                    id=1,
                    langName = "English"
                },
                new Language
                {
                    id = 2,
                    langName = "Chineese"
                },
                new Language
                {
                    id = 3,
                    langName = "Thai"
                },
                new Language
                {
                    id = 4,
                    langName = "Tamil"
                },
                new Language
                {
                    id = 5,
                    langName = "korean"
                },
                new Language
                {
                    id = 6,
                    langName = "burmese"
                }

            );
            modelBuilder.Entity<tradingInfo>()
            .Property(f => f.id)
            .ValueGeneratedOnAdd();
        }


    }
}
