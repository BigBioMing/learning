using SqlSugar;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(PointTask.IsDeleted), OrderByType.Asc)]
    public class PointTask : SuperEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Status { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Rule { get; set; }
        public string Intro { get; set; }
    }
}
