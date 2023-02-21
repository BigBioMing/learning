using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDemo.StatePattern.Abstractions;
using DesignPatternDemo.StatePattern.Contexts;

namespace DesignPatternDemo.StatePattern.StateLogics
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
