using DesignPatternDemo.CompositePattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CompositePattern
{
    public class Composite : Abstractions.Component
    {
        private List<Component> _components = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new String('#', depth)} {Name}");
            _components.ForEach(component => component.Display(depth + 2));
        }
    }
}
