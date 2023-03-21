using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.MementoPattern.Demo.Games
{
    /// <summary>
    /// 游戏角色状态备忘录
    /// </summary>
    public class GameCharacterStateMemento
    {
        /// <summary>
        /// 生命值
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Aggressivity { get; set; }
        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; set; }

        public GameCharacterStateMemento(int hp, int aggressivity, int defense)
        {
            this.HP = hp;
            this.Aggressivity = aggressivity;
            this.Defense = defense;
        }
    }
}
