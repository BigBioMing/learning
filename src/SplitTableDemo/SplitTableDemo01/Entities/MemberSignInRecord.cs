using SqlSugar;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("index_MemberId", nameof(MemberId), OrderByType.Asc)]
    [SugarIndex("index_IsDeleted", nameof(IsDeleted), OrderByType.Asc)]
    [SplitTable(SplitType.Year)]//按年分表 （自带分表支持 年、季、月、周、日）
    [SugarTable("MemberSignInRecord_{year}{month}{day}")]//3个变量必须要有，这么设计为了兼容开始按年，后面改成按月、按日
    public class MemberSignInRecord : SuperEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]//数据库是自增才配自增
        public new long Id { get; set; }
        public long MemberId { get; set; }
        public DateTime SignInTime { get; set; }
    }
}
