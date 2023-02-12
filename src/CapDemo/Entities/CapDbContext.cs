using DotNetCore.CAP;
using Microsoft.EntityFrameworkCore;

namespace CapDemo.Entities
{
    public class CapDbContext : DbContext
    {
        protected readonly ICapPublisher _capBus;
        public CapDbContext(DbContextOptions<CapDbContext> options, ICapPublisher capBus) : base(options)
        {
            _capBus = capBus;
        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Id).ValueGeneratedOnAdd().IsRequired();
                entity.Property(n => n.Name).HasMaxLength(30).IsRequired();
            });
        }
    }
}
