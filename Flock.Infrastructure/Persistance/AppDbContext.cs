using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Flock.Domain.Entities;

namespace Flock.Infrastructure.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }
        public DbSet<Member> Members => Set<Member>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("members");
                entity.HasKey(m => m.id);

                entity.Property(m => m.firstName).IsRequired().HasMaxLength(25);
                entity.Property(m => m.lastName).IsRequired().HasMaxLength(25);
                entity.Property(m => m.age).IsRequired().HasMaxLength(3);
                      
            });
        }
    }

}
