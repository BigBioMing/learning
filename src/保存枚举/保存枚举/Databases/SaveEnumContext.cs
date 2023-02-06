using Microsoft.EntityFrameworkCore;
using 保存枚举.Entities;
using 保存枚举.Enums;

namespace 保存枚举.Databases
{
    public class SaveEnumContext : DbContext
    {
        public SaveEnumContext()
        {
        }
        //public SaveEnumContext(DbContextOptions options) : base(options)
        //{
        //}

        public SaveEnumContext(DbContextOptions<SaveEnumContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Id).ValueGeneratedOnAdd().IsRequired();
                entity.Property(n => n.DetailAddress).HasColumnType("varchar(150)").IsRequired();
                entity.Property(n => n.AddressType).HasMaxLength(30).HasConversion(n => n.ToString(), n => (AddressType)Enum.Parse(typeof(AddressType), n));
                entity.HasIndex(n => n.DetailAddress);
            });
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql("Data Source=110.40.157.54;Database=db_learning;User ID=root;Password=123456;port=10902;allowPublicKeyRetrieval=true;pooling=true;CharSet=utf8mb4;sslmode=none;AllowLoadLocalInfile=true;", new MySqlServerVersion(new Version(5, 7, 36)))
        //        .LogTo(Console.WriteLine, LogLevel.Information)
        //            .EnableSensitiveDataLogging()
        //            .EnableDetailedErrors();
        //}
    }
}
