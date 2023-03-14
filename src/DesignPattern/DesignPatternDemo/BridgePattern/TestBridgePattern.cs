using DesignPatternDemo.BridgePattern.Concretes.Implementors;
using DesignPatternDemo.BridgePattern.Concretes.RefinedAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BridgePattern
{
    public class TestBridgePattern
    {
        public static void Execute()
        {
            RefinedAbstractionA refinedAbstractionA = new RefinedAbstractionA();

            refinedAbstractionA.SetImplementor(new ImplementorX());
            refinedAbstractionA.Opertaion();

            refinedAbstractionA.SetImplementor(new ImplementorY());
            refinedAbstractionA.Opertaion();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            RefinedAbstractionB refinedAbstractionB = new RefinedAbstractionB();

            refinedAbstractionB.SetImplementor(new ImplementorX());
            refinedAbstractionB.Opertaion();

            refinedAbstractionB.SetImplementor(new ImplementorY());
            refinedAbstractionB.Opertaion();
        }
    }
}
