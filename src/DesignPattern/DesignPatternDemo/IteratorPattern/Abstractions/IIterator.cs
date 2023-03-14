using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.IteratorPattern.Abstractions
{
    /// <summary>
    /// 迭代器接口
    /// </summary>
    public interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }
}
