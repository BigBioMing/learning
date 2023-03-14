using DesignPatternDemo.BridgePattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BridgePattern.Concretes.RefinedAbstractions
{
    public class RefinedAbstractionA : Abstraction
    {
        public override void Opertaion()
        {
            Console.WriteLine($"==========RefinedAbstraction A 开始执行==========");
            base.Opertaion();
        }
    }
}
