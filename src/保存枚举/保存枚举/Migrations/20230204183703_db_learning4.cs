using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 保存枚举.Migrations
{
    /// <inheritdoc />
    public partial class dblearning4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DetailAddress",
                table: "Addresses",
                column: "DetailAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Addresses_DetailAddress",
                table: "Addresses");
        }
    }
}
