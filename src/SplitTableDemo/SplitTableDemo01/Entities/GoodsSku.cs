using SqlSugar;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_GoodsId", nameof(GoodsSku.GoodsId), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_SkuCode", nameof(GoodsSku.SkuCode), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(GoodsSku.IsDeleted), OrderByType.Asc)]
    public class GoodsSku : SuperEntity
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public long GoodsId { get; set; }

        /// <summary>
        /// SKU编码
        /// </summary>
        public string SkuCode { get; set; }
    }
}
