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
    /// 访问者B（如 打喷嚏时男人女人的反应）
    /// </summary>
    public class ConcreteVisitorB : VisitorAbstraction
    {
        public override void VisitorConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"打喷嚏 --- 男人：阿嚏（大声）   {concreteElementA.GetType().Name} {this.GetType().Name}");
        }

        public override void VisitorConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"打喷嚏 --- 女人：阿秋（小声）   {concreteElementB.GetType().Name} {this.GetType().Name}");
        }
    }
}
