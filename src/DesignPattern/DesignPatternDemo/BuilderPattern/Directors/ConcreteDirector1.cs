using DesignPatternDemo.BuilderPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BuilderPattern.Directors
{
    internal class ConcreteDirector1 : IDirector
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPart01();
            builder.BuildPart02();
        }
    }
}
