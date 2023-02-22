using DesignPatternDemo.CompositePattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CompositePattern
{
    public class Leaf : Abstractions.Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new String('#', depth)} {Name}");
        }
    }
}
