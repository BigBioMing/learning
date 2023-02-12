using CapDemo.Entities;
using CapDemo.Services;
using Microsoft.EntityFrameworkCore;

namespace CapDemo
{
    public static class Extensions
    {
        public static IServiceCollection AddCapDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Replace with your connection string.
            var connectionString = configuration["Database:ConnectionString"];

            // Replace with your server version and type.
            // Use 'MariaDbServerVersion' for MariaDB.
            // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
            // For common usages, see pull request #1233.
            var serverVersion = new MySqlServerVersion(new Version(5, 7, 36));

            // Replace 'YourDbContext' with the name of your own DbContext derived class.
            services.AddDbContext<CapDbContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(connectionString, serverVersion)
                    // The following three options help with debugging, but should
                    // be changed or removed for production.
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
            );

            return services;
        }

        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCap(options =>
            {
                var connectionString = configuration["Database:ConnectionString"];
                //options.UseEntityFramework<CapDbContext>();
                options.UseMySql(connectionString);
                //options.UseMySql(connectionString);
                options.UseRabbitMQ(options =>
                {
                    //options.HostName = configuration["RabbitMQ:HostName"];
                    //options.Port = Convert.ToInt32(configuration["RabbitMQ:Port"]);
                    //options.VirtualHost = configuration["RabbitMQ:VirtualHost"];
                    //options.ExchangeName = configuration["RabbitMQ:ExchangeName"];
                    //options.UserName = configuration["RabbitMQ:UserName"];
                    //options.Password = configuration["RabbitMQ:Password"];
                    configuration.GetSection("RabbitMQ").Bind(options);
                });
            });

            return services;
        }
    }
}
