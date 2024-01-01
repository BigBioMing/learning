using SqlSugar;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_GoodsNo", nameof(Goods.GoodsNo), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(Goods.IsDeleted), OrderByType.Asc)]
    public class Goods : SuperEntity
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        public string GoodsNo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 标签价
        /// </summary>
        public decimal? TagPrice { get; set; }

        /// <summary>
        /// 零售价
        /// </summary>
        public decimal? RetailPrice { get; set; }

        /// <summary>
        /// 成本价
        /// </summary>
        public decimal? CostPrice { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        public long? GoodBrandId { get; set; }
    }
}
