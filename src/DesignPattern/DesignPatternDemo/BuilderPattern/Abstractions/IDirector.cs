using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BuilderPattern.Abstractions
{
    public interface IDirector
    {
        void Construct(IBuilder builder);
    }
}
