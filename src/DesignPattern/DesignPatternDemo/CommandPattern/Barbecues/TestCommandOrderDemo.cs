using DesignPatternDemo.CommandPattern.Barbecues.Concretes.Commands;
using DesignPatternDemo.CommandPattern.Barbecues.Concretes.Waiters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Barbecues
{
    /// <summary>
    /// 点餐测试
    /// </summary>
    public class TestCommandOrderDemo
    {
        public static void Execute()
        {
            //烤牛肉串
            RoastBeefKebab roastBeefKebab = new RoastBeefKebab();
            //烤鸡肉串
            RoastChickenKebab roastChickenKebab = new RoastChickenKebab();
            //烤羊肉串
            RoastShishKebab roastShishKebab = new RoastShishKebab();

            Waiter waiter = new Waiter();

            waiter.SetOrder(roastShishKebab);
            waiter.SetOrder(roastChickenKebab);
            waiter.SetOrder(roastBeefKebab);

            waiter.Notify();
        }
    }
}
