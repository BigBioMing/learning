using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using 领域事件01.Domains;
using 领域事件01.Entities;

namespace 领域事件01.Databases
{
    public abstract class BaseDbContext : DbContext
    {
        protected readonly IMediator _mediator;
        public BaseDbContext(IMediator mediator)
        {
            this._mediator = mediator;
        }
        public BaseDbContext(DbContextOptions options, IMediator mediator) : base(options)
        {
            this._mediator = mediator;
        }

        public DbSet<EventRecord> EventRecords { get; set; }

        /// <summary>
        /// 重写SaveChangesAsync方法【改造顺序】
        /// 改造顺序，将publish放在SaveChangesAsync后，当SaveChangesAsync失败就不会发送消息，但依旧清空消息
        /// </summary>
        /// <param name="acceptAllChangesOnSuccess"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            //1.获取所有实现IDomainEvents接口 且 含有未发布事件的对象
            var domainEntities = this.ChangeTracker.Entries<IDomainEvents>().Where(n => n.Entity.GetDomainEvents().Any());
            //2. 获取所有待发布的消息【剖析selectMany的作用，两次查找】
            var domainEvents = domainEntities.SelectMany(n => n.Entity.GetDomainEvents()).ToList();
            var result = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            //3. 清空所有待发布的消息
            domainEntities.ToList().ForEach(n => n.Entity.ClearAllDomainEvents());
            //4. 发送消息
            foreach (var domainEvent in domainEvents)
            {
                await _mediator.Publish(domainEvent, cancellationToken);
            }

            string batch = Guid.NewGuid().ToString("N");
            var eventRecords = domainEvents.Select(n =>
            {
                return new EventRecord()
                {
                    Type = n.GetType().FullName,
                    Batch = batch,
                    UniqueId = Guid.NewGuid().ToString("N"),
                    Content = JsonConvert.SerializeObject(n, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }),
                    CreateTime = DateTime.Now
                };
            }).ToList();

            if (eventRecords.Any())
            {
                this.EventRecords.AddRange(eventRecords);
                var result2 = await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
            }


            return result;
        }
    }
}
