using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.IteratorPattern.Abstractions
{
    /// <summary>
    /// 集合抽象
    /// </summary>
    public abstract class Aggregate
    {
        public abstract IIterator CreateIterator();
    }
}
