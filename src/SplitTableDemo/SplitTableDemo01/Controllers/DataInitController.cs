using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SplitTableDemo01.Entities;
using SqlSugar;

namespace SplitTableDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataInitController : ControllerBase
    {
        private readonly ISqlSugarClient _db;
        public DataInitController(ISqlSugarClient db)
        {
            this._db = db;
        }

        [HttpPost]
        [Route("Init")]
        public ActionResult Init()
        {
            #region member
            List<Member> allMembers = new List<Member>();
            while (allMembers.Count < 30000000)
            {
                List<PointHistory> pointHistories = new List<PointHistory>();
                List<Order> orders = new List<Order>();
                List<OrderDetail> orderDetails = new List<OrderDetail>();
                List<Member> members = new List<Member>();
                for (int i = 0; i <= 500000; i++)
                {
                    long memberId = SnowFlakeSingle.Instance.NextId();
                    var member = new Member()
                    {
                        Id = memberId,
                        Mobile = $"{memberId}",
                        EndDate = DateTime.Now,
                        ValidDate = DateTime.Now,
                        BrandId = i % 5,
                        CardNumber = $"{memberId}",
                        ChineseName = $"{memberId}",
                        Code = $"{memberId}",
                        CustomerId = memberId,
                        FirstName = $"{memberId}",
                        LastName = $"{memberId}",
                        LevelId = i % 5,
                        OrgId = i % 5,
                        OnLineNickName = $"{memberId}",
                        RegistOrgId = i % 5,
                        RegistUserId = i % 5,
                        Source = i % 5,
                        Status = i % 5,
                        SubChannelId = i % 5,
                        UserId = i % 5,
                        IsDeleted = false,
                        CreateSource = $"{memberId}",
                        CreateTime = DateTime.Now,
                        UpdateSource = $"{memberId}",
                        UpdateTime = DateTime.Now
                    };

                    members.Add(member);
                    allMembers.Add(member);


                    int orderCount = Random.Shared.Next(1, 3);
                    if (i % 10000 == 0) orderCount = 8;
                    if (i % 100000 == 0) orderCount = 23;
                    if (i % 2 == 0) orderCount = 0;
                    if (orderCount > 0)
                    {
                        for (int j = 0; j < orderCount; j++)
                        {
                            long orderId = SnowFlakeSingle.Instance.NextId();
                            Order order = new Order()
                            {
                                Id = orderId,
                                Discount = 1,
                                DiscountAmount = Random.Shared.Next(),
                                ChannelId = i % 5,
                                Code = $"{orderId}",
                                LevelId = i % 5,
                                OrgId = i % 5,
                                MemberId = member.Id,
                                Payment = Random.Shared.Next(),
                                PayTime = DateTime.Now,
                                OrderTime = DateTime.Now,
                                Quantity = Random.Shared.Next(),
                                StandardAmount = Random.Shared.Next(),
                                StatusId = i % 5,
                                IsDeleted = false,
                                CreateSource = $"{memberId}",
                                CreateTime = DateTime.Now,
                                UpdateSource = $"{memberId}",
                                UpdateTime = DateTime.Now
                            };

                            int orderDetailCount = Random.Shared.Next(1, 3);
                            if (i % 5 == 0) orderDetailCount = 1;
                            for (int k = 0; k < orderDetailCount; k++)
                            {
                                long orderDetailId = SnowFlakeSingle.Instance.NextId();
                                OrderDetail orderDetail = new OrderDetail()
                                {
                                    Id = orderDetailId,
                                    Discount = 1,
                                    OrderId = order.Id,
                                    Price = Random.Shared.Next(),
                                    SkuId = Random.Shared.Next(1, 10000),
                                    TagPrice = Random.Shared.Next(),
                                    CounterPrice = Random.Shared.Next(1, 1100),
                                    MemberId = member.Id,
                                    Payment = Random.Shared.Next(),
                                    Quantity = Random.Shared.Next(),
                                    IsDeleted = false,
                                    CreateSource = $"{memberId}",
                                    CreateTime = DateTime.Now,
                                    UpdateSource = $"{memberId}",
                                    UpdateTime = DateTime.Now
                                };
                                orderDetails.Add(orderDetail);
                            }
                            orders.Add(order);
                        }


                        int pintHistoryCount = Random.Shared.Next(1, 2);
                        if (i % 10000 == 0) pintHistoryCount = 8;
                        if (i % 100000 == 0) pintHistoryCount = 23;
                        if (i % 2 == 0) pintHistoryCount = 0;
                        if (pintHistoryCount > 0)
                        {
                            for (int j = 0; j < pintHistoryCount; j++)
                            {
                                long pintHistoryId = SnowFlakeSingle.Instance.NextId();
                                PointHistory pintHistory = new PointHistory()
                                {
                                    Id = pintHistoryId,
                                    OrgId = i % 5,
                                    MemberId = member.Id,
                                    DeadLine = DateTime.Now,
                                    Description = $"{Random.Shared.Next()}",
                                    OrderDetailId = 0,
                                    OrderId = 0,
                                    PointAddRuleId = 0,
                                    ChangedIntegral = Random.Shared.Next(),
                                    ChangedTime = DateTime.Now,
                                    ChangedTypeId = Random.Shared.Next(1, 10),
                                    RemainIntegral = Random.Shared.Next(),
                                    ValidTime = DateTime.Now,
                                    ProcessId = $"{Random.Shared.Next()}",
                                    IsDeleted = false,
                                    CreateSource = $"{memberId}",
                                    CreateTime = DateTime.Now,
                                    UpdateSource = $"{memberId}",
                                    UpdateTime = DateTime.Now
                                };
                                pointHistories.Add(pintHistory);
                            }
                        }
                    }


                }



                this._db.Fastest<Member>().SplitTable().BulkCopy(members);//自动找表大数据写入
                this._db.Fastest<Order>().SplitTable().BulkCopy(orders);//自动找表大数据写入
                this._db.Fastest<OrderDetail>().SplitTable().BulkCopy(orderDetails);//自动找表大数据写入
                this._db.Fastest<PointHistory>().SplitTable().BulkCopy(pointHistories);//自动找表大数据写入
            }



            #endregion


            return Ok();
        }



        [HttpPost]
        [Route("InitShortTable")]
        public ActionResult InitShortTable()
        {
            this._db.CodeFirst.SetStringDefaultLength(200)
            .InitTables(typeof(PointTask), typeof(MemberLevel), typeof(Goods), typeof(GoodsSku));

            List<PointTask> pointTasks = new List<PointTask>();
            List<MemberLevel> memberLevels = new List<MemberLevel>();
            for (int i = 0; i < 20; i++)
            {
                long id = i + 1;

                pointTasks.Add(new PointTask()
                {
                    Id = i,
                    Code = $"task_{i}",
                    Name = $"任务_{i}",
                    Description = $"任务描述_{i}",
                    Status = true,
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    Icon = $"taskicon_{i}",
                    Intro = $"Intro_{i}",
                    Rule = $"Rule_{i}",
                    IsDeleted = false,
                    CreateSource = $"{i}",
                    CreateTime = DateTime.Now,
                    UpdateSource = $"{i}",
                    UpdateTime = DateTime.Now
                });
                memberLevels.Add(new MemberLevel()
                {
                    Id = i,
                    Code = $"level_{i}",
                    Name = $"会员等级_{i}",
                    Icon = $"levelicon_{i}",
                    Discount = 1,
                    IconColor = $"leveliconcolor_{i}",
                    Index = i,
                    IsDeleted = false,
                    CreateSource = $"{i}",
                    CreateTime = DateTime.Now,
                    UpdateSource = $"{i}",
                    UpdateTime = DateTime.Now
                });
            }
            this._db.Fastest<PointTask>().BulkCopy(pointTasks);//自动找表大数据写入
            this._db.Fastest<MemberLevel>().BulkCopy(memberLevels);//自动找表大数据写入




            List<Goods> goodses = new List<Goods>();
            List<GoodsSku> goodsSkus = new List<GoodsSku>();
            for (int i = 0; i < 20000; i++)
            {
                long id = i + 1;

                goodses.Add(new Goods()
                {
                    Id = id,
                    GoodsDesc = $"商品{i}",
                    CostPrice = Random.Shared.Next(),
                    RetailPrice = Random.Shared.Next(),
                    TagPrice = Random.Shared.Next(),
                    GoodBrandId = i % 5,
                    GoodsNo = $"{i}",
                    IsDeleted = false,
                    CreateSource = $"{i}",
                    CreateTime = DateTime.Now,
                    UpdateSource = $"{i}",
                    UpdateTime = DateTime.Now
                });
                goodsSkus.Add(new GoodsSku()
                {
                    Id = i,
                    GoodsId = id,
                    SkuCode = $"{i}",
                    IsDeleted = false,
                    CreateSource = $"{i}",
                    CreateTime = DateTime.Now,
                    UpdateSource = $"{i}",
                    UpdateTime = DateTime.Now
                });
            }
            this._db.Fastest<Goods>().BulkCopy(goodses);//自动找表大数据写入
            this._db.Fastest<GoodsSku>().BulkCopy(goodsSkus);//自动找表大数据写入

            return Ok();
        }


        [HttpPost]
        [Route("InitSignIn")]
        public ActionResult InitSignIn()
        {
            var memberSignInRecords = new List<MemberSignInRecord>();
            for (int i = 0; i < 10; i++)
            {
                memberSignInRecords.Add(new MemberSignInRecord
                {
                    MemberId = 1,
                    SignInTime = DateTime.Now,
                    IsDeleted = false,
                    CreateSource = $"aaaaa",
                    CreateTime = DateTime.Now,
                    UpdateSource = $"aaaaa",
                    UpdateTime = DateTime.Now
                });
            }

            this._db.Fastest<MemberSignInRecord>().SplitTable().BulkCopy(memberSignInRecords);//自动找表大数据写入
            return Ok();
        }
    }
}
