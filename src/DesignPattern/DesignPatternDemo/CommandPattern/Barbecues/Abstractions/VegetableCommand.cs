using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Barbecues.Abstractions
{
    /// <summary>
    /// 菜品
    /// </summary>
    public abstract class VegetableCommand
    {
        public abstract void Execute();
    }
}
