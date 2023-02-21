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
    /// 加热完成
    /// </summary>
    public class FinishState : StateAbstract
    {
        public override void Handle(StateContext context)
        {
            Console.WriteLine($"食物加热完成");
            context.SetState(new ShutdownState());
        }
    }
}
