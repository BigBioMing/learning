using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ObserverPattern.Abstrations
{
    public interface IObserver<TNoticeInformation> where TNoticeInformation : INoticeInformation
    {
        void Receive(TNoticeInformation notice);
    }
}
