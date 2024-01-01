using SplitTableDemo01.sts;
using SqlSugar;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_CardNumber", nameof(Member.CardNumber), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_Mobile", nameof(Member.Mobile), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(Member.IsDeleted), OrderByType.Asc)]
    //[SplitTable(SplitType._Custom01)]
    [SplitTable(SplitType._Custom01, typeof(CustomSplitTableService))]
    public class Member : SuperEntity
    {
        [SugarColumn(IsPrimaryKey = true)]
        [SplitField] //标识一下分表字段
        public new long Id { get; set; }
        public long CustomerId { get; set; }
        public long BrandId { get; set; }
        public long LevelId { get; set; }
        public string CardNumber { get; set; }

        //UserId、OrgId移至member_user_bind表
        public long UserId { get; set; }
        public long OrgId { get; set; }
        public long RegistOrgId { get; set; }
        public long RegistUserId { get; set; }
        public long Source { get; set; }
        /// <summary>
        /// 二级入会渠道
        /// </summary>
        public long SubChannelId { get; set; }
        /// <summary>
        /// 会员状态,枚举EnumMemberStatus 104:销户;105:正常;106:冻结;107:被合并
        /// </summary>
        public long Status { get; set; }

        public DateTime ValidDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Mobile { get; set; }

        public string Code { get; set; }
        public string OnLineNickName { get; set; }
        public string ChineseName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
