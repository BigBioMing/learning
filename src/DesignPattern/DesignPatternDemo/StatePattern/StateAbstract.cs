using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.StatePattern
{
    public abstract class StateAbstract
    {
        public abstract void Handle(StateContext context);
    }
}
