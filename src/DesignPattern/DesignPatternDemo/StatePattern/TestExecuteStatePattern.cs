using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDemo.StatePattern.Contexts;

namespace DesignPatternDemo.StatePattern
{
    public class TestExecuteStatePattern
    {
        public static void Execute()
        {
            StateContext context = new StateContext();
            context.Handle();
            context.Handle();
            context.Handle();
            context.Handle();
            context.Handle();
            context.Handle();
            context.Handle();
            context.Handle();
        }
    }
}
