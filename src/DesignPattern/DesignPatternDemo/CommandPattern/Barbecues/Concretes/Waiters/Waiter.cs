using DesignPatternDemo.CommandPattern.Barbecues.Abstractions;
using DesignPatternDemo.CommandPattern.Barbecues.Concretes.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Barbecues.Concretes.Waiters
{
    /// <summary>
    /// 服务员
    /// </summary>
    public class Waiter
    {
        public List<VegetableCommand> Commands { get; set; }

        public Waiter()
        {
            Commands = new List<VegetableCommand>();
        }

        public void SetOrder(VegetableCommand command)
        {
            if (command.ToString() == typeof(RoastChickenKebab).FullName)
            {
                Console.WriteLine($"服务员：鸡肉串没有了，点点儿别的吧。");
            }
            else
            {
                Commands.Add(command);
                Console.WriteLine($"【{DateTime.Now.ToString()}】添加了新的烧烤：{command.ToString()}");
            }
        }

        public void CancelOrder(VegetableCommand command)
        {
            Commands.Remove(command);
            Console.WriteLine($"【{DateTime.Now.ToString()}】取消了烧烤：{command.ToString()}");
        }

        public void Notify()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
