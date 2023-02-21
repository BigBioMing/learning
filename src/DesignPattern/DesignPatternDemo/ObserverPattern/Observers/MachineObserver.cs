using DesignPatternDemo.ObserverPattern.NoticeInformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ObserverPattern.Observers
{
    /// <summary>
    /// 机器观察者
    /// </summary>
    public class MachineObserver : Abstrations.IObserver<RiceCookerNoticeInformation>
    {
        public void Receive(RiceCookerNoticeInformation notice)
        {
            Console.WriteLine($"{notice.Message}发出提示音，并闪烁呼吸灯");
        }
    }
}
