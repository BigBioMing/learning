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
    /// 启动
    /// </summary>
    public class StartUpState : StateAbstract
    {
        public override void Handle(StateContext context)
        {
            Console.WriteLine($"微波炉已启动");
            context.SetState(new RunningState());
        }
    }
}
