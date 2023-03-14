using DesignPatternDemo.ResponsibilityChainPattern.Abstractions;
using DesignPatternDemo.ResponsibilityChainPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.ResponsibilityChainPattern.Concretes
{
    /// <summary>
    /// 具体处理者二
    /// </summary>
    public class Concrete2Handler : Handler
    {
        public override void HandleRequest(RequestNotes requestNotes)
        {
            if (requestNotes.RequestNumber >= 5 && requestNotes.RequestNumber < 10)
            {
                Console.WriteLine($"我是处理者【{nameof(Concrete2Handler)}】，【{requestNotes.Requester}】你的请求我处理了，请求数量【{requestNotes.RequestNumber}】");
            }
            else
            {
                this.Successor?.HandleRequest(requestNotes);
            }
        }
    }
}
