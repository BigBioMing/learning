using MediatR;

namespace CQRSDemo01
{
    public class MyCommand : IRequest<long>
    {
        public string Name { get; set; }
    }
}
