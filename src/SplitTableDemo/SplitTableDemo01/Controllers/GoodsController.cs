using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SplitTableDemo01.Entities;
using SqlSugar;

namespace SplitTableDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly ISqlSugarClient _db;
        public GoodsController(ISqlSugarClient db)
        {
            this._db = db;
        }

        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodses")]
        public ActionResult GetGoodses(int pageIndex, int pageSize)
        {
            int skipCount = (pageIndex - 1) * pageSize;
            var list = this._db.Queryable<Goods>().OrderByDescending(n => n.Id).Skip(skipCount).Take(pageSize).ToList();

            var goodsIds = list.Select(n => n.Id).ToList();
            List<GoodsSku> goodsSkus = new List<GoodsSku>();
            if (goodsIds.Any())
            {
                goodsSkus = this._db.Queryable<GoodsSku>().Where(n => goodsIds.Contains(n.GoodsId)).ToList();
            }

            bool nextPage = list.Count == pageSize;

            var list2 = list.Select(n =>
            {
                var skus = goodsSkus.Where(c => c.GoodsId == n.Id).ToList();
                return new
                {
                    n.Id,
                    n.GoodsNo,
                    n.GoodsDesc,
                    n.CostPrice,
                    n.TagPrice,
                    n.RetailPrice,
                    n.CreateTime,
                    skus
                };
            });

            return new JsonResult(new
            {
                nextPage = nextPage,
                list = list2
            });
        }


        /// <summary>
        /// 获取商品详情
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetGoodsInfo")]
        public ActionResult GetGoodsInfo(long goodsId)
        {
            var goods = this._db.Queryable<Goods>().First(n => n.Id == goodsId);
            var goodsSkus = this._db.Queryable<GoodsSku>().Where(n => n.GoodsId == goodsId).ToArray();
            return new JsonResult(new
            {
                goods,
                goodsSkus
            });
        }
    }
}
