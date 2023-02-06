using MediatR;

namespace 领域事件01.Notifications
{
    public record MessageNotification : INotification
    {
        public string Message { get; set; } = null!;
    }
}
