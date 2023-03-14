using DesignPatternDemo.VisitorPattern.Concretes;
using DesignPatternDemo.VisitorPattern.Concretes.Elements;
using DesignPatternDemo.VisitorPattern.Concretes.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.VisitorPattern
{
    public class TestVisitorPattern
    {
        public static void Execute()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Attacth(new ConcreteElementA());
            objectStructure.Attacth(new ConcreteElementB());

            objectStructure.Display(new ConcreteVisitorA());
            objectStructure.Display(new ConcreteVisitorB());
        }
    }
}
