using SplitTableDemo01.sts;
using SqlSugar;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_MemberId", nameof(OrderDetail.MemberId), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_OrderId", nameof(OrderDetail.OrderId), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(OrderDetail.IsDeleted), OrderByType.Asc)]
    //[SplitTable(SplitType._Custom01)]
    [SplitTable(SplitType._Custom01, typeof(CustomSplitTableService))]
    public class OrderDetail : SuperEntity
    {

        [SplitField] //标识一下分表字段
        public long MemberId { get; set; }
        public int? ReturnNum { get; set; }
        public long OrderId { get; set; }
        public long? SkuId { get; set; }

        public string SkuDescription { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Payment { get; set; }
        public decimal? Price { get; set; }
        public decimal? TagPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? CounterPrice { get; set; }
        public string SupplierCode { get; set; }
    }
}
