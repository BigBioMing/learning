using DesignPatternDemo.VisitorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.VisitorPattern.Concretes.Elements
{
    /// <summary>
    /// 对应对象(VisitorAbstraction)的结构(VisitorConcreteElementB)，如女人的反应
    /// </summary>
    public class ConcreteElementB : ElementAbstraction
    {
        public override void Accept(VisitorAbstraction visitor)
        {
            visitor.VisitorConcreteElementB(this);
        }
    }
}
