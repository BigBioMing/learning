using SqlSugar;

namespace SplitTableDemo01.Dbs
{
    public static class DbContextExtension
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            SnowFlakeSingle.WorkId = 1;
            services.AddScoped<ISqlSugarClient>(s =>
            {
                //Scoped用SqlSugarClient 
                SqlSugarClient sqlSugar = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.MySql,
                    ConnectionString = "server=42.192.219.38;port=10902;Database=test001;Uid=root;Pwd=8e3Ds74YeH8u;AllowLoadLocalInfile=true",
                    IsAutoCloseConnection = true,
                },
               db =>
               {
                   //每次上下文都会执行

                   //获取IOC对象不要求在一个上下文
                   //vra log=s.GetService<Log>()

                   //获取IOC对象要求在一个上下文
                   //var appServive = s.GetService<IHttpContextAccessor>();
                   //var log= appServive?.HttpContext?.RequestServices.GetService<Log>();

                   db.Aop.OnLogExecuting = (sql, pars) =>
                   {
                       Serilog.Log.Information(sql, pars);
                   };
               });
                return sqlSugar;
            });

            return services;
        }
    }
}
