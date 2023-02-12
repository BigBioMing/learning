using System.ComponentModel;

namespace CapDemo.Entities
{
    public class Order
    {
        [Description("主键")]
        public int Id { get; set; }
        [Description("名称")]
        public string Name { get; set; }
    }
}
