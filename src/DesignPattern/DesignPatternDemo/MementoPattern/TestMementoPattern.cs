using DesignPatternDemo.MementoPattern.Demo.Games;
using DesignPatternDemo.MementoPattern.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.MementoPattern
{
    public class TestMementoPattern
    {
        public static void Execute()
        {
            //Standard
            {
                Originator originator = new Originator();
                Caretaker caretaker = new Caretaker();

                //初始化originator
                originator.State1 = "原始态01";
                originator.State2 = "原始态02";
                originator.Show();

                Memento memento = originator.CreateMemento();
                caretaker.Memento = memento;

                //改变originator的信息
                originator.State1 = "变动态01";
                originator.State2 = "变动态02";
                originator.Show();

                //还原originator的信息
                originator.SetMemento(caretaker.Memento);
                originator.Show();
            }
            {
                Console.WriteLine("================ 初始化 ================");
                //初始化状态
                GameCharacter mario = new GameCharacter();
                mario.InitState();
                mario.Show();

                Console.WriteLine("================ 保存当前状态 ================");
                //保存当前状态
                GameCharacterStateMemento memento = mario.CreateMemento();
                GameCharacterStateCaretaker caretaker = new GameCharacterStateCaretaker();
                caretaker.Memento = memento;

                Console.WriteLine("================ 跟BOSS打架 ================");
                //跟BOSS打架
                mario.Fight();
                mario.Show();

                Console.WriteLine("================ 恢复存档 ================");
                //恢复存档
                mario.RecoveryState(caretaker.Memento);
                mario.Show();
            }
        }
    }
}
