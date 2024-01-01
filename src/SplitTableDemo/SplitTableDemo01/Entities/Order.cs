using SplitTableDemo01.sts;
using SqlSugar;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_MemberId", nameof(Order.MemberId), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(Order.IsDeleted), OrderByType.Asc)]
    //[SplitTable(SplitType._Custom01)]
    [SplitTable(SplitType._Custom01, typeof(CustomSplitTableService))]
    public class Order : SuperEntity
    {
        public string Code { get; set; }
        public string ReturnCode { get; set; }
        public long? CurrencyId { get; set; }
        public long? OrgId { get; set; }

        public long? ChannelId { get; set; }

        [SplitField] //标识一下分表字段
        public long MemberId { get; set; }

        //public string SupplierCode { get; set; }


        /// <summary>
        /// 订单状态
        /// </summary>
        public long StatusId { get; set; }
        public decimal? Payment { get; set; }
        //   public string ClerkNumber { get; set; }
        public DateTime? OrderTime { get; set; }
        public DateTime? PayTime { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Discount { get; set; }
        public long? LevelId { get; set; }

        public decimal? DiscountAmount { get; set; }
        public string Memo { get; set; }
        public decimal? StandardAmount { get; set; }

        public long? ConsigneeId { get; set; }
    }
}
