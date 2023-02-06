using MediatR;

namespace 领域事件01.Notifications
{
    public class Text1NotificationHandler : INotificationHandler<MessageNotification>
    {
        public Task Handle(MessageNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Text1 handler 接收消息：{notification.Message}");
            return Task.CompletedTask;
        }
    }
}
