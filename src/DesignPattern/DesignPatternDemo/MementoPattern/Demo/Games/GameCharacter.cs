using DesignPatternDemo.MementoPattern.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.MementoPattern.Demo.Games
{
    /// <summary>
    /// 游戏角色类
    /// </summary>
    public class GameCharacter
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

        /// <summary>
        /// 创建角色状态备忘
        /// </summary>
        /// <returns></returns>
        public GameCharacterStateMemento CreateMemento()
        {
            return new GameCharacterStateMemento(this.HP, this.Aggressivity, this.Defense);
        }

        /// <summary>
        /// 恢复角色状态
        /// </summary>
        /// <returns></returns>
        public void RecoveryState(GameCharacterStateMemento memento)
        {
            this.HP = memento.HP;
            this.Aggressivity = memento.Aggressivity;
            this.Defense = memento.Defense;
        }

        public void Show()
        {
            Console.WriteLine($"生命值：{this.HP}{Environment.NewLine}攻击力：{this.Aggressivity}{Environment.NewLine}防御力：{this.Defense}");
        }

        #region 其他代码
        public void InitState()
        {
            this.HP = 100;
            this.Aggressivity = 100;
            this.Defense = 100;
        }
        public void Fight()
        {
            Console.WriteLine($"跟BOSS打架...");
            this.HP = 20;
            this.Aggressivity = 50;
            this.Defense = 30;
        }
        #endregion
    }
}
