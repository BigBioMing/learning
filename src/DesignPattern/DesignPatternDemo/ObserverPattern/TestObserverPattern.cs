using DesignPatternDemo.ObserverPattern.NoticeInformations;
using DesignPatternDemo.ObserverPattern.Observers;
using DesignPatternDemo.ObserverPattern.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ObserverPattern
{
    public class TestObserverPattern
    {
        public static void Execute()
        {
            RiceCookerNoticeInformation riceCookerNoticeInformation = new RiceCookerNoticeInformation()
            {
                Message ="电饭煲煮饭完成！"
            };
            RiceCookerSubject riceCookerSubject = new RiceCookerSubject();
            CloudObserver cloudObserver = new CloudObserver();
            MachineObserver  machineObserver = new MachineObserver();

            riceCookerSubject.Attach(machineObserver);
            riceCookerSubject.Attach(cloudObserver);

            riceCookerSubject.Notice(riceCookerNoticeInformation);
        }
    }
}
