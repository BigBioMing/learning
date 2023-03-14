using DesignPatternDemo.VisitorPattern.Abstractions;
using DesignPatternDemo.VisitorPattern.Concretes.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.VisitorPattern.Concretes.Visitors
{
    /// <summary>
    /// 访问者A（如 成功时男人女人的反应）
    /// </summary>
    public class ConcreteVisitorA : VisitorAbstraction
    {
        public override void VisitorConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"成功 --- 男人：我成功了，以后要买车子买房子   {concreteElementA.GetType().Name} {this.GetType().Name}");
        }

        public override void VisitorConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"成功 --- 女人：我成功了，以后要买香水口红化妆品   {concreteElementB.GetType().Name} {this.GetType().Name}");
        }
    }
}
