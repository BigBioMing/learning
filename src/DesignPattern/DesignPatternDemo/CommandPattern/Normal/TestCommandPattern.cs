using DesignPatternDemo.CommandPattern.Normal.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Normal
{
    public class TestCommandPattern
    {
        public static void Execute()
        {
            Receiver receiver = new Receiver();
            Concrete1Command concrete11Command = new Concrete1Command(receiver);
            Concrete2Command concrete21Command = new Concrete2Command(receiver);
            Concrete2Command concrete22Command = new Concrete2Command(receiver);
            Concrete2Command concrete23Command = new Concrete2Command(receiver);
            Concrete3Command concrete31Command = new Concrete3Command(receiver);
            Concrete3Command concrete32Command = new Concrete3Command(receiver);

            Invoker invoker = new Invoker();
            invoker.SetCommand(concrete11Command);
            invoker.SetCommand(concrete21Command);
            invoker.SetCommand(concrete31Command);
            invoker.SetCommand(concrete22Command);
            invoker.SetCommand(concrete32Command);
            invoker.SetCommand(concrete23Command);
            invoker.ExecuteCommand();
        }
    }
}
