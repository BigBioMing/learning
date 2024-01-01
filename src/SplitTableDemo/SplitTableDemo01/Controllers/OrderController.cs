using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SplitTableDemo01.Entities;
using SqlSugar;

namespace SplitTableDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ISqlSugarClient _db;
        public OrderController(ISqlSugarClient db)
        {
            this._db = db;
        }

        /// <summary>
        /// 获取会员订单列表
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMemberOrders")]
        public ActionResult GetMemberOrders(long memberId, int pageIndex, int pageSize)
        {
            int skipCount = (pageIndex - 1) * pageSize;
            var tableName = this._db.SplitHelper<Order>().GetTableName(memberId);//根据字段值获取表名
            //推荐： 表不存在不会报错
            var list = this._db.Queryable<Order>().Where(n => n.MemberId == memberId).SplitTable(tabs => tabs.InTableNames(tableName)).OrderByDescending(n => n.Id).Skip(skipCount).Take(pageSize).ToList();

            bool nextPage = list.Count == pageSize;

            return new JsonResult(new
            {
                nextPage = nextPage,
                list = list
            });
        }

        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOrderInfo")]
        public ActionResult GetOrderInfo(long memberId, long orderId)
        {
            var tableName = this._db.SplitHelper<Order>().GetTableName(memberId);//根据字段值获取表名
            var tableName2 = this._db.SplitHelper<OrderDetail>().GetTableName(memberId);//根据字段值获取表名
            var order = this._db.Queryable<Order>().Where(n => n.MemberId == memberId && n.Id == orderId).SplitTable(tabs => tabs.InTableNames(tableName)).First();
            var orderDetails = this._db.Queryable<OrderDetail>().Where(n => n.MemberId == memberId && n.Id == orderId).SplitTable(tabs => tabs.InTableNames(tableName2)).ToArray();
            return new JsonResult(new
            {
                order = order,
                orderDetails = orderDetails
            });
        }
    }
}
