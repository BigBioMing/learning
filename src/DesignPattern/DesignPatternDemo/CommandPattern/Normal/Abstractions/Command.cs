using DesignPatternDemo.CommandPattern.Normal.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Normal.Abstractions
{
    /// <summary>
    /// 命令类
    /// </summary>
    public abstract class Command
    {
        protected Receiver Receiver { get; set; }

        public Command(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        public abstract void Execute();
    }
}
