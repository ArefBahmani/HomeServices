using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppInfer.Db.Sql.Ef.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f209ec0-e63e-4c1e-9820-a74a160ca1e6", "AQAAAAIAAYagAAAAELxNuJL2dHCUGNg3/wB1XLY6w0R5nD/59maKy2pSKH/unO2uD7na7vAq1H6WFIQBvg==", "ddf6062e-b4c1-48af-9190-6ef9cb8c2d62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fefb7f1-cba4-44b6-98e0-bdd5b06d19bf", "AQAAAAIAAYagAAAAECpev0KcT8f57WQKofFO5T91+8+lH6DNq/TD391u7qN9pctFPgGmYL7+jm1bSHw2VQ==", "82987aec-ec73-4107-aebf-89f0c23d91e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b22831e-659c-4c0a-9f66-1f876fd7cfad", "AQAAAAIAAYagAAAAEBT3BSKGHJ6K/HNnpD77FroWeuZt56isaht9gxt1Xi76HM+gA5naMghKJm1+lvQbiA==", "83159457-0ed5-49bc-97c8-a50400f3e8c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b92ab33-c101-46e2-b9d3-306e06b1ce31", "AQAAAAIAAYagAAAAEDBVf9Xi7WSUjm3mSEmT724NjZlX4ttbZirWY1eyXV4KompwsgJhxxzCsDRs7BJxZQ==", "3a1c4ac3-7da6-4dcc-bd4d-a52fbd238a0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bd07cda-263d-4478-908c-288c7d0fb807", "AQAAAAIAAYagAAAAELOVfsUefgQlZw9eX67Bz50jZYGbDi+iLscdbJwN0Zdc7hoyL28g58d39amLTS4XWg==", "2a6aff49-62f2-4fb5-8b08-aa49b06333c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d26b730a-6d71-49e1-8edd-fdb3bad8a50d", "AQAAAAIAAYagAAAAEAv72GyOyt00ZwX63wtGmS//TmgwueU53jUlysqFEELZvZQmImDW4l9EnI6/sd1BgA==", "e0835db8-8372-407d-a954-07aac0c786b8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26f43a9f-cac0-4b13-9423-2ebba15e9158", "AQAAAAIAAYagAAAAEDtQclkEJnEZew+k5Y32GYoXiUtTFsjoaFV1KKGNQUCxAPOb4A4/Db8karpVCfd0YQ==", "3050323f-ae77-4f68-8ef4-8c8831ecfdc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "409b9f4a-4b81-464b-ab44-2baadeda3f0e", "AQAAAAIAAYagAAAAEHdH5qPi6XjwTs5a+820X7AgjguYXV3MCrkyc4se1aEXiKbtwNs9tjvJ2J3GpFu3jg==", "d0b87760-67ee-4ca8-93cd-2e7cb6373be6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc49e1a6-dd9c-478c-b2c0-a1575234a2ea", "AQAAAAIAAYagAAAAEGvXxDUBFM19mdKCnjfMx6nnWVuo3pWKgxRDzEBXtfx/NdmwwyX0LmEpayNzHXq1ag==", "274376b1-9693-473b-8a57-6a6a3e59d231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b82a35c9-ea2b-423f-a1e1-0c34b839bd69", "AQAAAAIAAYagAAAAEMo3G5ECBJOLuEqdzG3J/WSTT868zXklOeLmAGsyDpjgMaWJK348n6HaKCIGQLUiRQ==", "bc19f639-3168-43d5-a0bd-1baa167e7e07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d6477d5-368d-44b9-805e-89b9b56dd8f4", "AQAAAAIAAYagAAAAENE4mfMFAfAV7vug3DySwYZ8nr8HrPrQlJAfwx1abC4E+sv+ERfXy/OR8wfS2XNfpQ==", "352f628a-8c26-4a11-9b82-f3018ee4a634" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54c53c0a-a7e1-4560-9520-c3aef53a8e1e", "AQAAAAIAAYagAAAAEBwxp+B/NoAC+7esQP/0kJbupVo15KrRT+fN+vzl29EwxC+vxF4aa5in7QQ6ivlckw==", "602af250-67a6-49c5-b870-330c047c6377" });
        }
    }
}
