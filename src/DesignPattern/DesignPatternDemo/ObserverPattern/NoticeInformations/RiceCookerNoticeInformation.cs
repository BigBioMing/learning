using DesignPatternDemo.ObserverPattern.Abstrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ObserverPattern.NoticeInformations
{
    public class RiceCookerNoticeInformation : INoticeInformation
    {
        public string Message { get; set; }
    }
}
