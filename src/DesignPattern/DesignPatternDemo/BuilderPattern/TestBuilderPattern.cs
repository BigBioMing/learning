using DesignPatternDemo.BuilderPattern.Builders;
using DesignPatternDemo.BuilderPattern.Directors;
using DesignPatternDemo.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BuilderPattern
{
    internal class TestBuilderPattern
    {
        public static void Execute()
        {
            ConcreteBuilderA concreteBuilderA = new ConcreteBuilderA();
            ConcreteBuilderB concreteBuilderB = new ConcreteBuilderB();
            ConcreteDirector1 concreteDirector1 = new ConcreteDirector1();

            concreteDirector1.Construct(concreteBuilderA);
            Product product1 = concreteBuilderA.GetProduct();

            concreteDirector1.Construct(concreteBuilderB);
            Product product2 = concreteBuilderB.GetProduct();

            Console.WriteLine($"product1建造完成：{product1.View()}");
            Console.WriteLine($"product2建造完成：{product2.View()}");
        }
    }
}
