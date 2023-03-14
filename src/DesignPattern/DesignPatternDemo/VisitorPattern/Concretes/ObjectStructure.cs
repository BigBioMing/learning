using DesignPatternDemo.VisitorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.VisitorPattern.Concretes
{
    /// <summary>
    /// 能枚举他的元素，可以提供一个高层接口以允许访问者访问他的元素
    /// </summary>
    public class ObjectStructure
    {
        protected List<ElementAbstraction> Elements;
        public ObjectStructure()
        {
            this.Elements = new List<ElementAbstraction>();
        }

        public void Attacth(ElementAbstraction element)
        {
            this.Elements.Add(element);
        }

        public void Attach(ElementAbstraction element)
        {
            this.Elements.Add(element);
        }

        public void Detach(ElementAbstraction element)
        {
            this.Elements.Remove(element);
        }

        public void Display(VisitorAbstraction visitor)
        {
            foreach(var element in this.Elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
