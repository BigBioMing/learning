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
    /// 具体处理者三
    /// </summary>
    public class Concrete3Handler : Handler
    {
        public override void HandleRequest(RequestNotes requestNotes)
        {
            if (requestNotes.RequestNumber >= 10)
            {
                Console.WriteLine($"我是处理者【{nameof(Concrete3Handler)}】，【{requestNotes.Requester}】你的请求我处理了，请求数量【{requestNotes.RequestNumber}】");
            }
            else
            {
                this.Successor?.HandleRequest(requestNotes);
            }
        }
    }
}
