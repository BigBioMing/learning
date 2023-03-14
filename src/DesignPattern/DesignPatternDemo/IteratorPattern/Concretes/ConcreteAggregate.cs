using DesignPatternDemo.IteratorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.IteratorPattern.Concretes
{
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> _items = new List<object>();
        public override IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count { get { return _items.Count; } }

        public object this[int index]
        {
            get { return _items[index]; }
            set
            {
                if (index < _items.Count)
                {
                    _items[index] = value;
                }
                else
                {
                    _items.Insert(index, value);
                }
            }
        }
    }
}
