using DesignPatternDemo.IteratorPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.IteratorPattern.Concretes
{
    public class ConcreteIterator : IIterator
    {
        private int currentIndex = 0;
        private ConcreteAggregate _aggregate { get; set; }
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public object First()
        {
            return this._aggregate[0];
        }

        public object Next()
        {
            object ret = null;
            this.currentIndex++;
            if (this.currentIndex < this._aggregate.Count)
            {
                ret = this._aggregate[this.currentIndex];
            }

            return ret;
        }

        public bool IsDone()
        {
            return this.currentIndex >= this._aggregate.Count ? true : false;
        }
        public object CurrentItem()
        {
            return this._aggregate[this.currentIndex];
        }
    }
}
