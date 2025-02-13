using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppInfer.Db.Sql.Ef.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "BidPrice",
                value: 150000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "BidPrice",
                value: 400000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "BidPrice",
                value: 320000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "BidPrice",
                value: 860000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "BidPrice",
                value: 600000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "BidPrice",
                value: 750000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "BidPrice",
                value: 400000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "BidPrice",
                value: 500000m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "BidPrice",
                value: 10000m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "BidPrice",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "BidPrice",
                value: 0m);
        }
    }
}
