using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.StatePattern
{
    /// <summary>
    /// 运行中
    /// </summary>
    public class RunningState : StateAbstract
    {
        public override void Handle(StateContext context)
        {
            Console.WriteLine($"正在加热食物");
            context.SetState(new FinishState());
        }
    }
}
