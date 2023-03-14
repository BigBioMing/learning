using DesignPatternDemo.BridgePattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BridgePattern.Concretes.Implementors
{
    public class ImplementorY : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现类 Y 的执行方法");
        }
    }
}
