using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SplitTableDemo01.Entities;
using SqlSugar;

namespace SplitTableDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointHistoryController : ControllerBase
    {
        private readonly ISqlSugarClient _db;
        public PointHistoryController(ISqlSugarClient db)
        {
            this._db = db;
        }

        /// <summary>
        /// 获取会员积分列表
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMemberPoints")]
        public ActionResult GetMemberPoints(long memberId, int pageIndex, int pageSize)
        {
            int skipCount = (pageIndex - 1) * pageSize;
            var tableName = this._db.SplitHelper<PointHistory>().GetTableName(memberId);//根据字段值获取表名
            //推荐： 表不存在不会报错
            var list = this._db.Queryable<PointHistory>().Where(n => n.MemberId == memberId).SplitTable(tabs => tabs.InTableNames(tableName)).OrderByDescending(n => n.Id).Skip(skipCount).Take(pageSize).ToList();

            bool nextPage = list.Count == pageSize;

            return new JsonResult(new
            {
                nextPage = nextPage,
                list = list
            });
        }
    }
}
