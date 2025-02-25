using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppInfer.Db.Sql.Ef.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75215198-b3df-4183-afd7-25eebfcec767", "AQAAAAIAAYagAAAAEMDMO3vG3ukt6P/rcVnzyFuIribDnQuPla0rKsUv2Pqme0aeabGlNeDHaUKnvQArww==", "17a9b230-7060-4657-ac35-cb38a7fc3acd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faed8428-5b59-4b3d-b372-82afdcbd90cb", "AQAAAAIAAYagAAAAENFbOszbSLQMnPpOACqfTo644imWUz2PXpd7jQAd6f+U0sHcnFrzAoKT3aZcp1VfNA==", "5f4660b3-a96a-4f2c-853d-3f2b39f0d8eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "675c5e7f-bce3-4202-9a2b-40c2507b1199", "AQAAAAIAAYagAAAAEIofl400SuLdApz61dVCd093dGuwQG4oK4g3KRzOe6EhLMlxR1vDMpgYyKS+ixLEJg==", "60268cf7-8671-440b-9e23-ef39aa86c47c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58c5c9bb-41ae-4d86-ade3-fc6c45bbe28f", "AQAAAAIAAYagAAAAEOdnvn2IcUQVn1U7sLhuE9Lj0WWo1Va6PMiaReJBKmA4L+l7uHV8fDqy7NFk8HwrfQ==", "605922ca-0d85-426e-83e8-672fd69c1457" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9735e052-7606-44d5-90d4-a699a66e7b00", "AQAAAAIAAYagAAAAEKZUxUbS6ugNKO2fDSosBSd21O3uGbeLSZ9/CFG0gAmEVcOIyRMYZXS2J0Rz7XzFlA==", "592b06b3-362a-4d84-8d6e-6841e13e423f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e2563ca-642f-46f2-b66a-f79311373b06", "AQAAAAIAAYagAAAAECdfp9fmG3/EFok1yRTkzkD1Xqru4YF9TK0ba79v98e9S3cPZug/Mt2nSZxQs1tjoQ==", "0090d060-97eb-46c0-beec-e4f3e44f3f2b" });
        }
    }
}
