using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SplitTableDemo01.Entities;
using SqlSugar;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SplitTableDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly ISqlSugarClient _db;
        public MemberController(ISqlSugarClient db)
        {
            this._db = db;
        }

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMemberInfo")]
        public ActionResult GetMemberInfo(long memberId)
        {
            //var member = this._db.Queryable<Member>().Where(n => n.Id == memberId).SplitTable().First();

            var tableName = this._db.SplitHelper<Member>().GetTableName(memberId);//根据字段值获取表名
            //推荐： 表不存在不会报错
            var member = this._db.Queryable<Member>().Where(n => n.Id == memberId).SplitTable().First();
            //var member = this._db.Queryable<Member>().Where(n => n.Id == memberId).SplitTable(tabs => tabs.InTableNames(tableName)).First();

            return new JsonResult(new
            {
                Exists = member != null,
                Mobile = member?.Mobile,
                CardNumber = member?.CardNumber,
                ValidDate = member?.ValidDate,
                ChineseName = member?.ChineseName
            });
        }

        /// <summary>
        /// 获取会员可用积分
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMemberValidatePoint")]
        public ActionResult GetMemberValidatePoint(long memberId)
        {
            var tableName = this._db.SplitHelper<PointHistory>().GetTableName(memberId);//根据字段值获取表名
            decimal? remainIntegral = this._db.Queryable<PointHistory>().Where(n => n.MemberId == memberId).SplitTable(tabs => tabs.InTableNames(tableName)).Sum(n => n.RemainIntegral);

            return new JsonResult(new
            {
                remainIntegral
            });
        }

        /// <summary>
        /// 获取会员是否已签到
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMemberIsSignIn")]
        public ActionResult GetMemberIsSignIn(long memberId)
        {
            var tableName = this._db.SplitHelper<MemberSignInRecord>().GetTableName(DateTime.Now);//根据时间获取表名
            //推荐： 表不存在不会报错
            bool isSignIn = this._db.Queryable<MemberSignInRecord>().Where(n => n.MemberId == memberId).SplitTable(tabs => tabs.InTableNames(tableName)).Any();

            return new JsonResult(new
            {
                isSignIn
            });
        }

        /// <summary>
        /// 获取会员等级
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMemberLevel")]
        public ActionResult GetMemberLevel(long memberId)
        {
            MemberLevel memberLevel = null;
            var tableName = this._db.SplitHelper<Member>().GetTableName(memberId);//根据字段值获取表名
            //推荐： 表不存在不会报错
            var member = this._db.Queryable<Member>().Where(n => n.Id == memberId).SplitTable(tabs => tabs.InTableNames(tableName)).First();
            bool exists = member != null;
            if (exists)
            {
                memberLevel = this._db.Queryable<MemberLevel>().First(n => n.Id == member.LevelId);
            }

            return new JsonResult(new
            {
                Exists = member != null,
                MemberLevelCode = memberLevel?.Code,
                MemberLevelName = memberLevel?.Name,
                Icon = memberLevel?.Icon,
                IconColor = memberLevel?.IconColor
            });
        }
    }
}
