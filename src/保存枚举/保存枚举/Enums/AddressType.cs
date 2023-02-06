using System.ComponentModel;

namespace 保存枚举.Enums
{
    public enum AddressType
    {
        /// <summary>
        /// 仙界
        /// </summary>
        [Description("仙界")]
        Fairyland = 0,
        /// <summary>
        /// 人间
        /// </summary>
        [Description("人间")]
        HumanWorld = 1,
        /// <summary>
        /// 灵界
        /// </summary>
        [Description("灵界")]
        SpiritualWorld = 2,
    }
}
