using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ObserverPattern.Abstrations
{
    public interface ISubject<TNoticeInformation> where TNoticeInformation : INoticeInformation
    {
        void Attach(IObserver<TNoticeInformation> observer);
        void Detach(IObserver<TNoticeInformation> observer);
        void Notice(TNoticeInformation notice);
    }
}
