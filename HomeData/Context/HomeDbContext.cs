using HomeEntity.Master;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeData.Context
{
    public class HomeDbContext : DbContext
    {
        public HomeDbContext(DbContextOptions<HomeDbContext> options)
      : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(p => p.Section)
                .WithMany(b => b.Students);
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Section> Section { get; set; }
    }
}
