using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppInfer.Db.Sql.Ef.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    ImageProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    CreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    ImageProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false),
                    CreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SaveTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reaction = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BidPrice = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryServices_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryServiceExpert",
                columns: table => new
                {
                    CategoryServicesId = table.Column<int>(type: "int", nullable: false),
                    ExpertsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryServiceExpert", x => new { x.CategoryServicesId, x.ExpertsId });
                    table.ForeignKey(
                        name: "FK_CategoryServiceExpert_CategoryServices_CategoryServicesId",
                        column: x => x.CategoryServicesId,
                        principalTable: "CategoryServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryServiceExpert_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountExpert = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryServiceId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_CategoryServices_CategoryServiceId",
                        column: x => x.CategoryServiceId,
                        principalTable: "CategoryServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Suggestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    SuggestionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suggestions_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpertSuggestion",
                columns: table => new
                {
                    ExpertsId = table.Column<int>(type: "int", nullable: false),
                    SuggestionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertSuggestion", x => new { x.ExpertsId, x.SuggestionsId });
                    table.ForeignKey(
                        name: "FK_ExpertSuggestion_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertSuggestion_Suggestions_SuggestionsId",
                        column: x => x.SuggestionsId,
                        principalTable: "Suggestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Expert", "EXPERT" },
                    { 3, null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "dd3e2096-42c6-4f11-b831-51a6ba728da7", "Admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEMTQhbFisDPLSXYfZB9bXuyrfT8Ro+8CET2l3jYyqj3BwtgXWUb/rWlKv/ElB0s2OQ==", "09913466961", false, "5acdf593-43c0-4302-ab38-30deae8deced", false, "Admin@gmail.com" },
                    { 2, 0, "b24439f3-791d-4c1c-a4c7-e60902deee03", "Hosein@gmail.com", false, false, null, "HOSEIN@GMAIL.COM", "HOSEIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJYqrMaVX1c9wFJ5a166Vtw2rqK8y6OXGBEjbxy7qy0dt/A1LY/VVrCNHUZEh2vt7g==", "09913466961", false, "e50b9f72-2bb8-43a6-bd29-e20ff5f92a89", false, "Hosein@gmail.com" },
                    { 3, 0, "a01c7c97-b87d-4cc4-9a5c-c07ee510a579", "Javad@gmail.com", false, false, null, "JAVAD@GMAIL.COM", "JAVAD@GMAIL.COM", "AQAAAAIAAYagAAAAENd6OmX+rIKsXJKJYQuilCvyme7Rncz31mkcx1O1V2m4kah/Zwt3MmiywQR+k+pI3g==", "09913466961", false, "89614e26-ed7a-4f4b-bdc0-39573f50e069", false, "Javad@gmail.com" },
                    { 4, 0, "5a3b6ee7-e8a8-4898-93e8-b63b65f64dec", "Aref@gmail.com", false, false, null, "AREF@GMAIL.COM", "AREF@GMAIL.COM", "AQAAAAIAAYagAAAAEL86AeEYc44dU0TWi9VQkxuV2kRpBqVxgasjODEnCSIq7a/wDP65ocl8lWlIY8xexw==", "09913466961", false, "248f1263-6710-40e8-bb7d-80e6640778e5", false, "Aref@gmail.com" },
                    { 5, 0, "12d13936-75ae-47f4-9db3-79d0fad6a85b", "Saeid@gmail.com", false, false, null, "SAEID@GMAIL.COM", "SAEID@GMAIL.COM", "AQAAAAIAAYagAAAAEBlOOAozsdnHiGviNC5AijTkEJdBKu7o5Nc/shKFoXllyowq7UNcO6pu88V/PR33uA==", "09913466961", false, "97fafff7-8f38-4631-842a-50d3de470aad", false, "Saeid@gmail.com" },
                    { 6, 0, "c3b23d96-6f45-4956-9e95-674113617968", "Sahar@gmail.com", false, false, null, "SAHAR@GMAIL.COM", "SAHAR@GMAIL.COM", "AQAAAAIAAYagAAAAENuzvFPg96J6rlC2WvA9sSuLbpO77IoR0xDWZPHQNwq7JlO6DOdmC6kRgHwdxLPTeQ==", "09913466961", false, "1b3de93e-2a4e-4726-a707-5c29686e451a", false, "Sahar@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "تمیزکاری" },
                    { 2, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "ساختمان" },
                    { 3, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "تعمیرات اشیا" },
                    { 4, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "اسباب کشی و حمل بار" },
                    { 5, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "خودرو" },
                    { 6, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "سلامت و زیبایی" },
                    { 7, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "سایر" },
                    { 8, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "سازمان ها و مجتمع ها" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "آذربایجان شرقی" },
                    { 2, "آذربایجان غربی" },
                    { 3, "اردبیل" },
                    { 4, "اصفهان" },
                    { 5, "البرز" },
                    { 6, "ایلام" },
                    { 7, "بوشهر" },
                    { 8, "تهران" },
                    { 9, "چهارمحال و بختیاری" },
                    { 10, "خراسان جنوبی" },
                    { 11, "خراسان رضوی" },
                    { 12, "خراسان شمالی" },
                    { 13, "خوزستان" },
                    { 14, "زنجان" },
                    { 15, "سمنان" },
                    { 16, "سیستان و بلوچستان" },
                    { 17, "فارس" },
                    { 18, "قزوین" },
                    { 19, "قم" },
                    { 20, "کردستان" },
                    { 21, "کرمان" },
                    { 22, "کرمانشاه" },
                    { 23, "کهگیلویه و بویراحمد" },
                    { 24, "گلستان" },
                    { 25, "گیلان" },
                    { 26, "لرستان" },
                    { 27, "مازندران" },
                    { 28, "مرکزی" },
                    { 29, "هرمزگان" },
                    { 30, "همدان" },
                    { 31, "یزد" }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "ApplicationUserId", "Balance", "FirstName", "Gender", "IsDeleted", "LastName", "LastUpdated", "PhoneNumber", "RegisterAt" },
                values: new object[] { 1, 1, 1000000000m, "عارف", 1, false, "بهمنی نژاد", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "ApplicationUserId", "Balance", "CommentId", "CreatAt", "FirstName", "Gender", "ImageProfile", "IsDeleted", "LastName", "PhoneNumber", "UpdateAt" },
                values: new object[,]
                {
                    { 4, 4, null, null, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "حسین ", 1, null, false, "مصلحی", "+989122152580", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, null, null, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "سارا ", 2, null, false, "روشنی", "+989124488954", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "ApplicationUserId", "Balance", "CreatAt", "FirstName", "Gender", "ImageProfile", "IsDeleted", "LastName", "PhoneNumber", "UpdateAt" },
                values: new object[,]
                {
                    { 2, 2, 10000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "جواد", 1, null, false, "مرادی", "+981247859652", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 10000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "سعید", 1, null, false, "لک", "+981247877652", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Created", "Image", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "نظافت", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "شستشولباس", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "تعمیرات شیرالات", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "مبایل", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "لپ تاپ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "اسباب سنگین", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "اسباب سبک", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "تعمیرات خودرو خارجی", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "  تعمیرات", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "اصلاح برای اقایان", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "اصلاح برای بانوان", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CreatAt", "CustomerId", "ExpertId", "IsDeleted", "PostalCode", "ProvinceId", "Street" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, null, false, "4265998715", 5, "کرج_شاهین ویلا_قلم دهم غربی" },
                    { 2, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, "1007815639", 1, "اذربایجان شرقی_میدان امام حسین_کوچه مولوی" }
                });

            migrationBuilder.InsertData(
                table: "CategoryServices",
                columns: new[] { "Id", "BidPrice", "CreatTime", "Description", "IsDeleted", "Name", "SubCategoryId", "Titel" },
                values: new object[,]
                {
                    { 9, 150000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "استفاده از مواد شوینده درجه یک", false, "نظافت منزل", 1, null },
                    { 10, 400000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "شستشوی تمامی اتاق ها", false, "نظافت اداری", 1, null },
                    { 11, 320000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "استفاده از رنگهای درجه یک", false, "نقاشی ساختمان", 2, null },
                    { 12, 860000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "سرویس لوله کشی کامل ساختمان", false, "تعمیرات ساختمان", 2, null },
                    { 13, 600000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "تعمیرات تلوزیون و مبایل", false, "تعمیرات لوازم خانگی", 3, null },
                    { 14, 750000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "تعمیرات پاور", false, "تعمیرات موبایل", 3, null },
                    { 15, 400000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "حمل بار سبک", 4, null },
                    { 16, 0m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "حمل بار سنگین", 4, null },
                    { 17, 500000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "تعمیرات خودرو", 5, null },
                    { 18, 10000m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "کارواش", 5, null },
                    { 19, 0m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "آرایشگاه", 6, null },
                    { 20, 0m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "ماساژ", 6, null },
                    { 21, 0m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "خدمات عمومی", 7, null },
                    { 22, 0m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "نظافت مجتمع", 8, null },
                    { 23, 0m, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, false, "تعمیرات مجتمع", 8, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CustomerId", "Description", "ExpertId", "IsDeleted", "Reaction", "SaveTime", "Titel" },
                values: new object[] { 1, 4, "لطفا رسیدگی شود", 2, false, 3, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "سطح کاری متوسطی داشتن" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CategoryServiceId", "CountExpert", "CustomerId", "CustomerRequest", "DateRequest", "Description", "ExpertId", "IsDeleted", "Location", "Price", "Status", "Titel" },
                values: new object[] { 1, 9, null, 4, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), "نظافت تمامی اتاق ها و سرویس های بهداشتی", 2, false, 1, 500000m, 3, "نظافت" });

            migrationBuilder.InsertData(
                table: "Suggestions",
                columns: new[] { "Id", "CreatAt", "Description", "IsDeleted", "Price", "RequestId", "Status", "SuggestionDate", "UpdateAt" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نظافت تمامی اتاق ها و سرویس های بهداشتی", false, 500000m, 1, 3, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ExpertId",
                table: "Addresses",
                column: "ExpertId",
                unique: true,
                filter: "[ExpertId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_ApplicationUserId",
                table: "Admin",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryServiceExpert_ExpertsId",
                table: "CategoryServiceExpert",
                column: "ExpertsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryServices_SubCategoryId",
                table: "CategoryServices",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerId",
                table: "Comments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ExpertId",
                table: "Comments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experts_ApplicationUserId",
                table: "Experts",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpertSuggestion_SuggestionsId",
                table: "ExpertSuggestion",
                column: "SuggestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CategoryServiceId",
                table: "Requests",
                column: "CategoryServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ExpertId",
                table: "Requests",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_RequestId",
                table: "Suggestions",
                column: "RequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryServiceExpert");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExpertSuggestion");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Suggestions");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "CategoryServices");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
