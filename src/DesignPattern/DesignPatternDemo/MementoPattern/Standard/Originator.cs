using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.MementoPattern.Standard
{
    /// <summary>
    /// 发起人（某个实体）
    /// </summary>
    public class Originator
    {
        public string State1 { get; set; }
        public string State2 { get; set; }
        public Memento CreateMemento()
        {
            return new Memento(State1, State2);
        }
        public void SetMemento(Memento memento)
        {
            this.State1 = memento.State1;
            this.State2 = memento.State2;
        }
        public void Show()
        {
            Console.WriteLine($"State1={State1}   State2={State2}");
        }
    }
}
