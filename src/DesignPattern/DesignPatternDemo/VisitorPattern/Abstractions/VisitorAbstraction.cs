using DesignPatternDemo.VisitorPattern.Concretes.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.VisitorPattern.Abstractions
{
    /// <summary>
    /// 访问者抽象类，定义对象数据结构
    /// </summary>
    public abstract class VisitorAbstraction
    {
        /// <summary>
        /// 结构A（如男人的反应）
        /// </summary>
        /// <param name="concreteElementA"></param>
        public abstract void  VisitorConcreteElementA(ConcreteElementA concreteElementA);
        /// <summary>
        /// 结构B（如女人的反应）
        /// </summary>
        /// <param name="concreteElementA"></param>
        public abstract void  VisitorConcreteElementB(ConcreteElementB concreteElementB);
    }
}
