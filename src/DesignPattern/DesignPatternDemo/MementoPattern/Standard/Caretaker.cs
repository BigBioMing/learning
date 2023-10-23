using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.MementoPattern.Standard
{
    /// <summary>
    /// 管理者（存储备忘录的类）
    /// </summary>
    public class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
