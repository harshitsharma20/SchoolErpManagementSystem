using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Result_teacherId",
                table: "Result");

            migrationBuilder.CreateIndex(
                name: "IX_Result_teacherId",
                table: "Result",
                column: "teacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Result_teacherId",
                table: "Result");

            migrationBuilder.CreateIndex(
                name: "IX_Result_teacherId",
                table: "Result",
                column: "teacherId",
                unique: true);
        }
    }
}
