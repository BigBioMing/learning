using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CommandPattern.Normal.Concretes
{
    /// <summary>
    /// 实际处理业务的类
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// 动作一
        /// </summary>
        public void Action1()
        {
            Console.WriteLine($"动作一");
        }
        /// <summary>
        /// 动作二
        /// </summary>
        public void Action2()
        {
            Console.WriteLine($"动作二");
        }
        /// <summary>
        /// 动作三
        /// </summary>
        public void Action3()
        {
            Console.WriteLine($"动作三");
        }
    }
}
