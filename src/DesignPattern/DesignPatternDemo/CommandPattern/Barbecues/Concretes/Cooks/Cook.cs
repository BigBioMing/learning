using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Barbecues.Concretes.Cooks
{
    /// <summary>
    /// 厨师
    /// </summary>
    public class Cook
    {
        public void ShishKebab()
        {
            Console.WriteLine($"羊肉串");
        }
        public void ChickenKebab()
        {
            Console.WriteLine($"鸡肉串");
        }
        public void BeefKebab()
        {
            Console.WriteLine($"牛肉串");
        }
    }
}
