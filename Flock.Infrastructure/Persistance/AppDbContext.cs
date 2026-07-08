using Flock.Domain.Entities;
using Microsoft.EntityFrameworkCore;


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
        public DbSet<Church> Church => Set<Church>();
        public DbSet<Users> Users => Set<Users>(); 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("members");
                entity.HasKey(m => m.id);

                entity.Property(m => m.id).ValueGeneratedOnAdd();
                entity.Property(m => m.firstName).IsRequired().HasMaxLength(25);
                entity.Property(m => m.lastName).IsRequired().HasMaxLength(25);
                entity.Property(m => m.dateOfBirth).IsRequired().HasColumnType("date");
                entity.Property(m => m.tenantId).IsRequired();
            });

            modelBuilder.Entity<Church>(entity =>
                {
                    entity.ToTable("church");
                    entity.HasKey(c => c.id);

                    entity.Property(c => c.id).ValueGeneratedOnAdd();
                    entity.Property(c => c.name).IsRequired().HasMaxLength(50);
                    entity.Property(c => c.tenantId).IsRequired();
                    entity.Property(c => c.email).IsRequired();
                    entity.Property(c => c.password).IsRequired();

                });
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");
                entity.HasKey(u => u.id);

                entity.Property(u => u.id).ValueGeneratedOnAdd();
                entity.Property(u => u.name).IsRequired().HasMaxLength(50);
                entity.Property(u => u.adminLevel).IsRequired();
            });
        }
    }

}
