using DesignPatternDemo.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BuilderPattern.Abstractions
{
    public interface IBuilder
    {
        void BuildPart01();
        void BuildPart02();
        Product GetProduct(); 
    }
}
