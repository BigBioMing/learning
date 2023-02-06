using MediatR;

namespace 领域事件01.Domains
{
    public class DomainEvents : IDomainEvents
    {
        private List<INotification> _notifications = new List<INotification> ();
        private object _lock = new object();
        public void AddDomainEvents(INotification notification)
        {
            _notifications.Add(notification);
        }

        public void ClearAllDomainEvents()
        {
            _notifications.Clear();
        }

        public IEnumerable<INotification> GetDomainEvents()
        {
            return _notifications;
        }
    }
}
