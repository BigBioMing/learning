using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDemo.StatePattern.Contexts;

namespace DesignPatternDemo.StatePattern.Abstractions
{
    public abstract class StateAbstract
    {
        public abstract void Handle(StateContext context);
    }
}
