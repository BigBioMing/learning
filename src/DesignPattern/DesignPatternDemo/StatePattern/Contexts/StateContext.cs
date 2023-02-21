using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDemo.StatePattern.Abstractions;
using DesignPatternDemo.StatePattern.StateLogics;

namespace DesignPatternDemo.StatePattern.Contexts
{
    /// <summary>
    /// 微波炉
    /// </summary>
    public class StateContext
    {
        /// <summary>
        /// 当前状态
        /// </summary>
        protected StateAbstract CurrentState { get; private set; } = null!;

        public StateContext()
        {
            CurrentState = new PowerOnState();
        }

        /// <summary>
        /// 设置当前状态
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public StateContext SetState(StateAbstract state)
        {
            CurrentState = state;
            return this;
        }

        public virtual void Handle()
        {
            CurrentState.Handle(this);
            Thread.Sleep(1000);
        }
    }
}
