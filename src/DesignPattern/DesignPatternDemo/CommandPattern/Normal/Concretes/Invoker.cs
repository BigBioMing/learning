using DesignPatternDemo.CommandPattern.Normal.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Normal.Concretes
{
    /// <summary>
    /// 接收&发布命令
    /// </summary>
    public class Invoker
    {
        public List<Command> Commands { get; set; } = new List<Command>();

        public void SetCommand(Command command)
        {
            this.Commands.Add(command);
        }

        public void RemoveCommand(Command command)
        {
            this.Commands.Remove(command);
        }

        public void ExecuteCommand()
        {
            foreach (var command in this.Commands)
            {
                command.Execute();
            }
        }
    }
}
