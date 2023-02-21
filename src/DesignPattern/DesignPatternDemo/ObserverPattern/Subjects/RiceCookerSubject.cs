using DesignPatternDemo.ObserverPattern.Abstrations;
using DesignPatternDemo.ObserverPattern.NoticeInformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ObserverPattern.Subjects
{
    /// <summary>
    /// 电饭煲主题
    /// </summary>
    public class RiceCookerSubject : ISubject<RiceCookerNoticeInformation>
    {
        private readonly List<Abstrations.IObserver<RiceCookerNoticeInformation>> _observers;
        private IReadOnlyList<Abstrations.IObserver<RiceCookerNoticeInformation>> Observers { get => this._observers; }
        public RiceCookerSubject()
        {
            this._observers = new List<Abstrations.IObserver<RiceCookerNoticeInformation>>();
        }
        public void Attach(Abstrations.IObserver<RiceCookerNoticeInformation> observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(Abstrations.IObserver<RiceCookerNoticeInformation> observer)
        {
            this._observers.Remove(observer);
        }

        public void Notice(RiceCookerNoticeInformation notice)
        {
            foreach (var observer in this._observers)
            {
                observer.Receive(notice);
            }
        }
    }
}
