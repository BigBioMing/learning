using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.StatePattern
{
    /// <summary>
    /// 关机
    /// </summary>
    public class ShutdownState : StateAbstract
    {
        public override void Handle(StateContext context)
        {
            Console.WriteLine($"关机了");
        }
    }
}
