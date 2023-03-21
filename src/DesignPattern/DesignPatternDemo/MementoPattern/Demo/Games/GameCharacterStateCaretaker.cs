using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.MementoPattern.Demo.Games
{
    /// <summary>
    /// 游戏角色状态管理者类
    /// </summary>
    public class GameCharacterStateCaretaker
    {
        public GameCharacterStateMemento Memento { get; set; }
    }
}
