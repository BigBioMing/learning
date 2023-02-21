using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.BuilderPattern.Models
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string partName)
        {
            _parts.Add(partName);
        }

        public string View()
        {
            return $"{string.Join(" ", _parts)}";
        }
    }
}
