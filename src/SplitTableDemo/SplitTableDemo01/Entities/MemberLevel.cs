using SqlSugar;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(MemberLevel.IsDeleted), OrderByType.Asc)]
    public class MemberLevel : SuperEntity
    {
        public decimal? Discount { get; set; }
        public long MgtBrandId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string LevelBenefit { get; set; }
        public string ServiceBenefit { get; set; }
        public int? ValidMonth { get; set; }
        public int? Index { get; set; }

        public long? LevelRule { get; set; }
        public int Star { get; set; }
        public string Icon { get; set; }
        public string IconColor { get; set; }
    }
}
