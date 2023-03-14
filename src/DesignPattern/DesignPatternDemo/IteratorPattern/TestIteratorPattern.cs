using DesignPatternDemo.IteratorPattern.Abstractions;
using DesignPatternDemo.IteratorPattern.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.IteratorPattern
{
    public class TestIteratorPattern
    {
        public static void Execute()
        {
            ConcreteAggregate concreteAggregate = new ConcreteAggregate();
            IIterator iterator = concreteAggregate.CreateIterator();
            concreteAggregate[0] = "张三";
            concreteAggregate[1] = "李四";
            concreteAggregate[2] = "王五";
            concreteAggregate[3] = "赵六";
            concreteAggregate[4] = "周七";

            object item = iterator.Next();
            while (!iterator.IsDone())
            {
                item = iterator.CurrentItem();
                Console.WriteLine($"{item} 进来了！");
                iterator.Next();
            }

            Console.ReadKey();
        }
    }
}
