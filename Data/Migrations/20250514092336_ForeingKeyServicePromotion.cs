using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ForeingKeyServicePromotion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Promotions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_ServiceId",
                table: "Promotions",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Promotions_Services_ServiceId",
                table: "Promotions",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promotions_Services_ServiceId",
                table: "Promotions");

            migrationBuilder.DropIndex(
                name: "IX_Promotions_ServiceId",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Promotions");
        }
    }
}
