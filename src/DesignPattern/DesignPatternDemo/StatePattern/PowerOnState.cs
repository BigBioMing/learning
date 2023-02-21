﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.StatePattern
{
    /// <summary>
    /// 开机
    /// </summary>
    public class PowerOnState : StateAbstract
    {
        public override void Handle(StateContext context)
        {
            Console.WriteLine($"开机");
            context.SetState(new StartUpState());
        }
    }
}
