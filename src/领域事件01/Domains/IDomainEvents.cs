using MediatR;

namespace 领域事件01.Domains
{
    public interface IDomainEvents
    {
        IEnumerable<INotification> GetDomainEvents();
        void AddDomainEvents(INotification notification);
        void ClearAllDomainEvents();
    }
}
