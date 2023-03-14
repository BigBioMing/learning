using DesignPatternDemo.ResponsibilityChainPattern.Abstractions;
using DesignPatternDemo.ResponsibilityChainPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ResponsibilityChainPattern.Concretes
{
    /// <summary>
    /// 具体处理者一
    /// </summary>
    public class Concrete1Handler : Handler
    {
        public override void HandleRequest(RequestNotes requestNotes)
        {
            if (requestNotes.RequestNumber >= 0 && requestNotes.RequestNumber < 5)
            {
                Console.WriteLine($"我是处理者【{nameof(Concrete1Handler)}】，【{requestNotes.Requester}】你的请求我处理了，请求数量【{requestNotes.RequestNumber}】");
            }
            else
            {
                this.Successor?.HandleRequest(requestNotes);
            }
        }
    }
}
