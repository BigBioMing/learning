using 保存枚举.Enums;

namespace 保存枚举.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string DetailAddress { get; set; } = null!;
        public AddressType AddressType { get; set; }
        public DeliveryPreference DeliveryPreference { get; set; }
    }
}
