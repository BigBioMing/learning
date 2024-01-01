using Microsoft.AspNetCore.Components.Web;
using SqlSugar;

namespace SplitTableDemo01.Entities
{
    public class SuperEntity
    {
        [SugarColumn(IsPrimaryKey = true)]
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateSource { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UpdateSource { get; set; }
    }
}
