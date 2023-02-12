using MediatR;

namespace CQRSDemo01
{
    public class MyCommandHandler : IRequestHandler<MyCommand, long>
    {
        public Task<long> Handle(MyCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"{this.GetType().Name}执行命令：{request.Name}");
            return Task.FromResult(0L);
        }
    }
}
