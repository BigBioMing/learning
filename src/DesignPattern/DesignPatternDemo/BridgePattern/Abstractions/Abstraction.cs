using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BridgePattern.Abstractions
{
    public abstract class Abstraction
    {
        protected Implementor _implementor;

        public virtual void SetImplementor(Implementor implementor)
        {
            this._implementor = implementor;
        }

        public virtual void Opertaion()
        {
            this._implementor.Operation();
        }
    }
}
