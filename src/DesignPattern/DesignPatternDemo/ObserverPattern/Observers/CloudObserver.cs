using DesignPatternDemo.ObserverPattern.Abstrations;
using DesignPatternDemo.ObserverPattern.NoticeInformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ObserverPattern.Observers
{
    /// <summary>
    /// 云端观察者
    /// </summary>
    public class CloudObserver : Abstrations.IObserver<RiceCookerNoticeInformation>
    {
        public void Receive(RiceCookerNoticeInformation notice)
        {
            Console.WriteLine($"{notice.Message}调用云端接口，通知app发出提醒");
        }
    }
}
