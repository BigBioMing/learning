using Microsoft.EntityFrameworkCore;
using 保存枚举.Databases;

namespace 保存枚举
{
    public static class DbExtensions
    {
        public static IServiceCollection AddDbService(this IServiceCollection services, IConfiguration configuration)
        {
            // Replace with your connection string.
            var connectionString = configuration["Database:ConnectionString"];

            // Replace with your server version and type.
            // Use 'MariaDbServerVersion' for MariaDB.
            // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
            // For common usages, see pull request #1233.
            var serverVersion = new MySqlServerVersion(new Version(5, 7, 36));

            // Replace 'YourDbContext' with the name of your own DbContext derived class.
            services.AddDbContext<SaveEnumContext>(
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
    }
}
