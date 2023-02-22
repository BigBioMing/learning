using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.CompositePattern
{
    public class TestCompositePattern
    {
        public static void Execute()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite compX = new Composite("Composite X");
            compX.Add(new Leaf("Leaf XA"));
            compX.Add(new Leaf("Leaf XB"));
            root.Add(compX);

            Composite compXY = new Composite("Composite XY");
            compXY.Add(new Leaf("Leaf XYA"));
            compXY.Add(new Leaf("Leaf XYB"));
            compX.Add(compXY);

            Composite compM = new Composite("Composite M");
            compM.Add(new Leaf("Leaf MA"));
            compM.Add(new Leaf("Leaf MB"));
            root.Add(compM);

            root.Display(1);
        }
    }
}
