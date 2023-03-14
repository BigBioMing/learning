using DesignPatternDemo.CommandPattern.Barbecues.Abstractions;
using DesignPatternDemo.CommandPattern.Barbecues.Concretes.Cooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Barbecues.Concretes.Commands
{
    /// <summary>
    /// 烤牛肉串
    /// </summary>
    public class RoastBeefKebab : VegetableCommand
    {
        private Cook _cook = new Cook();
        public override void Execute()
        {
            _cook.BeefKebab();
        }
    }
}
