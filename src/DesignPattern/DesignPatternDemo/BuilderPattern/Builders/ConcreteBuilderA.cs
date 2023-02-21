using DesignPatternDemo.BuilderPattern.Abstractions;
using DesignPatternDemo.BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BuilderPattern.Builders
{
    public class ConcreteBuilderA : IBuilder
    {
        private Product _product = new Product();
        public void BuildPart01()
        {
            _product.Add("部件A");
        }

        public void BuildPart02()
        {
            _product.Add("部件B");
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}
