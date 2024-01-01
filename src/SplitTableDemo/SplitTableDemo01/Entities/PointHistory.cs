using SplitTableDemo01.sts;
using SqlSugar;
using System.ComponentModel.DataAnnotations.Schema;

namespace SplitTableDemo01.Entities
{
    [SugarIndex("{table}index_codetable1_MemberId", nameof(PointHistory.MemberId), OrderByType.Asc)]
    [SugarIndex("{table}index_codetable1_IsDeleted", nameof(PointHistory.IsDeleted), OrderByType.Asc)]
    //[SplitTable(SplitType._Custom01)]
    [SplitTable(SplitType._Custom01, typeof(CustomSplitTableService))]
    public class PointHistory : SuperEntity
    {
        /// <summary>
        /// 会员Id
        /// </summary>
        [SplitField] //标识一下分表字段
        public long MemberId { get; set; }

        /// <summary>
        /// 积分变动归属机构Id
        /// </summary>
        public long? OrgId { get; set; }

        /// <summary>
        /// 变动的积分数
        /// </summary>
        public decimal? ChangedIntegral { get; set; }

        /// <summary>
        /// 该笔积分剩余数（先进先出扣减后的剩余）
        /// </summary>
        public decimal? RemainIntegral { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime? ValidTime { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? DeadLine { get; set; }

        /// <summary>
        /// 产生该积分流水的时间
        /// </summary>
        public DateTime? ChangedTime { get; set; }

        /// <summary>
        /// 积分变动类型（取自sys_dic_item，例如：注册入会送分）
        /// </summary>
        public long? ChangedTypeId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 引擎流程Id
        /// </summary>
        public string ProcessId { set; get; }

        /// <summary>
        /// 关联的交易订单Id
        /// </summary>
        public long? OrderId { set; get; }

        /// <summary>
        /// 关联的交易订单明细Id
        /// </summary>
        public long? OrderDetailId { set; get; }

        /// <summary>
        /// 积分规则ID
        /// </summary>
        public long? PointAddRuleId { get; set; }
    }
}
