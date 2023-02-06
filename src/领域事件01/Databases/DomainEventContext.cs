using MediatR;
using Microsoft.EntityFrameworkCore;
using 领域事件01.Entities;

namespace 领域事件01.Databases
{
    public class DomainEventContext : BaseDbContext
    {
        protected DomainEventContext(IMediator mediator) : base(mediator)
        {
        }

        public DomainEventContext(DbContextOptions options, IMediator mediator) : base(options, mediator)
        {
        }

        public DbSet<UserInfo> UserInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Id).ValueGeneratedOnAdd().IsRequired();
            });
        }

    }
}
