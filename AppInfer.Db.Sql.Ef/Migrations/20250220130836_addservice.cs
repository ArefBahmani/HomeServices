using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppInfer.Db.Sql.Ef.Migrations
{
    /// <inheritdoc />
    public partial class addservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CategoryServices",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "CategoryServices",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "CategoryServices");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd3e2096-42c6-4f11-b831-51a6ba728da7", "AQAAAAIAAYagAAAAEMTQhbFisDPLSXYfZB9bXuyrfT8Ro+8CET2l3jYyqj3BwtgXWUb/rWlKv/ElB0s2OQ==", "5acdf593-43c0-4302-ab38-30deae8deced" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b24439f3-791d-4c1c-a4c7-e60902deee03", "AQAAAAIAAYagAAAAEJYqrMaVX1c9wFJ5a166Vtw2rqK8y6OXGBEjbxy7qy0dt/A1LY/VVrCNHUZEh2vt7g==", "e50b9f72-2bb8-43a6-bd29-e20ff5f92a89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a01c7c97-b87d-4cc4-9a5c-c07ee510a579", "AQAAAAIAAYagAAAAENd6OmX+rIKsXJKJYQuilCvyme7Rncz31mkcx1O1V2m4kah/Zwt3MmiywQR+k+pI3g==", "89614e26-ed7a-4f4b-bdc0-39573f50e069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a3b6ee7-e8a8-4898-93e8-b63b65f64dec", "AQAAAAIAAYagAAAAEL86AeEYc44dU0TWi9VQkxuV2kRpBqVxgasjODEnCSIq7a/wDP65ocl8lWlIY8xexw==", "248f1263-6710-40e8-bb7d-80e6640778e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12d13936-75ae-47f4-9db3-79d0fad6a85b", "AQAAAAIAAYagAAAAEBlOOAozsdnHiGviNC5AijTkEJdBKu7o5Nc/shKFoXllyowq7UNcO6pu88V/PR33uA==", "97fafff7-8f38-4631-842a-50d3de470aad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3b23d96-6f45-4956-9e95-674113617968", "AQAAAAIAAYagAAAAENuzvFPg96J6rlC2WvA9sSuLbpO77IoR0xDWZPHQNwq7JlO6DOdmC6kRgHwdxLPTeQ==", "1b3de93e-2a4e-4726-a707-5c29686e451a" });
        }
    }
}
