using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.MementoPattern.Standard
{
    /// <summary>
    /// 备忘录（需要保存的信息的类）
    /// </summary>
    public class Memento
    {
        public string State1 { get; set; }
        public string State2 { get; set; }

        public Memento(string state1, string state2)
        {
            this.State1 = state1;
            this.State2 = state2;
        }
    }
}
