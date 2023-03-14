using DesignPatternDemo.CommandPattern.Normal.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Normal.Concretes
{
    /// <summary>
    /// 命令2
    /// </summary>
    public class Concrete2Command : Command
    {
        public Concrete2Command(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            this.Receiver.Action2();
        }
    }
}
