using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.VisitorPattern.Abstractions
{
    /// <summary>
    /// 元素 每个实现类对应对象的某个结构（如A实现类对应男人的反应，B实现类对应女人的反应
    /// </summary>
    public abstract class ElementAbstraction
    {
        public abstract void Accept(VisitorAbstraction visitor);
    }
}
