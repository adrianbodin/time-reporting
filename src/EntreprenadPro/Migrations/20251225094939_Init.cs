using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntreprenadPro.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    OrgNumber = table.Column<string>(type: "TEXT", maxLength: 13, nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 13, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    BillingAddress = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "TEXT", nullable: true),
                    SerialNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Make = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "TEXT", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    HourlyRate = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeEntries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmployeeId = table.Column<string>(type: "TEXT", nullable: true),
                    Hours = table.Column<double>(type: "REAL", maxLength: 100, nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    HourlyRate = table.Column<double>(type: "REAL", nullable: false),
                    WorkTypeId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeEntries_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntries_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TimeEntries_WorkTypes_WorkTypeId",
                        column: x => x.WorkTypeId,
                        principalTable: "WorkTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "HireDate", "JobTitle", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09442776-8478-34e0-e6aa-335b933599ad", 0, "3b6982c4-ad86-2680-94ee-908b2f62a9ba", "Tommie_Trantow@hotmail.com", true, "Tommie Trantow", new DateOnly(2018, 10, 27), "Manager", true, null, "TOMMIE_TRANTOW@HOTMAIL.COM", "TOMMIE_TRANTOW@HOTMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "655.314.1687 x4696", false, "6aec3d17-017a-a069-fc13-6b1f6eb1ba8f", false, "Tommie_Trantow@hotmail.com" },
                    { "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 0, "45ceec1a-553f-a4c9-284f-cd95cdf41dd3", "Bobbie58@yahoo.com", true, "Bobbie Waelchi", new DateOnly(2017, 5, 14), "Administrator", true, null, "BOBBIE58@YAHOO.COM", "BOBBIE58@YAHOO.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-692-871-4580", false, "011e0967-8256-bf8c-ae8e-e197a7fbe612", false, "Bobbie58@yahoo.com" },
                    { "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 0, "dd9f5167-d8e2-dc1f-c6fd-4158c2a31e74", "Earl_White67@gmail.com", true, "Earl White", new DateOnly(2025, 12, 8), "Manager", true, null, "EARL_WHITE67@GMAIL.COM", "EARL_WHITE67@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-932-211-3106", false, "ae59ad97-6c77-8269-eb6e-19ae055ab222", false, "Earl_White67@gmail.com" },
                    { "420371f9-ea23-96de-9ce3-00aeeec060a2", 0, "bb47eb53-e62d-1de0-ed1b-988cbd401b71", "Carroll_Wolf77@yahoo.com", true, "Carroll Wolf", new DateOnly(2020, 10, 6), "IT-Support", true, null, "CARROLL_WOLF77@YAHOO.COM", "CARROLL_WOLF77@YAHOO.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-372-442-1822 x97457", false, "87d5e6ca-cfb0-064a-d763-cdd119735a6e", false, "Carroll_Wolf77@yahoo.com" },
                    { "56433424-0c06-62de-834b-9a1e6143f89f", 0, "f987527a-78c9-7519-ff98-bcc19a6c22d1", "Vera87@gmail.com", true, "Vera Abbott", new DateOnly(2016, 1, 27), "IT-Technician", true, null, "VERA87@GMAIL.COM", "VERA87@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-612-682-9537 x7096", false, "4a2a76bf-9fbf-f146-90b3-fba46965a93a", false, "Vera87@gmail.com" },
                    { "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 0, "c6f5a459-bb10-4a08-3605-031d138b689b", "Jose57@gmail.com", true, "Jose Barrows", new DateOnly(2023, 10, 26), "Designer", true, null, "JOSE57@GMAIL.COM", "JOSE57@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-685-931-3725", false, "6363864b-8a7b-a9ae-b8dd-13d55f1fe504", false, "Jose57@gmail.com" },
                    { "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 0, "f1f4cb16-3b92-5a8e-0f9c-2beaf50780ea", "Kayla.Bednar53@yahoo.com", true, "Kayla Bednar", new DateOnly(2023, 1, 15), "Manager", true, null, "KAYLA.BEDNAR53@YAHOO.COM", "KAYLA.BEDNAR53@YAHOO.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "335.936.9792", false, "74d09312-1b35-440b-269f-8ec7c7472a51", false, "Kayla.Bednar53@yahoo.com" },
                    { "8286d046-9740-a3e4-95cf-ff46699c73c4", 0, "523c5a4d-55f6-51b3-d695-89d1d290b43e", "Nick_Purdy@gmail.com", true, "Nick Purdy", new DateOnly(2021, 1, 22), "IT-Technician", true, null, "NICK_PURDY@GMAIL.COM", "NICK_PURDY@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "(660) 798-8055 x29634", false, "92b1fd07-7dcd-4b94-6bd9-bd0380b1f24f", false, "Nick_Purdy@gmail.com" },
                    { "8f027ea7-71b0-c4dc-3884-6771bccebf95", 0, "ddb24c25-5920-2909-b69e-0b4f86ab854b", "Theodore.Boehm@yahoo.com", true, "Theodore Boehm", new DateOnly(2024, 8, 7), "Software Engineer", true, null, "THEODORE.BOEHM@YAHOO.COM", "THEODORE.BOEHM@YAHOO.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "(343) 738-4469 x4087", false, "0ae97d76-6057-68b8-673a-23578eeb1495", false, "Theodore.Boehm@yahoo.com" },
                    { "95c69371-b924-6fe3-7c38-98b7dd200bc1", 0, "8046e63c-81ed-bd68-10e2-e3d1cca53c8b", "Kim73@yahoo.com", true, "Kim Renner", new DateOnly(2017, 11, 14), "IT-Technician", true, null, "KIM73@YAHOO.COM", "KIM73@YAHOO.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "(791) 903-8676", false, "582236b0-6743-9b61-aa64-9fd9f78f1a58", false, "Kim73@yahoo.com" },
                    { "a24141d3-9394-90dc-1fed-01e130515792", 0, "cd335648-c96f-77af-83f8-5d9feab3184f", "Tasha_Brown26@hotmail.com", true, "Tasha Brown", new DateOnly(2022, 2, 25), "Software Engineer", true, null, "TASHA_BROWN26@HOTMAIL.COM", "TASHA_BROWN26@HOTMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "273.724.2200 x71203", false, "67dbab8a-a101-a579-648c-a8d6b8e6548f", false, "Tasha_Brown26@hotmail.com" },
                    { "a905569d-db07-3ae3-63a0-322750a4a3bd", 0, "3d3e4025-ccf9-b5ab-773e-cdce72ef4774", "Laurence.Rosenbaum@yahoo.com", true, "Laurence Rosenbaum", new DateOnly(2025, 1, 3), "Software Engineer", true, null, "LAURENCE.ROSENBAUM@YAHOO.COM", "LAURENCE.ROSENBAUM@YAHOO.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "525.406.8548", false, "9a908ce3-fcb3-c748-c585-c3fac11fa4b4", false, "Laurence.Rosenbaum@yahoo.com" },
                    { "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 0, "b52d4e42-963d-c7fe-04a1-ca17a9f38f0b", "Casey.Collins46@hotmail.com", true, "Casey Collins", new DateOnly(2017, 9, 19), "Software Engineer", true, null, "CASEY.COLLINS46@HOTMAIL.COM", "CASEY.COLLINS46@HOTMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "(945) 341-9265 x481", false, "381a513f-eb9a-b110-e971-4c751b33e71d", false, "Casey.Collins46@hotmail.com" },
                    { "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 0, "9441d8c5-18ac-e868-85bf-8bba000dc244", "Nellie.Schaden@hotmail.com", true, "Nellie Schaden", new DateOnly(2020, 5, 31), "Software Engineer", true, null, "NELLIE.SCHADEN@HOTMAIL.COM", "NELLIE.SCHADEN@HOTMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-790-609-3102", false, "ff6f8e8a-a045-284e-296f-db91e36450d8", false, "Nellie.Schaden@hotmail.com" },
                    { "c9c1c82a-d75b-27da-eebd-34c31858868b", 0, "50bec243-ebcf-cca1-b479-97aba2a97c3b", "Randy32@gmail.com", true, "Randy Cruickshank", new DateOnly(2016, 9, 29), "Administrator", true, null, "RANDY32@GMAIL.COM", "RANDY32@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-615-849-5964 x137", false, "a36b9497-323c-bcce-30bd-d52a0ce105e2", false, "Randy32@gmail.com" },
                    { "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 0, "4941941c-8fa6-3c2b-1331-8f4f63d74353", "Ann_Schulist18@gmail.com", true, "Ann Schulist", new DateOnly(2018, 12, 10), "Administrator", true, null, "ANN_SCHULIST18@GMAIL.COM", "ANN_SCHULIST18@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "1-231-839-1717", false, "f4598d88-0428-fcaa-fcdd-2a55bdcc82f5", false, "Ann_Schulist18@gmail.com" },
                    { "dc018b55-f93e-f2da-d526-ce348bdc1e87", 0, "9026ae69-f27f-515f-a88c-5bd2f46652a4", "Krista_Dicki74@gmail.com", true, "Krista Dicki", new DateOnly(2022, 7, 7), "IT-Support", true, null, "KRISTA_DICKI74@GMAIL.COM", "KRISTA_DICKI74@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "542-957-3570", false, "3bcce089-cc99-2607-4b65-de7669fa6ba7", false, "Krista_Dicki74@gmail.com" },
                    { "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 0, "a250e3b1-06c2-1e91-49b7-e2d8912ec768", "Kelvin12@gmail.com", true, "Kelvin Spencer", new DateOnly(2025, 5, 26), "Manager", true, null, "KELVIN12@GMAIL.COM", "KELVIN12@GMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "907-517-0043", false, "f1e858e7-0c43-26be-efa9-211ec5ea4d92", false, "Kelvin12@gmail.com" },
                    { "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 0, "6c56bf61-d905-3ddc-266d-d26678e9f06f", "Tyler.Erdman@hotmail.com", true, "Tyler Erdman", new DateOnly(2019, 9, 17), "Administrator", true, null, "TYLER.ERDMAN@HOTMAIL.COM", "TYLER.ERDMAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "(373) 646-6507", false, "68a5f935-5e44-9edf-2c6b-1063fc00bb15", false, "Tyler.Erdman@hotmail.com" },
                    { "f604634b-6295-68e1-ff41-99ea1fb201b0", 0, "ac7dc443-3268-7fb1-920e-2cfa8b5d4855", "Regina47@yahoo.com", true, "Regina Streich", new DateOnly(2024, 1, 16), "Administrator", true, null, "REGINA47@YAHOO.COM", "REGINA47@YAHOO.COM", "AQAAAAIAAYagAAAAENhHih7/Uoh7sy5nEO3YSAM0M/2n1Squi7WtcxU3Yc7NyqcdLo1wwi/1Wlo5P+vSgg==", "(721) 810-0815 x986", false, "4855252d-5535-5f45-607e-dc59cac8768f", false, "Regina47@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "BillingAddress", "City", "CreatedAt", "Email", "Name", "OrgNumber", "PhoneNumber", "PostalCode", "Type" },
                values: new object[,]
                {
                    { "09442776-8478-34e0-e6aa-335b933599ad", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(571), null, "Wilkinson Group", null, null, null, 0 },
                    { "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(624), null, "Mayer - Waelchi", null, null, null, 0 },
                    { "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(663), null, "Dietrich Group", null, null, null, 0 },
                    { "8286d046-9740-a3e4-95cf-ff46699c73c4", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 333, DateTimeKind.Utc).AddTicks(7666), null, "Morissette LLC", null, null, null, 0 },
                    { "95c69371-b924-6fe3-7c38-98b7dd200bc1", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(113), null, "Feil, Renner and Borer", null, null, null, 0 },
                    { "a905569d-db07-3ae3-63a0-322750a4a3bd", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(289), null, "Steuber Group", null, null, null, 0 },
                    { "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(347), null, "Krajcik - Schaden", null, null, null, 0 },
                    { "cf85ddf4-1ece-d1e2-3171-650938abd2b7", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(411), null, "Boyer, Schulist and Fritsch", null, null, null, 0 },
                    { "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(462), null, "Rau - Spencer", null, null, null, 0 },
                    { "f604634b-6295-68e1-ff41-99ea1fb201b0", null, null, null, new DateTime(2025, 12, 25, 9, 49, 39, 334, DateTimeKind.Utc).AddTicks(520), null, "Harvey, Streich and Bailey", null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "WorkTypes",
                columns: new[] { "Id", "HourlyRate", "Name" },
                values: new object[,]
                {
                    { "09442776-8478-34e0-e6aa-335b933599ad", 146, "Documentation" },
                    { "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 108, "Bug Fixing" },
                    { "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 69, "Development" },
                    { "8286d046-9740-a3e4-95cf-ff46699c73c4", 112, "Project Management" },
                    { "95c69371-b924-6fe3-7c38-98b7dd200bc1", 73, "Requirements Analysis" },
                    { "a905569d-db07-3ae3-63a0-322750a4a3bd", 136, "Code Review" },
                    { "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 98, "DevOps" },
                    { "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 59, "Support" },
                    { "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 122, "Client Meeting" },
                    { "f604634b-6295-68e1-ff41-99ea1fb201b0", 83, "System Architecture" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { -2001551291, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7746), "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Fresh Mouse", 0 },
                    { -1844884905, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7490), "a905569d-db07-3ae3-63a0-322750a4a3bd", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Concrete Towels", 0 },
                    { -1601722507, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7923), "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Cotton Gloves", 0 },
                    { -1445121657, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7721), "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Metal Fish", 0 },
                    { -1288389735, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7391), "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Frozen Computer", 0 },
                    { -1045358408, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7900), "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Concrete Salad", 0 },
                    { -888626487, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7694), "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Granite Ball", 0 },
                    { -731960101, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(1761), "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Soft Tuna", 0 },
                    { -488863238, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7878), "8286d046-9740-a3e4-95cf-ff46699c73c4", "The Football Is Good For Training And Recreational Purposes", "Tasty Frozen Table", 0 },
                    { -332196852, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7666), "cf85ddf4-1ece-d1e2-3171-650938abd2b7", "The Football Is Good For Training And Recreational Purposes", "Fantastic Concrete Bacon", 0 },
                    { 67631932, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7856), "f604634b-6295-68e1-ff41-99ea1fb201b0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Soft Chips", 0 },
                    { 224298318, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7637), "8286d046-9740-a3e4-95cf-ff46699c73c4", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Steel Pants", 0 },
                    { 624061566, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7834), "95c69371-b924-6fe3-7c38-98b7dd200bc1", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Rubber Hat", 0 },
                    { 780793488, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7585), "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Fresh Salad", 0 },
                    { 1180556736, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7793), "09442776-8478-34e0-e6aa-335b933599ad", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Plastic Car", 0 },
                    { 1337157586, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7554), "95c69371-b924-6fe3-7c38-98b7dd200bc1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Rubber Shoes", 0 },
                    { 1580319985, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7971), "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Fresh Bike", 0 },
                    { 1736986371, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7770), "a905569d-db07-3ae3-63a0-322750a4a3bd", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Wooden Soap", 0 },
                    { 1893652757, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7524), "f604634b-6295-68e1-ff41-99ea1fb201b0", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Cotton Chair", 0 },
                    { 2136749619, new DateTime(2025, 12, 25, 9, 49, 39, 337, DateTimeKind.Utc).AddTicks(7947), "cf85ddf4-1ece-d1e2-3171-650938abd2b7", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Rubber Cheese", 0 }
                });

            migrationBuilder.InsertData(
                table: "TimeEntries",
                columns: new[] { "Id", "CreatedAt", "Date", "Description", "EmployeeId", "HourlyRate", "Hours", "ProjectId", "Type", "WorkTypeId" },
                values: new object[,]
                {
                    { "007413af-b7ce-a74d-0d1c-f18bc7de392b", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6056), new DateOnly(2025, 12, 25), "Quasi ullam facere omnis possimus molestias praesentium incidunt placeat nisi.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 113.0, 3.5, -1601722507, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "03749579-878f-56c3-c045-07b5867001fa", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5640), new DateOnly(2025, 12, 31), "Vel corporis nisi cum omnis vel atque qui quia impedit.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 102.0, 7.5, -1045358408, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "038011ac-3c05-89d9-a3f7-011573e34d81", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2593), new DateOnly(2025, 12, 28), "Alias ut consequatur possimus aperiam doloribus cumque ut asperiores earum.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 149.0, 4.0, -731960101, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "045c9d13-1da3-ee97-fae3-12f3ad8969ec", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(985), new DateOnly(2025, 12, 28), "Odio qui nostrum occaecati numquam neque illo quos quidem et.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 109.0, 7.5, -888626487, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "04681946-d219-22ad-dd94-0c549afdb573", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8587), new DateOnly(2025, 12, 25), "Et veritatis ipsam animi corrupti assumenda ut dignissimos nihil voluptatum.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 55.0, 3.5, 1180556736, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "0544a4ad-b3b7-866a-3480-1d32d4a3d1de", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4016), new DateOnly(2025, 12, 25), "Et nisi labore ea libero earum dolorum officia et omnis.", "a24141d3-9394-90dc-1fed-01e130515792", 117.0, 7.5, -731960101, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "055020e0-682d-ba81-1732-1792c1161d65", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2468), new DateOnly(2025, 12, 31), "Aliquam culpa voluptatem odio earum omnis quo ut pariatur aut.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 63.0, 3.5, 1337157586, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "0638287a-fe42-5254-51cf-22d1e8308557", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5511), new DateOnly(2025, 12, 27), "Aut aut non minima qui sit ea quidem minima perspiciatis.", "56433424-0c06-62de-834b-9a1e6143f89f", 70.0, 3.5, -1045358408, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "0938aa43-cf02-00ca-03f8-38faa6c24d26", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4674), new DateOnly(2025, 12, 25), "Fuga aut et ea in sed molestiae aut id voluptates.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 59.0, 7.5, -488863238, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "09442776-8478-34e0-e6aa-335b933599ad", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1539), new DateOnly(2025, 12, 31), "Consequatur nisi eum atque tempore vel facilis possimus cupiditate eos.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 106.0, 3.5, 1580319985, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "0a20b2dd-6516-989e-3d96-4339cddcb517", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(525), new DateOnly(2025, 12, 30), "Magnam fuga placeat et at voluptatibus repellat ut dolorem dignissimos.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 67.0, 7.5, -332196852, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "0a2c2e10-1a8c-ccb4-2047-3e9aba4f019e", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7634), new DateOnly(2025, 12, 28), "Iusto et est quia consequuntur deserunt numquam at tenetur cum.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 113.0, 3.5, 1736986371, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "0b08b977-fb2b-3072-7733-4e77f4f51d09", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3559), new DateOnly(2025, 12, 27), "Debitis ratione optio dicta nemo voluptas error repellat mollitia reiciendis.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 74.0, 7.0, 1580319985, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "0b1436aa-b0a1-6488-5ae5-49d8e1686990", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2004), new DateOnly(2025, 12, 24), "Et eum quisquam dolorem culpa autem dolor hic vel non.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 121.0, 3.0, 1893652757, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "0cfc3d44-46b5-fc5c-9482-54170882d182", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5028), new DateOnly(2025, 12, 30), "Eligendi et libero consequatur aperiam sequi aliquid quae consequatur maxime.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 128.0, 3.0, -488863238, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "0df0c111-913f-c845-b1d1-59b61b0f85fb", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6575), new DateOnly(2025, 12, 24), "Quas nam facilis molestiae omnis unde dolores explicabo accusantium excepturi.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 81.0, 7.0, 1736986371, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "10f043da-6200-77bb-64fa-6fe0daa14dca", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6658), new DateOnly(2025, 12, 30), "Dolore libero ut ab voluptas esse nesciunt voluptatem atque officiis.", "09442776-8478-34e0-e6aa-335b933599ad", 71.0, 3.0, -1445121657, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "10fcc00e-1776-abd1-47ac-6a40c6149951", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3672), new DateOnly(2025, 12, 27), "Iusto et quaerat magni eaque accusantium autem numquam ut odit.", "56433424-0c06-62de-834b-9a1e6143f89f", 117.0, 7.0, 624061566, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "11d84b74-f814-0f8f-9e98-7a1e01bbb5bc", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1518), new DateOnly(2025, 12, 27), "Officiis amet sit necessitatibus eius velit est ea repudiandae velit.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 78.0, 3.0, -1288389735, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "11e4c7a7-ad8a-43a5-8149-757fed2e0143", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9610), new DateOnly(2025, 12, 24), "Veritatis molestiae quia ut quos aut earum enim optio rerum.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 125.0, 7.0, 780793488, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "12c0520e-8d28-a763-d835-855c28d41dae", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4542), new DateOnly(2025, 12, 23), "Quas impedit magni minus tempore reiciendis exercitationem blanditiis laboriosam rerum.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 85.0, 2.5, 624061566, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "12cccf41-429e-db79-bbe7-7fbd14476935", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3076), new DateOnly(2025, 12, 29), "Est hic sequi consequatur rerum officia excepturi voluptate consequuntur dolor.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 132.0, 7.0, -1601722507, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "13b3d6db-d8b2-734d-f484-8afc3b61d127", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6103), new DateOnly(2025, 12, 26), "Ipsam totam aut et ea consequatur beatae quas iste quo.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 139.0, 6.5, -1445121657, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "16b459a5-a973-21c2-a7ae-a025faf399f6", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5706), new DateOnly(2025, 12, 23), "Inventore rem eligendi omnis ea labore aut tempore perferendis architecto.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 129.0, 3.0, -888626487, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "16c0d5d8-5ee9-55d8-8a5f-9b86e666e57d", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2669), new DateOnly(2025, 12, 30), "Dolore impedit porro vero cum pariatur voluptatem fuga quibusdam nemo.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 75.0, 7.0, 1180556736, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "179c603e-3f87-b996-e14b-ab64210d01e8", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1033), new DateOnly(2025, 12, 29), "Nobis doloribus rerum et vero voluptatem tempore assumenda dignissimos est.", "56433424-0c06-62de-834b-9a1e6143f89f", 136.0, 2.5, -731960101, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "17a8dc72-f4fd-edac-c4fc-a6c50d804d6f", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8656), new DateOnly(2025, 12, 26), "Officiis incidunt nam optio magni et necessitatibus quisquam tempora voluptas.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 82.0, 6.5, 1337157586, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "188367d8-d59b-516a-1be9-b6a2482669da", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4071), new DateOnly(2025, 12, 26), "Enim excepturi officia blanditiis enim et labore et accusamus ratione.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 143.0, 2.5, 1180556736, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "188fe40b-8a11-8580-fe9a-b103349ab561", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2511), new DateOnly(2026, 1, 1), "Et placeat laborum sed qui velit blanditiis illum expedita autem.", "09442776-8478-34e0-e6aa-335b933599ad", 89.0, 6.5, -1045358408, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "1977eba5-2025-1d54-3837-bc425bb31d53", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5565), new DateOnly(2025, 12, 29), "Consequuntur enim natus autem ipsa consectetur accusantium repudiandae dicta repudiandae.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 97.0, 6.5, -888626487, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1618), new DateOnly(2025, 12, 23), "Illo excepturi dolor culpa ipsam tempore voluptatem aperiam sit molestias.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 133.0, 6.5, 1736986371, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "1d6bf13c-3c70-98b3-07b0-d70a2dd2999b", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7700), new DateOnly(2025, 12, 29), "Nobis aperiam quia nihil assumenda qui fugiat magni possimus ipsa.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 140.0, 6.5, 1893652757, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "1d786e6f-f1e6-ccc9-eb61-d26b1a45e522", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4743), new DateOnly(2025, 12, 26), "Accusamus ad voluptatem quas ipsa veritatis ab vitae perspiciatis ad.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 86.0, 2.5, -332196852, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "1e53f9d6-d284-3087-414d-e24954ec018d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2038), new DateOnly(2025, 12, 25), "Enim omnis quasi voluptatem modi ut in tempora amet in.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 147.0, 6.5, -488863238, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "1e5f7509-87fa-649d-24fe-ddaa415f4d14", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(558), new DateOnly(2026, 1, 1), "Dolores autem aspernatur nisi dolores nulla et dolor aut consequatur.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 93.0, 2.5, 1580319985, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "1f3b006f-6898-c85b-7beb-ed877b06697f", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5079), new DateOnly(2025, 12, 31), "Itaque architecto sit aut soluta perferendis ut quia et aut.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 54.0, 6.0, -332196852, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "1f477da2-1d0e-fc71-5e9c-e8e86879b506", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3592), new DateOnly(2025, 12, 28), "Quia ipsam quae sit hic fuga amet ad in nisi.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 101.0, 2.0, 1736986371, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "202f843c-b322-9445-9839-f3278f921df8", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6617), new DateOnly(2025, 12, 25), "Placeat fugiat asperiores voluptatem voluptate voluptate facere quis eum debitis.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 108.0, 2.0, 1893652757, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "232f0706-83e3-42ba-4b63-09504d25e5c7", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6725), new DateOnly(2025, 12, 31), "Quos quo qui ratione voluptate ad omnis ut quis et.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 97.0, 6.0, -1844884905, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "233b8339-3959-76d1-2e14-03b13a98314e", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3742), new DateOnly(2025, 12, 28), "Soluta architecto est tempora soluta rerum asperiores quos architecto voluptatum.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 144.0, 2.5, 224298318, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "24170ea0-19f7-da8e-8500-148f743e4db9", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1552), new DateOnly(2025, 12, 28), "Quia ex provident doloribus eos inventore ut quidem porro omnis.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 105.0, 6.0, 67631932, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "24238ad3-ce6d-0ea4-68b2-0ef061b19940", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9675), new DateOnly(2025, 12, 25), "Nemo mollitia iste quasi dolores libero natus officia quas aut.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 50.0, 2.0, 2136749619, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "250b926d-6481-a678-a24f-192e88cb0132", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3109), new DateOnly(2025, 12, 31), "Recusandae sed quas voluptates officia ducimus magni nobis non perspiciatis.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 58.0, 2.0, -2001551291, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "25ff163a-af0b-7262-bf9e-1fcd9b58b5ab", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4593), new DateOnly(2025, 12, 25), "Placeat debitis deleniti eum voluptatem quo repudiandae minus ratione enim.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 112.0, 6.0, 224298318, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "26f39906-fa95-3e4c-dced-246cafe56924", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6139), new DateOnly(2025, 12, 27), "Natus quidem qui placeat quae incidunt cumque dolor ea beatae.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 65.0, 1.5, -1844884905, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "29ff9803-80cc-20d8-71c7-35f75aea7d7a", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2738), new DateOnly(2025, 12, 31), "Quos debitis et tenetur voluptatem impedit itaque ut id cum.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 101.0, 2.0, 780793488, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "2ae7a09d-16e0-b9ac-ab65-40358104e56c", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8720), new DateOnly(2025, 12, 27), "Sed in perferendis autem est corrupti molestias repellat aperiam non.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 109.0, 2.0, -1601722507, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "2af31cd0-cb56-edc2-8e16-3a966d7731f3", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5772), new DateOnly(2025, 12, 25), "Corporis rerum ipsa officiis quae aspernatur est hic illum dignissimos.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 54.0, 6.0, -1288389735, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "2bcfa737-acf4-517f-e502-4b74a81d4d5e", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2544), new DateOnly(2025, 12, 24), "Maxime et sapiente quidem tempora enim architecto explicabo laudantium maxime.", "a24141d3-9394-90dc-1fed-01e130515792", 116.0, 1.5, -1445121657, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "2bdb236a-616a-8595-c8b4-45d5949099e5", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1066), new DateOnly(2025, 12, 30), "Non nesciunt doloribus quo et aut nostrum quae dolore reiciendis.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 62.0, 5.5, 624061566, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "2cb7aed1-4208-e953-1fa0-56b2cf37b550", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5598), new DateOnly(2025, 12, 30), "Quis odio voluptates voluptatum nobis ab facilis consectetur necessitatibus minima.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 123.0, 1.5, -1288389735, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "2cc32b04-f77e-1d69-0251-5013bbaa01d7", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4105), new DateOnly(2025, 12, 27), "Iste soluta itaque iste a distinctio eos qui cum excepturi.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 69.0, 5.5, 780793488, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1690), new DateOnly(2025, 12, 24), "Corporis soluta cupiditate soluta a provident rerum nemo dolores debitis.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 58.0, 1.5, 1893652757, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "30abb567-5e53-63b3-ef18-717ba1563098", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7765), new DateOnly(2025, 12, 30), "Non sed rem occaecati velit enim qui voluptate error velit.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 66.0, 1.5, -488863238, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "30b7319a-13c9-97c9-d2c9-6cdc8ec97c1f", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4815), new DateOnly(2025, 12, 27), "Fugit dignissimos et animi nobis et libero ea ut facilis.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 112.0, 5.5, 1580319985, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "3193bc01-f467-fb87-29b5-7cbac86f988a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2071), new DateOnly(2025, 12, 27), "Iste quisquam quam ea et explicabo voluptatem quas asperiores rerum.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 73.0, 1.5, -332196852, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "319f3834-a9dd-2f9d-0c67-771ab5e3e411", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(591), new DateOnly(2025, 12, 24), "Quod sapiente ducimus odio eos nihil ut blanditiis omnis dolor.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 120.0, 5.5, 1736986371, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "327bc49b-8a7c-935a-6253-87f8ef89007c", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5112), new DateOnly(2025, 12, 23), "Sit et consequatur sed quia officiis officia animi quam deleniti.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 80.0, 1.0, 1580319985, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "328740ce-3ff2-c770-4504-8259dbfc4c03", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3624), new DateOnly(2025, 12, 29), "Consequatur atque qui veniam mollitia atque aut omnis quia quo.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 127.0, 5.5, 1893652757, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "336f4768-d406-5f44-7fa2-8c970216b4f5", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6651), new DateOnly(2025, 12, 26), "Asperiores alias nisi quia ab ut autem est quidem dolore.", "a24141d3-9394-90dc-1fed-01e130515792", 134.0, 5.0, -488863238, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "366fca31-a5c6-0eba-32cb-a3c1c1a87cc4", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6792), new DateOnly(2025, 12, 23), "Quod consequatur recusandae dolore ab dolores qui vel explicabo laborum.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 124.0, 1.5, 67631932, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "367b4665-5a3c-42d0-157c-9d22ae1bc84b", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3814), new DateOnly(2025, 12, 30), "Molestiae dolore a voluptas quia maxime laborum voluptas debitis nulla.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 70.0, 5.5, 2136749619, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "37634efe-f051-daa4-4f1a-a860d535303d", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9739), new DateOnly(2025, 12, 26), "Omnis voluptas et dolorem omnis non sit et nemo vel.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 77.0, 5.0, -2001551291, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "384b5598-8665-7278-89b7-b39ffc4e982f", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3143), new DateOnly(2026, 1, 1), "Dolor quis at consequatur ut nemo placeat sapiente id repudiandae.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 84.0, 5.0, -1844884905, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "3857d1cb-3bdb-a68e-6c69-ad00e8c2e4b6", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1584), new DateOnly(2025, 12, 29), "Consequatur cupiditate aut dicta quas sint delectus repudiandae cupiditate ratione.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 131.0, 1.0, 224298318, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "39335d32-1c79-0a4c-c355-bedd23680021", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6173), new DateOnly(2025, 12, 29), "Aut aut et pariatur est sunt voluptatem inventore dolorem ducimus.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 92.0, 5.0, 67631932, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "393fd965-d1ef-3e62-a606-b83e0fdb4ca8", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4627), new DateOnly(2025, 12, 26), "Asperiores quae eum molestiae sapiente optio sed aut hic soluta.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 138.0, 1.0, 2136749619, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "3c3f5b2f-a2b0-ecd7-5830-ce68ce6d1477", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2810), new DateOnly(2025, 12, 23), "Id quae esse ab sapiente similique iste quia velit quae.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 128.0, 5.0, -1601722507, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "3d2763c9-38c4-84ab-92cd-d9a6f5877c68", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8789), new DateOnly(2025, 12, 29), "Commodi similique commodi saepe esse aliquid consequuntur enim quo culpa.", "56433424-0c06-62de-834b-9a1e6143f89f", 135.0, 5.0, -1445121657, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "3d33dffc-ed3a-b8c1-757e-d407e1fac8ef", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5840), new DateOnly(2025, 12, 26), "Unde consequatur reprehenderit aut est a nisi modi fuga vel.", "a24141d3-9394-90dc-1fed-01e130515792", 81.0, 1.0, 624061566, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "3e0f6a62-ced8-1c7f-cc6b-e4e51ca1e45a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2577), new DateOnly(2025, 12, 25), "Doloribus sunt enim minus officiis magni optio quis ut fugit.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 142.0, 4.5, -1288389735, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "3e1be795-834e-5095-af1c-df45081430e1", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1100), new DateOnly(2026, 1, 1), "Quia voluptas laboriosam vel ratione quod voluptates quia illo ut.", "09442776-8478-34e0-e6aa-335b933599ad", 88.0, 1.0, 780793488, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "3f03ee2f-1962-e869-e9b9-ea842f2e98d3", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4139), new DateOnly(2025, 12, 28), "Aut pariatur quis et animi occaecati deleniti quam deleniti aut.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 96.0, 0.5, -1601722507, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "3ff772fc-64ec-b453-0608-ef2343ba4c4c", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5632), new DateOnly(2025, 12, 31), "Et est quaerat sunt voluptas repudiandae voluptatem totam optio est.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 150.0, 4.5, 624061566, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "420371f9-ea23-96de-9ce3-00aeeec060a2", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1805), new DateOnly(2025, 12, 25), "Unde pariatur officiis omnis animi reprehenderit quas qui earum dolore.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 85.0, 5.0, -1045358408, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "43eb7893-8037-2fb2-d680-0bec15d9c894", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7833), new DateOnly(2025, 12, 31), "Quia quis qui et illo ipsum quasi soluta consequatur dolor.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 92.0, 4.5, -888626487, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "43f7f4c6-35ad-63c8-b932-054d014d141b", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4882), new DateOnly(2025, 12, 28), "Ea laborum pariatur optio voluptas dolor quis harum sequi perferendis.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 139.0, 0.5, 1180556736, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "44dffc60-cbc1-fb9c-f3cf-108b28667c0d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(624), new DateOnly(2025, 12, 25), "Maiores magni quibusdam ut repellendus error vero qui qui unde.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 146.0, 0.5, 1337157586, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "45c703f9-60d5-9370-2d6d-1bca4f80e4ff", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3659), new DateOnly(2025, 12, 31), "Laborum et maxime vel labore nisi nihil eum aut vitae.", "56433424-0c06-62de-834b-9a1e6143f89f", 53.0, 0.5, -1045358408, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "45d37f2d-154b-c786-101e-162a3cf33086", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2104), new DateOnly(2025, 12, 28), "Et saepe assumenda praesentium excepturi tenetur rerum dolor quibusdam ipsam.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 100.0, 4.5, -731960101, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "46af0b93-f6e9-2b44-660a-260876994cf1", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6685), new DateOnly(2025, 12, 27), "Et ipsum eligendi eius eligendi consequuntur asperiores molestiae odio et.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 60.0, 8.0, -888626487, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "46bb87c6-ab5f-5f5a-4abb-2169630d9878", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5145), new DateOnly(2025, 12, 24), "Molestiae velit porro ullam delectus id non debitis tempora pariatur.", "09442776-8478-34e0-e6aa-335b933599ad", 107.0, 4.5, 1180556736, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "49bb0990-7c20-0dcf-fce5-3793219f6047", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3901), new DateOnly(2025, 12, 31), "Ipsum esse nemo nihil delectus id incidunt ipsa nobis numquam.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 96.0, 0.5, 1736986371, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "4aa3112a-1234-a5a3-3682-42d148b8c839", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9806), new DateOnly(2025, 12, 27), "Quibusdam recusandae aliquam voluptatem nihil iure et eos fugit placeat.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 104.0, 0.5, 1893652757, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "4aaf8d5d-c7aa-d9b9-1934-3c32352c14c0", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6861), new DateOnly(2025, 12, 25), "Maiores quia veniam nisi eligendi asperiores sit sunt eveniet voluptatibus.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 150.0, 4.5, -332196852, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "4b8b18c4-a848-3d77-7020-4d106fd2302b", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3176), new DateOnly(2025, 12, 24), "Nihil blanditiis sed odit debitis dolorem quis labore perspiciatis veniam.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 111.0, 8.0, -488863238, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "4b9795f7-5dbe-718d-53d1-47705c457cb2", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1617), new DateOnly(2025, 12, 30), "Laborum eligendi incidunt amet voluptatem omnis qui amet voluptas sint.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 57.0, 4.0, 1580319985, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "4c73205d-3e5c-d54b-aabd-584e96ec981d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6205), new DateOnly(2025, 12, 30), "Ab aut voluptatem rerum sit hic itaque suscipit ut illum.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 118.0, 8.0, -332196852, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "4c7f9c91-f3d2-0961-8d6f-52af835fe4a4", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4661), new DateOnly(2025, 12, 27), "Labore numquam dolor accusantium id iste sequi quis possimus ab.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 64.0, 4.0, 1736986371, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "4f7f1f5a-c493-b7d7-4098-68d841f1ac73", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2908), new DateOnly(2025, 12, 24), "Voluptatibus eius voluptas voluptatem id molestiae dolor qui numquam esse.", "09442776-8478-34e0-e6aa-335b933599ad", 53.0, 8.0, -1445121657, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "506726f4-5aa7-50aa-7935-7317680b1465", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8856), new DateOnly(2025, 12, 30), "Est id quo doloribus veritatis non maxime unde facilis hic.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 61.0, 8.0, -1288389735, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "5073a227-0f1d-84c1-5de7-6e78557e60ec", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5932), new DateOnly(2025, 12, 27), "Autem reiciendis quod quasi sit illum sapiente et molestiae sit.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 108.0, 4.0, 780793488, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "515baac1-a531-1c94-9684-79b67c97c8de", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1133), new DateOnly(2025, 12, 24), "Nihil dolores est voluptates temporibus animi provident mollitia vero porro.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 115.0, 4.0, -1601722507, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "5243b15b-3b45-b468-d022-84f5a3b130d0", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4173), new DateOnly(2025, 12, 29), "Ab sit quidem facere et vel aspernatur eligendi quis magnam.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 122.0, 3.5, -1445121657, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "524f2e8e-f0bb-e87e-b3d3-7e558f247c57", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2611), new DateOnly(2025, 12, 27), "Ut quaerat distinctio eum sint doloribus ipsam facilis architecto atque.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 68.0, 8.0, 624061566, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "53363528-86cf-8052-ed70-8994b63ee449", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5665), new DateOnly(2025, 12, 23), "Eos omnis est tempore ut est rerum maxime et sit.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 75.0, 7.5, 780793488, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "5637b8f1-5790-2ec8-a09a-9fbe75d0ac18", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4978), new DateOnly(2025, 12, 29), "Id dolor velit quibusdam ut rerum et voluptates a eum.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 65.0, 4.0, 1337157586, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "56433424-0c06-62de-834b-9a1e6143f89f", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1882), new DateOnly(2025, 12, 27), "Autem sit modi debitis et magnam quia eos maxime et.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 112.0, 8.0, -888626487, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "571fbf8b-eca4-c69c-da37-aafc9cea140a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(658), new DateOnly(2025, 12, 26), "Incidunt ullam ratione quidem molestiae nihil voluptatum consequatur iure sint.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 72.0, 3.5, -1045358408, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "572b3bbe-a11a-fab2-bde9-a55d885d6091", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7924), new DateOnly(2025, 12, 23), "Quam ut ipsum porro cumque aperiam eligendi a quia voluptatem.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 119.0, 7.5, -731960101, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "5806c725-82b8-5e6f-14d5-b53ac3037cfc", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3691), new DateOnly(2026, 1, 1), "Vero qui explicabo voluptatum aut sed quae aut illum qui.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 79.0, 3.5, -888626487, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "58124358-372e-9285-f786-b09baf76c883", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2138), new DateOnly(2025, 12, 29), "Quae veritatis sed iste sequi vel quaerat illo id nobis.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 126.0, 7.5, 1180556736, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "59eecebf-18cd-f643-4e72-c079ea1de4ee", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6718), new DateOnly(2025, 12, 28), "Corrupti laboriosam ipsa voluptatem suscipit maiores laborum sed dolore maiores.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 87.0, 3.5, -731960101, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "59fa4af2-cd42-2a59-3124-badad6903075", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5178), new DateOnly(2025, 12, 26), "Tempore culpa et qui est mollitia eum voluptatem doloremque eius.", "a24141d3-9394-90dc-1fed-01e130515792", 134.0, 7.5, 1337157586, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "5cfbcdbc-9e03-d9cf-e34d-d1039522f844", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3970), new DateOnly(2026, 1, 1), "Esse qui expedita cupiditate est laudantium at voluptatem quos qui.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 123.0, 3.5, 1893652757, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "5de2d455-3417-71a3-1deb-db42bc3c6036", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9907), new DateOnly(2025, 12, 29), "Ipsa aut id commodi et dolore quam esse sint sed.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 130.0, 3.5, -488863238, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "5dee5088-e98d-a5b9-009c-d6a3a8afacbd", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6966), new DateOnly(2025, 12, 26), "Incidunt nisi harum dignissimos laboriosam vero quidem consequatur nihil aliquid.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 76.0, 7.5, 1580319985, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "5ed65822-7fa1-3d8d-3a39-e1e1cfc914af", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1668), new DateOnly(2025, 12, 31), "Vero et culpa veniam autem quidem quia laudantium dolores rerum.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 83.0, 7.5, 1736986371, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "5fbe5fbc-15b6-d560-74d7-ec20f6e27ca1", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4694), new DateOnly(2025, 12, 28), "Atque eum non quia dolore quam est natus natus quam.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 91.0, 7.0, 1893652757, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "5fcadcef-ca2c-0977-5788-e680e356c828", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3224), new DateOnly(2025, 12, 25), "Libero fuga omnis sed occaecati accusantium doloribus excepturi ut et.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 137.0, 3.0, -332196852, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "60b2e389-6040-a14a-9126-f1bf0a6f301a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6240), new DateOnly(2025, 12, 31), "Exercitationem qui et ipsa aut consequatur natus est omnis amet.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 145.0, 3.0, 1580319985, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "63b26653-3101-4fc0-444f-07e8c901f8e9", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6000), new DateOnly(2025, 12, 28), "Ipsa ratione sunt dolorem reiciendis cum culpa omnis ut omnis.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 134.0, 7.0, 2136749619, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "63bee286-e676-83d6-2700-0249b5744470", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2980), new DateOnly(2025, 12, 25), "Tempora iure fugit dolore magnam quis quibusdam qui voluptatem repellendus.", "a24141d3-9394-90dc-1fed-01e130515792", 80.0, 3.5, -1844884905, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "649a6ded-c715-e794-7eed-1227f01b60db", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1176), new DateOnly(2025, 12, 25), "Libero nam eaque aut et praesentium voluptatem officiis nam dicta.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 141.0, 7.0, -2001551291, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "64a6e920-7c8b-1baa-619e-0d88dc8eac62", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8951), new DateOnly(2025, 12, 31), "At et veritatis sunt nihil quasi consequatur dolorem ducimus voluptatem.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 87.0, 3.0, 67631932, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "65827586-5d29-7f68-b78a-1d651635c8cd", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4227), new DateOnly(2025, 12, 31), "Exercitationem amet maiores pariatur rerum labore quisquam ut explicabo dolorum.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 149.0, 7.0, -1844884905, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "658ef1b9-129f-b37e-9a3b-18c603a81454", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2669), new DateOnly(2025, 12, 28), "Deleniti molestiae aut non nesciunt pariatur recusandae et debitis at.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 95.0, 3.0, 224298318, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "6676f853-a8b3-4b52-d4d9-23052ac17c46", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5713), new DateOnly(2025, 12, 24), "Odit rerum a assumenda laborum harum quas sit nemo iure.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 102.0, 2.5, 2136749619, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "69767b1d-7874-fac7-8702-392ee9544415", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5045), new DateOnly(2025, 12, 31), "Pariatur hic unde saepe et et non amet voluptas facere.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 91.0, 7.0, -1601722507, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "6982f750-2dea-2ddd-6ab4-338fd5c7909c", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1961), new DateOnly(2025, 12, 28), "Eaque consectetur sunt aut necessitatibus aut quod eos omnis maiores.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 138.0, 3.0, -1288389735, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "6a5e82b7-0e88-929b-c1a0-446d106dac07", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(706), new DateOnly(2025, 12, 27), "Voluptatum totam dolores minus quasi veniam explicabo veniam adipisci quis.", "a24141d3-9394-90dc-1fed-01e130515792", 99.0, 7.0, -1445121657, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "6a6affea-c3fe-c6b1-a451-3ecefce0f88e", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7993), new DateOnly(2025, 12, 25), "Nam impedit occaecati vel nisi saepe enim ut reiciendis occaecati.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 145.0, 3.0, 624061566, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "6b520684-5912-5e85-deef-490c23fa6080", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2188), new DateOnly(2025, 12, 30), "Nostrum incidunt totam expedita quibusdam tempore aut sit voluptate illo.", "56433424-0c06-62de-834b-9a1e6143f89f", 52.0, 2.5, 780793488, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "6c3a0e1d-ef26-f659-188c-544a4a14c872", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5223), new DateOnly(2025, 12, 27), "Sint placeat esse dolores magnam blanditiis ducimus molestiae quo officia.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 59.0, 2.5, -1601722507, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "6c468a51-a49c-2a6f-fb3d-4fab378714f9", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3740), new DateOnly(2025, 12, 24), "Odit doloribus dignissimos in cupiditate veritatis nam vel fuga qui.", "09442776-8478-34e0-e6aa-335b933599ad", 106.0, 6.5, -1288389735, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "6d2e91ea-3ab0-c243-35db-5aea5ea07ceb", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6770), new DateOnly(2025, 12, 30), "Minus excepturi reprehenderit esse reiciendis nulla incidunt voluptatum ab ex.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 113.0, 6.5, 624061566, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "702e14b4-0b71-70b8-e704-70131c3343b9", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7036), new DateOnly(2025, 12, 27), "Voluptatum excepturi voluptatibus ut voluptatibus porro aliquam facilis molestias quisquam.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 103.0, 2.5, 1736986371, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "703a90e7-c0e7-a4ce-cab6-6a7409a68f41", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4041), new DateOnly(2025, 12, 24), "Distinctio facere consequatur dolorum aliquam quia rem mollitia exercitationem tenetur.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 149.0, 6.5, -488863238, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "71161b4e-a185-088c-21a2-7b52434cabab", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1701), new DateOnly(2025, 12, 24), "Aut aperiam non vel iusto dolores dolorem quod itaque aliquam.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 110.0, 2.5, 1893652757, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "71229881-56fb-3ca2-0453-75b330bff732", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9973), new DateOnly(2025, 12, 30), "Quis enim tenetur praesentium impedit odit ipsa eligendi est corrupti.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 56.0, 6.5, -332196852, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "720a9f1b-ec0f-d476-3ef1-80f157d95f24", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3258), new DateOnly(2025, 12, 26), "Repudiandae autem ut ullam neque rerum est temporibus sequi voluptatem.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 63.0, 6.5, 1580319985, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "72fe23e8-3799-a060-5b3f-86906a66139d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4742), new DateOnly(2025, 12, 29), "Qui omnis debitis modi necessitatibus minima reprehenderit quo consequatur temporibus.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 117.0, 2.0, -488863238, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "73f2a6b5-8223-6c4a-788e-8b307ef3c716", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6291), new DateOnly(2025, 12, 23), "Perspiciatis ipsam pariatur qui et libero dolor rerum culpa iste.", "56433424-0c06-62de-834b-9a1e6143f89f", 70.0, 6.0, 1736986371, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "76f2297e-53e4-1bbf-2bb7-a1593c858fe5", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6072), new DateOnly(2025, 12, 29), "Quis ipsam odio ut dolorum ut sed illo ipsa et.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 60.0, 2.5, -2001551291, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "76fea5b1-085a-4ed6-0e69-9cba29f8db6c", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3051), new DateOnly(2025, 12, 27), "Rem iste laudantium ut saepe ratione esse consequatur dolorem sequi.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 107.0, 6.5, 67631932, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "77da3018-e9f8-b393-6555-ac98639ef7d7", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1209), new DateOnly(2025, 12, 26), "Repudiandae quo iure odit architecto voluptatem assumenda voluptatem totam blanditiis.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 67.0, 2.0, -1844884905, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "77e6ad4b-9e6e-e7a9-4806-a7f95012435e", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9019), new DateOnly(2025, 12, 23), "Aspernatur architecto velit amet ut non maiores aut aliquam est.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 114.0, 6.0, 224298318, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "78ceb4e5-3382-7f7d-82a4-b237772bab50", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2701), new DateOnly(2025, 12, 29), "Est mollitia ea accusantium et impedit iste velit nobis modi.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 121.0, 6.0, 2136749619, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "79b6bc7f-c996-1751-bc41-bc759e451342", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5749), new DateOnly(2025, 12, 26), "Aliquid fugit nemo et aliquam quos quia exercitationem aut possimus.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 129.0, 6.0, -2001551291, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "79c238b2-7e0c-4b67-9ff2-b7d68ab85fc9", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4259), new DateOnly(2026, 1, 1), "Ut ex suscipit rerum non aut laboriosam dolore eveniet doloribus.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 74.0, 2.0, 67631932, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2035), new DateOnly(2025, 12, 29), "Veniam ea et quasi provident ut commodi esse ex ex.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 64.0, 6.0, 624061566, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "7daac215-e5e1-91b1-8bb9-d83e70648f8a", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8061), new DateOnly(2025, 12, 26), "Voluptates debitis accusamus repudiandae maiores facere non excepturi repellendus necessitatibus.", "09442776-8478-34e0-e6aa-335b933599ad", 71.0, 6.0, 780793488, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "7db63e48-9a57-c5c7-6e6b-d39f5cd7db11", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5114), new DateOnly(2026, 1, 1), "Explicabo sed eveniet asperiores quaerat ea ratione laudantium sunt quia.", "56433424-0c06-62de-834b-9a1e6143f89f", 118.0, 2.0, -1445121657, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "7e92c9af-7bf5-2984-c557-e37d977df77c", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2222), new DateOnly(2025, 12, 31), "Sed in illum facere odio provident et est numquam nihil.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 78.0, 6.0, -1601722507, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "7e9e46e2-306b-5d9a-a808-dede83f14303", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(739), new DateOnly(2025, 12, 29), "Est rerum nulla fugiat quo qui porro natus repellat expedita.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 125.0, 2.0, -1288389735, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "7f7ad149-1109-c158-fff4-eebbbe975f6e", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5257), new DateOnly(2025, 12, 28), "Neque sint voluptas deserunt saepe ipsam et nihil rerum a.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 86.0, 5.5, -1445121657, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "7f864d7c-c67f-f56e-e2a6-e81caa0aabf5", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3773), new DateOnly(2025, 12, 25), "Aliquid nesciunt autem tempore dolorem molestiae veniam expedita molestiae consectetur.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 133.0, 1.5, 624061566, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "806e5516-5c93-8d42-1c43-f35ad12413e7", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6804), new DateOnly(2025, 12, 31), "Reiciendis soluta quod excepturi dolorum nihil at facere vero est.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 140.0, 1.5, 780793488, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "8286d046-9740-a3e4-95cf-ff46699c73c4", new DateTime(2025, 12, 25, 9, 49, 39, 339, DateTimeKind.Utc).AddTicks(6879), new DateOnly(2025, 12, 31), "Explicabo neque eum quibusdam ipsum autem nemo qui rerum iste.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 122.0, 6.0, 1180556736, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "836ed7e0-2d54-3cb8-ce6d-098490b6dbb6", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7105), new DateOnly(2025, 12, 28), "Quisquam soluta sit quidem fuga in debitis et ipsam sunt.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 129.0, 5.5, 1337157586, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "837a5313-e2ca-70ce-b21e-04e57c29273d", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4111), new DateOnly(2025, 12, 25), "Et et ex porro eveniet sit sunt officiis aut quia.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 75.0, 2.0, -888626487, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "8456df79-c368-d48c-080a-14c3b7d043a8", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1734), new DateOnly(2025, 12, 25), "Ut sed minima deleniti beatae ex dignissimos sit maxime fuga.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 137.0, 5.5, -1045358408, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "84625bac-78de-08a2-ebbb-0f23a3438f2f", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(40), new DateOnly(2025, 12, 31), "Provident odio corporis natus aliquid delectus distinctio ut non vero.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 82.0, 1.5, -731960101, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "853ee613-597d-6c5f-42a8-1f01dee9ab9a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4777), new DateOnly(2025, 12, 30), "Aut quisquam tempora voluptatem provident eos perferendis fugit quia nesciunt.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 144.0, 5.5, -888626487, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "854a6246-0ef2-a075-2559-1a62ca5df721", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3291), new DateOnly(2025, 12, 28), "Neque sapiente magnam in aut maxime tempora et a reprehenderit.", "09442776-8478-34e0-e6aa-335b933599ad", 90.0, 1.5, 1180556736, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "86326ae0-a407-3849-5ff6-25a0f1765f13", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6324), new DateOnly(2025, 12, 24), "Temporibus atque velit labore quaerat non quibusdam neque iure molestiae.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 97.0, 1.0, 1337157586, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "893e69dd-2a3d-1ad5-f5d1-352b9c7c7369", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3123), new DateOnly(2025, 12, 28), "Porro est vel dignissimos sed consequatur eaque minima harum cupiditate.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 133.0, 1.5, -332196852, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "8a267077-bf51-b2a9-2f6f-4069c395db5b", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9088), new DateOnly(2025, 12, 24), "Nisi et omnis veniam doloribus temporibus id vel inventore inventore.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 141.0, 1.5, 1580319985, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "8a32ecaa-74c7-e6bf-1220-3bcab00827e2", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6141), new DateOnly(2025, 12, 31), "Provident atque temporibus commodi voluptatem in qui voluptas nulla nostrum.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 86.0, 5.5, 1893652757, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "8b0e7710-5566-4a7d-690c-4ba8eaaf434d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2803), new DateOnly(2025, 12, 30), "Ut voluptas impedit consequuntur dignissimos similique quia voluptatum corrupti deserunt.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 148.0, 1.0, 1736986371, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "8b1af444-0adc-7e93-4cbd-4609d7228fd4", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1243), new DateOnly(2025, 12, 27), "Nesciunt consequatur id sed porro dolor reprehenderit molestiae ad dolorem.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 94.0, 5.0, -488863238, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "8c02fbdd-a0f0-1667-865b-5147fe3cf7c6", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4292), new DateOnly(2025, 12, 24), "Repellendus cupiditate nobis quae ipsum sapiente a cupiditate nihil ea.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 101.0, 5.0, -332196852, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "8cf67faa-eb7a-e250-a3aa-56e611c8ab3f", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5782), new DateOnly(2025, 12, 27), "Mollitia quis expedita delectus eveniet aliquid quod sunt sint consequuntur.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 54.0, 1.0, 1893652757, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "8f027ea7-71b0-c4dc-3884-6771bccebf95", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2111), new DateOnly(2025, 12, 30), "Non non enim ipsum quia eum voluptatibus est neque est.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 90.0, 1.0, 780793488, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "90ea8541-07c5-5db0-7222-72afe3e72787", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8126), new DateOnly(2025, 12, 27), "Sequi quae eius aut et laborum omnis repellendus officia quaerat.", "a24141d3-9394-90dc-1fed-01e130515792", 98.0, 1.0, -1601722507, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "90f60174-bc3b-91c6-55d3-6c10d05b730e", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5182), new DateOnly(2025, 12, 24), "Nisi quis dolore sunt ut modi voluptas id autem quos.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 145.0, 5.0, -1288389735, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "91d28ddb-9dd9-f584-acbf-7dee0a018f79", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2255), new DateOnly(2025, 12, 24), "Dolor similique dolorem pariatur vitae reprehenderit sed rerum sit autem.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 105.0, 1.0, -1445121657, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "91de090e-524f-299a-8f71-774ef774db00", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(773), new DateOnly(2025, 12, 30), "Ut consequatur adipisci non ex alias suscipit quo aut accusantium.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 51.0, 5.0, 624061566, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "92ba9474-33ed-8d58-e65d-882c311bf76b", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5292), new DateOnly(2025, 12, 29), "Voluptate dicta fugit eligendi sed quia est voluptatibus ducimus voluptas.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 112.0, 0.5, -1288389735, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "92c610a8-e863-c16e-c90e-828d1e8e43f2", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3806), new DateOnly(2025, 12, 26), "Mollitia voluptas qui est consequatur repellendus ut recusandae ut natus.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 58.0, 5.0, 780793488, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "93ad1841-7e77-5942-03ac-8dcb45a7abe4", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6838), new DateOnly(2025, 12, 23), "Modi pariatur sunt laborum ut error rem doloremque distinctio explicabo.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 65.0, 4.5, -1601722507, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "95c69371-b924-6fe3-7c38-98b7dd200bc1", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(632), new DateOnly(2025, 12, 24), "Laboriosam sit minus eveniet vel et molestiae aspernatur eligendi molestiae.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 148.0, 1.0, 1337157586, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "96ba173e-04ae-3bcd-9986-9e56f0adbf3a", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4178), new DateOnly(2025, 12, 27), "Voluptatem sunt nihil illum ut ipsa quo ratione et eligendi.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 102.0, 5.0, -731960101, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "97a21ed8-9ac2-d3a1-d324-a99417c6272c", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(107), new DateOnly(2025, 12, 23), "Dolor laborum et expedita asperiores dolorem minima et suscipit tempora.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 109.0, 4.5, 1180556736, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "97ae9a0b-4f38-07b7-b6d5-a3f5043a73b3", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7170), new DateOnly(2025, 12, 29), "Delectus pariatur soluta id ut iusto dolores adipisci quia praesentium.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 55.0, 1.0, -1045358408, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "98892672-30d6-6b75-0cc1-b4d33ee08f1e", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3325), new DateOnly(2025, 12, 29), "Voluptate magni animi dolores ducimus est pariatur nisi voluptas omnis.", "a24141d3-9394-90dc-1fed-01e130515792", 116.0, 4.5, 1337157586, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "9896a2a5-e54c-9f8b-f073-ae332a53dba5", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1768), new DateOnly(2025, 12, 26), "Deserunt quis et in quisquam numquam veritatis exercitationem unde asperiores.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 62.0, 0.5, -888626487, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "99712d0c-c5ea-0349-465f-bf1165faf710", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6358), new DateOnly(2025, 12, 26), "Aperiam et unde laboriosam et iure esse odio consectetur exercitationem.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 124.0, 4.5, -1045358408, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "997da93f-7b60-375f-2910-b972516d4397", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4811), new DateOnly(2026, 1, 1), "Eius necessitatibus in esse quia repellat harum reprehenderit reiciendis non.", "56433424-0c06-62de-834b-9a1e6143f89f", 69.0, 0.5, -731960101, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "9c7e2c08-4b21-e5d4-dc39-cf9c10ff0b66", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3224), new DateOnly(2025, 12, 29), "Sapiente saepe neque ut dolor et expedita iste iusto saepe.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 59.0, 4.5, 1580319985, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "9d6533a2-e135-7ea8-16d7-dada37197358", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9156), new DateOnly(2025, 12, 26), "Officia velit aut eum harum est modi et et molestiae.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 66.0, 4.5, 1736986371, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "9d71b0d5-96ab-b2be-f988-d53b248cbfdf", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6207), new DateOnly(2026, 1, 1), "Omnis et eos laudantium et quaerat odio id et distinctio.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 113.0, 0.5, -488863238, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "9e4d3b3c-7749-167c-5074-e5195e32db4a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2836), new DateOnly(2025, 12, 31), "Numquam recusandae inventore modi dicta molestiae autem facere exercitationem sapiente.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 73.0, 4.0, 1893652757, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "9e59b76f-2cbf-4a92-3326-e0794ba527d1", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1276), new DateOnly(2025, 12, 28), "Ea quia dicta corporis ea eaque aut cumque beatae adipisci.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 120.0, 0.5, -332196852, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "9f3542d6-0d5d-ae50-8a12-f057854c433c", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5814), new DateOnly(2025, 12, 28), "Nulla blanditiis consequatur veritatis perspiciatis non commodi pariatur quisquam dolores.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 81.0, 4.0, -488863238, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "9f41bf09-c2d3-e266-6dc3-ebb872bf8fc3", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4326), new DateOnly(2025, 12, 25), "Doloremque eligendi aperiam qui vel qui in et molestias qui.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 128.0, 8.0, 1580319985, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "a24141d3-9394-90dc-1fed-01e130515792", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2211), new DateOnly(2025, 12, 31), "Est optio dolorum ut illum est animi delectus delectus explicabo.", "56433424-0c06-62de-834b-9a1e6143f89f", 117.0, 4.5, 2136749619, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "a335c59f-de1e-5cc5-3c3b-068144de0b0b", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5275), new DateOnly(2025, 12, 25), "Officia blanditiis mollitia amet perspiciatis vitae iure perferendis sit eos.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 70.0, 8.0, 67631932, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "a41dcc39-7432-f499-76d9-11bf6bf873fc", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(806), new DateOnly(2025, 12, 31), "Numquam reiciendis perspiciatis doloremque repellat eos tenetur aut est qui.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 77.0, 8.0, 224298318, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "a429486c-29a8-28af-598a-0c20576bbf83", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8194), new DateOnly(2025, 12, 28), "In numquam similique aut enim rem ipsum veritatis qui et.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 124.0, 4.0, -2001551291, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "a505d4d3-0a46-8c6d-b076-1cfe9211dbee", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3840), new DateOnly(2025, 12, 28), "Voluptas dolores quos accusamus qui facilis cupiditate quia eaque non.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 85.0, 8.0, 2136749619, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "a5115006-bfbc-c083-9328-165e7e852775", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2288), new DateOnly(2025, 12, 25), "Accusantium id sint hic est magnam id nesciunt dolorem neque.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 132.0, 4.0, -1844884905, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "a6eddb6d-a05a-2441-ea14-273cb92b43e0", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6870), new DateOnly(2025, 12, 24), "Totam sit odio impedit voluptates nihil sunt nemo totam laudantium.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 92.0, 7.5, -2001551291, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "a6f957a0-55d0-5857-cdc5-219da59e8f67", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5325), new DateOnly(2025, 12, 30), "Et quaerat laudantium temporibus sit aperiam nemo quaerat aliquam optio.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 139.0, 4.0, 67631932, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "a905569d-db07-3ae3-63a0-322750a4a3bd", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1033), new DateOnly(2025, 12, 25), "Qui et vitae asperiores blanditiis excepturi unde autem dolores exercitationem.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 74.0, 4.0, -1601722507, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "a9f9da6a-2691-07cd-80ef-37c764305736", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4288), new DateOnly(2025, 12, 28), "Qui quaerat illo repudiandae sit et sit nihil quo veritatis.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 128.0, 8.0, 624061566, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "aae1e103-bca5-9fa1-ba8c-42058b4abf28", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(173), new DateOnly(2025, 12, 24), "Accusantium dolor alias facere quidem nobis eveniet occaecati eos mollitia.", "56433424-0c06-62de-834b-9a1e6143f89f", 136.0, 8.0, 780793488, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "aaed5e37-711b-d3b7-9d3d-3d6677bd0baf", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7274), new DateOnly(2025, 12, 31), "Non sit doloremque fugiat voluptates exercitationem fugit rem molestiae eum.", "a24141d3-9394-90dc-1fed-01e130515792", 81.0, 4.0, -1445121657, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "abc9e99d-51b9-3774-f42a-4d43b264271a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3357), new DateOnly(2025, 12, 30), "Et ullam hic mollitia explicabo totam totam et similique magni.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 143.0, 7.5, -1601722507, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "abd565d0-072f-6b8a-d7db-48a49ed773a1", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1801), new DateOnly(2025, 12, 27), "Quo ut reiciendis cum commodi architecto nobis similique ex commodi.", "09442776-8478-34e0-e6aa-335b933599ad", 89.0, 3.5, -1288389735, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "acb1f037-e7cd-cf48-2dc7-5882d97d8f0c", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6392), new DateOnly(2025, 12, 27), "Minima qui eveniet iusto unde dolore eaque porro repellat nam.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 150.0, 7.5, -1445121657, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "acbd6d6a-9c43-035e-1178-53e3c5f0db93", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4845), new DateOnly(2025, 12, 24), "Laudantium inventore et sint qui vero magnam nam repellendus eveniet.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 96.0, 3.5, 624061566, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "afbdef34-6d04-b1d4-c3a2-690c8483a262", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3292), new DateOnly(2025, 12, 30), "Quia veritatis excepturi rerum qui qui ad fugiat et voluptatem.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 85.0, 7.5, 1736986371, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "b0b17301-b88e-7dbe-e0f1-6eac970f56db", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6301), new DateOnly(2025, 12, 24), "Voluptatem qui corrupti natus unde sed inventore aut blanditiis doloremque.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 140.0, 3.5, -332196852, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "b1997a9b-4ea2-1592-1a8e-79eabe29becd", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1328), new DateOnly(2025, 12, 30), "Est nisi iusto in alias eveniet et reiciendis rerum error.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 147.0, 3.5, 1580319985, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "b1a5f7ce-0318-49a8-fd3f-744bab9c0a54", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9241), new DateOnly(2025, 12, 27), "Fugiat qui praesentium deleniti ad molestias nulla non libero quibusdam.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 93.0, 7.5, 1893652757, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "b2818234-e4b7-ad65-542c-8429e54326bf", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4358), new DateOnly(2025, 12, 26), "Ad eos eum et praesentium soluta velit architecto ipsam aspernatur.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 53.0, 3.0, 1736986371, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "b28dfe67-992c-e17c-37dd-7f89d2b67246", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2869), new DateOnly(2025, 12, 24), "Laudantium aut voluptate voluptatem minus nostrum velit accusantium aspernatur sit.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 100.0, 7.5, -488863238, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "b3750601-2f41-794f-717a-8ac8f9cfda38", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5847), new DateOnly(2025, 12, 29), "Sunt fuga ex neque amet quasi voluptatibus quia non et.", "09442776-8478-34e0-e6aa-335b933599ad", 107.0, 7.0, -332196852, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "b67588cb-0001-28c5-24a4-a0f1b762a207", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5341), new DateOnly(2025, 12, 26), "Fugiat fuga rerum quis amet earum consequatur nostrum maiores incidunt.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 97.0, 3.5, 224298318, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2283), new DateOnly(2025, 12, 24), "Sit et ut consequatur praesentium unde modi et est laudantium.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 144.0, 7.5, -2001551291, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "b75d9065-9616-c099-5d41-ab30de7b0af9", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(853), new DateOnly(2025, 12, 23), "Praesentium ratione saepe consequuntur rerum quisquam sunt iure esse voluptas.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 104.0, 3.0, 2136749619, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "b7690c98-4b8c-f4af-40f3-a591cbee5680", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8288), new DateOnly(2025, 12, 29), "Facilis eum sint quia repudiandae sit temporibus laboriosam sed repellat.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 50.0, 7.0, -1844884905, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "b84597ff-2c2a-586d-97df-b66e059572eb", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3882), new DateOnly(2025, 12, 29), "Dicta nam voluptas delectus aspernatur quas qui atque nulla ullam.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 111.0, 3.0, -2001551291, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "b8511332-e1a0-8c83-7a90-b0cff208be72", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2335), new DateOnly(2025, 12, 26), "Enim et et quae quis aut ea iusto et provident.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 57.0, 7.0, 67631932, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "b92d9e98-c23e-f040-d17c-c1ad2caedadd", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6903), new DateOnly(2025, 12, 25), "Quo amet temporibus consequatur omnis veniam quo culpa enim fugiat.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 119.0, 3.0, -1844884905, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "b9391bcb-77b4-2457-b42e-bb0e19222664", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5358), new DateOnly(2026, 1, 1), "Eveniet molestiae vel rerum dolorem saepe molestiae provident inventore et.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 65.0, 7.0, 224298318, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "bc399d95-4875-d2cc-6757-d137d7b4ee33", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4358), new DateOnly(2025, 12, 29), "Facilis molestiae ea perferendis dolorem voluptas hic cumque sint et.", "09442776-8478-34e0-e6aa-335b933599ad", 54.0, 3.0, 780793488, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1137), new DateOnly(2025, 12, 26), "Eum libero et sunt aspernatur quis dolorem et corporis nam.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 101.0, 7.0, -1445121657, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "bd2d2162-92ff-9eb6-84a6-d7d7eb41a2ac", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7342), new DateOnly(2026, 1, 1), "Blanditiis amet vel recusandae omnis sequi minus placeat minus velit.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 108.0, 7.0, -1288389735, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "be1528fc-2813-368a-be43-e215125a0a9e", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1850), new DateOnly(2025, 12, 28), "Vitae impedit voluptas est aut recusandae corporis nulla nesciunt minus.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 115.0, 7.0, 624061566, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "be21a52f-dd89-6aa0-a1f4-dc76fecd5625", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(267), new DateOnly(2025, 12, 26), "Enim hic aliquid at minima perspiciatis occaecati quibusdam rerum delectus.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 61.0, 3.0, -1601722507, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "bf09acc9-739d-0274-db92-e7b425e7be17", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3409), new DateOnly(2025, 12, 31), "Eveniet totam ullam eligendi id voluptas dicta saepe autem et.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 69.0, 2.5, -1445121657, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "bffd3096-be27-ce5e-f8e1-ed5339747290", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4896), new DateOnly(2025, 12, 25), "Impedit incidunt enim laborum laudantium porro officiis earum officia ut.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 123.0, 6.5, 780793488, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "c0f1b463-09b1-9a48-152f-f2f34c012609", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6425), new DateOnly(2025, 12, 28), "Cupiditate doloribus dolore provident consectetur odit expedita doloribus aut aperiam.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 76.0, 2.5, -1288389735, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "c3f1362c-da72-49bd-c759-081c0b93eed8", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6372), new DateOnly(2025, 12, 25), "Ut doloribus quo expedita consectetur reiciendis soluta nesciunt voluptatem in.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 65.0, 6.5, -731960101, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "c3fdb25f-8fe8-7cd3-aa0a-037df7063a5f", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3362), new DateOnly(2025, 12, 31), "Qui incidunt eos id laudantium officia saepe aut quae harum.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 112.0, 3.0, 1337157586, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "c4d93ec6-7086-e191-01f6-135b32ad56ca", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1362), new DateOnly(2025, 12, 31), "Saepe excepturi repellendus et est possimus dolore aliquam est recusandae.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 73.0, 6.5, 1180556736, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "c4e5baf9-25fc-15a7-e4a8-0ebc1e20a251", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9308), new DateOnly(2025, 12, 28), "Vitae facere consequatur culpa sint consequatur laudantium quia voluptatum dolorem.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 119.0, 2.5, -1045358408, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "c5c14560-069a-7965-3b94-1e9959c6bebc", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4408), new DateOnly(2025, 12, 28), "Occaecati doloremque minus laboriosam aut ut illum aliquid sed totam.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 80.0, 6.5, 1337157586, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "c5cdc193-bb10-ad7b-1e45-19fa45390a43", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2929), new DateOnly(2025, 12, 25), "Impedit enim possimus quam autem voluptatem aperiam corporis et cumque.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 127.0, 2.5, -888626487, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "c6b5c92d-5124-454f-58e3-23396c537235", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5901), new DateOnly(2025, 12, 30), "Suscipit autem nihil quaerat eum non animi in suscipit ut.", "a24141d3-9394-90dc-1fed-01e130515792", 134.0, 2.0, -731960101, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "c9b54bf7-22e5-f3c4-0b0c-3a622be53a04", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5410), new DateOnly(2025, 12, 28), "Beatae autem exercitationem eum eum et fuga similique autem animi.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 123.0, 6.5, 1580319985, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "c9c1c82a-d75b-27da-eebd-34c31858868b", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2357), new DateOnly(2025, 12, 25), "Voluptatem aperiam voluptatem laudantium aut velit voluptas occaecati in fugiat.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 69.0, 2.5, 1893652757, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "caa9cfc3-6d6f-bfae-285b-3f013f72ee7d", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8354), new DateOnly(2025, 12, 30), "Necessitatibus iste ut corporis iste consectetur voluptate et consequatur consequatur.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 76.0, 2.5, -488863238, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "cb91d75d-0383-5782-61f8-4a40658c566f", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2369), new DateOnly(2025, 12, 27), "Sint architecto numquam ratione perferendis aut reiciendis quo iusto ut.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 84.0, 2.0, -332196852, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "cb9d5390-b8f9-8b98-45aa-44a152ffa2f6", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(885), new DateOnly(2025, 12, 24), "Nihil ipsam et modi quis culpa adipisci nam eius dolores.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 131.0, 6.0, 1736986371, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "cc79def7-9997-ef56-9b96-557e8ca5be61", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5411), new DateOnly(2025, 12, 24), "Ratione mollitia neque maiores totam facere unde consequatur et iusto.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 91.0, 2.0, 1580319985, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "cc855a2a-4e0d-236c-7e47-4fdf79180ae8", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3915), new DateOnly(2025, 12, 30), "Sit fugiat consectetur et quod commodi omnis omnis est libero.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 138.0, 6.0, 1893652757, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "cd6d62c4-e321-bb40-b8e5-5a1ea03272da", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6957), new DateOnly(2025, 12, 27), "A ex eos et adipisci qui sit vero beatae sed.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 145.0, 6.0, -488863238, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "cf85ddf4-1ece-d1e2-3171-650938abd2b7", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1222), new DateOnly(2025, 12, 27), "Architecto quo dolor consectetur quod incidunt repellendus non odit aperiam.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 127.0, 2.5, -1288389735, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "d06de48e-b4e2-6ab5-6b0e-70475fc43aa9", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7409), new DateOnly(2025, 12, 24), "Cumque ex qui doloremque velit perferendis ex accusantium sed similique.", "56433424-0c06-62de-834b-9a1e6143f89f", 135.0, 2.0, 624061566, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "d07961c1-6958-9ecc-4ebf-6ba84b378630", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4427), new DateOnly(2025, 12, 30), "Necessitatibus mollitia facere aut totam fuga similique reiciendis quia et.", "a24141d3-9394-90dc-1fed-01e130515792", 80.0, 6.0, -1601722507, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "d155ec27-4af6-0289-a5ac-7b8686dea29b", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1883), new DateOnly(2025, 12, 30), "Voluptas debitis tempore accusamus et quibusdam et quia delectus aut.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 142.0, 2.0, 780793488, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "d161685b-ff6c-369f-885d-76e77251ee22", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(335), new DateOnly(2025, 12, 27), "Sint sed cumque hic molestiae ea eos architecto facere suscipit.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 88.0, 6.0, -1445121657, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "d23df3c1-e00a-9a5d-df49-86c4adf70a8d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4929), new DateOnly(2025, 12, 26), "Tenetur in dolorum quo odit in quos eius qui quidem.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 149.0, 1.5, -1601722507, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "d2496ff4-9580-ce73-c2fa-8125996b5614", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3442), new DateOnly(2025, 12, 23), "Qui quidem est temporibus vel amet impedit ipsum dolor accusamus.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 95.0, 6.0, -1288389735, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "d330778e-2b94-6647-fc98-8c63c084be06", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6474), new DateOnly(2025, 12, 29), "Assumenda nesciunt mollitia harum fugiat delectus ad ut est ea.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 102.0, 5.5, 624061566, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "d631f958-fc55-14bd-aec1-a28d7f1686d4", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6440), new DateOnly(2025, 12, 26), "Excepturi nesciunt amet possimus quo quo ullam iusto et assumenda.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 92.0, 2.0, 1180556736, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "d63d768b-b1cb-48d3-9173-9cee6b8ad25c", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3432), new DateOnly(2025, 12, 24), "Cumque in non quo odit ducimus sint iure at alias.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 139.0, 6.0, -1045358408, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "d7257d25-47df-e0a7-cb10-a72c92a33a4d", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9375), new DateOnly(2025, 12, 29), "Voluptas et nesciunt cum error tempora vitae atque veniam sed.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 146.0, 5.5, -888626487, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "d80c85bf-ddf3-787a-05ae-b26bb9bda23f", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2962), new DateOnly(2025, 12, 26), "Tenetur odio odit sint sit aut et culpa impedit quasi.", "56433424-0c06-62de-834b-9a1e6143f89f", 52.0, 5.5, -731960101, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "d81901f2-9269-ac91-e85f-adcca630eec6", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1395), new DateOnly(2025, 12, 23), "Eos soluta dolores mollitia nostrum et accusamus provident dolores corporis.", "a24141d3-9394-90dc-1fed-01e130515792", 99.0, 1.5, 1337157586, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "d900088b-287d-4464-22fc-b80acd4a56b8", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4442), new DateOnly(2025, 12, 29), "Voluptas sed vitae iusto maxime in iusto et molestiae quo.", "09442776-8478-34e0-e6aa-335b933599ad", 106.0, 1.5, -1045358408, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "d9f48c58-7308-104e-3f4b-bda9e0d60a31", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5935), new DateOnly(2026, 1, 1), "Culpa sapiente illo ea rem temporibus modi cum eos id.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 60.0, 5.5, 1180556736, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "dc018b55-f93e-f2da-d526-ce348bdc1e87", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2431), new DateOnly(2025, 12, 26), "Molestias sed libero natus maxime enim praesentium autem eum sed.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 96.0, 5.5, -488863238, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "dde892ef-8f52-8bae-0fc3-d972b2f58679", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8422), new DateOnly(2026, 1, 1), "Dolores est et ea sed ab doloremque saepe vel id.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 103.0, 5.5, -332196852, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "ddf50f22-44c8-bfc4-f275-d3d39f69d200", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5478), new DateOnly(2025, 12, 29), "Quia sapiente facilis atque voluptatum distinctio et nulla mollitia ut.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 150.0, 1.5, 1736986371, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "ded09a89-2467-2382-4961-e4b1d90fee6b", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2402), new DateOnly(2025, 12, 28), "Voluptas et error et expedita fugiat mollitia doloribus labore enim.", "a905569d-db07-3ae3-63a0-322750a4a3bd", 110.0, 5.0, 1580319985, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "dedc16bc-dadc-5798-2c12-de11c6823af2", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(918), new DateOnly(2025, 12, 26), "Hic atque deserunt quia non odio vel earum accusantium quas.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 56.0, 1.5, 1893652757, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "dfb8a123-ba7b-bb55-83fe-efef0029565d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5445), new DateOnly(2025, 12, 25), "Reprehenderit voluptas excepturi vitae aut laborum dolorem dicta libero aut.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 118.0, 5.0, 1736986371, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "dfc41e56-6ff1-ef6c-66b0-e950ed9ca2e4", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3949), new DateOnly(2025, 12, 31), "In alias ut neque eum modi eum eaque blanditiis eaque.", "dc018b55-f93e-f2da-d526-ce348bdc1e87", 64.0, 1.0, -488863238, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "e0ac25ef-0505-873f-9f4d-f48e14b60ad6", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6991), new DateOnly(2025, 12, 28), "Sed cupiditate corrupti alias quo alias hic dolores rerum sunt.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 71.0, 1.0, -332196852, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1309), new DateOnly(2025, 12, 28), "Voluptatem consequatur magni quis eum explicabo ea sed repudiandae ea.", "09442776-8478-34e0-e6aa-335b933599ad", 53.0, 5.5, 67631932, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "e3aca8b9-d6c6-35b5-5276-0ab8d248d2a5", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7476), new DateOnly(2025, 12, 25), "Rerum non beatae consequuntur voluptas officiis aut ullam nisi itaque.", "8286d046-9740-a3e4-95cf-ff46699c73c4", 60.0, 5.0, 224298318, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "e3b824ec-8b3b-69cb-3528-0519bfbb1e2c", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4498), new DateOnly(2025, 12, 31), "Dolores voluptas aut quia fugit atque consectetur magnam consequuntur ipsum.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 107.0, 1.5, -2001551291, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "e494af53-6cda-cd89-8c14-15f7f9613a97", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1917), new DateOnly(2025, 12, 31), "Sunt quae voluptatem ut exercitationem expedita perspiciatis in assumenda rem.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 68.0, 5.0, 2136749619, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "e4a02b86-2150-019f-6fc5-1057e6d5861e", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(402), new DateOnly(2025, 12, 28), "Omnis quis ab ab similique voluptatem possimus aliquid iste nihil.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 114.0, 1.0, -1844884905, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "e5883320-b764-9973-a963-1b960deeee10", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3475), new DateOnly(2025, 12, 25), "Iure aut repellat necessitatibus voluptatem quae voluptas ducimus maiores labore.", "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6", 122.0, 1.0, 67631932, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "e6703aba-4d78-3147-e300-25d434085602", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6508), new DateOnly(2025, 12, 30), "Perferendis voluptas rerum qui voluptatum dolorem saepe perspiciatis esse est.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 129.0, 0.5, 224298318, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "e67cb6ed-02ee-655d-c6b1-2035207ba289", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4961), new DateOnly(2025, 12, 27), "Sed similique ut consequatur placeat iusto aut dolores velit consequatur.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 75.0, 5.0, -2001551291, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "e97c39b6-d3af-13d2-79db-365fdf0d6a58", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3506), new DateOnly(2025, 12, 25), "Rerum similique natus recusandae facere nemo dolores distinctio expedita quis.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 64.0, 1.0, -1445121657, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "ea644050-69c3-aca6-b278-419d0627d24a", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9443), new DateOnly(2025, 12, 30), "Sunt sunt molestias est quia dicta nihil possimus dicta et.", "09442776-8478-34e0-e6aa-335b933599ad", 72.0, 1.0, -1288389735, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "ea70bd83-1e39-e0bc-962a-3cfef29a1ed1", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6509), new DateOnly(2025, 12, 28), "Possimus voluptas sed at deleniti optio sint impedit officiis eos.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 118.0, 5.0, 780793488, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "eb4c48ea-ffd7-447a-ec16-4cdc2d403a3c", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2994), new DateOnly(2025, 12, 27), "Velit est blanditiis et distinctio accusamus enim vero sint odio.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 79.0, 0.5, 624061566, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "eb58c41d-b44d-7890-cfc7-473c19b486c3", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1429), new DateOnly(2025, 12, 24), "Eum pariatur atque optio recusandae deleniti corrupti consequatur ullam tempore.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 126.0, 4.5, -1601722507, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "ec344f84-95eb-dc4e-26b3-571a545aa22e", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6024), new DateOnly(2025, 12, 24), "Dolorem magni ea blanditiis fugit est voluptas tenetur rerum aut.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 86.0, 0.5, 780793488, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "ec40ccb7-4a61-1064-0965-517b40cdeeb5", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4476), new DateOnly(2025, 12, 30), "Aut quis et sed iure quaerat inventore et qui quia.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 133.0, 4.5, -1445121657, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(2524), new DateOnly(2025, 12, 27), "Facere quis sit distinctio reprehenderit magni beatae quasi amet sunt.", "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3", 122.0, 0.5, -332196852, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "f028561a-b036-56ad-f62c-72e326791d76", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(8489), new DateOnly(2025, 12, 24), "Eum saepe delectus et nulla voluptates est dolorem et odit.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 130.0, 0.5, 1580319985, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "f034d24e-65ac-8ac3-d9dd-6d4412ec69fd", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(5545), new DateOnly(2025, 12, 30), "Similique magni asperiores culpa sed occaecati et sed ea laboriosam.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 76.0, 4.5, 1893652757, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "f1105db4-464a-ee81-30c9-7d214d938568", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(2435), new DateOnly(2025, 12, 30), "Aut velit repudiandae laboriosam ullam eligendi eius ut quae rerum.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 137.0, 0.5, 1736986371, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "f11cd9e7-fbc0-2297-137a-78823906d1ef", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(951), new DateOnly(2025, 12, 27), "Adipisci et earum quam sunt ullam et numquam fugiat officiis.", "8f027ea7-71b0-c4dc-3884-6771bccebf95", 83.0, 4.5, -488863238, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "f204e181-91d4-ba6b-4d18-83c1601f39e1", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3982), new DateOnly(2025, 12, 23), "Qui quia necessitatibus voluptatem accusantium vitae alias ipsam quaerat voluptate.", "f604634b-6295-68e1-ff41-99ea1fb201b0", 90.0, 4.0, -332196852, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "f3ece81b-27e8-523f-87b5-8eff8739a1d3", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(7025), new DateOnly(2025, 12, 29), "Ducimus eligendi quo aut deleniti et similique velit est earum.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 98.0, 4.0, 1580319985, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "f3f8654e-dc5e-8655-6a67-886074aced5a", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(5478), new DateOnly(2025, 12, 26), "Quidem recusandae eos sit facere rem repellendus commodi voluptatum quia.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 144.0, 8.0, 1893652757, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "f604634b-6295-68e1-ff41-99ea1fb201b0", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(1455), new DateOnly(2025, 12, 30), "Error quia deleniti iure doloremque tenetur accusantium deleniti porro est.", "b68104fe-b577-5bdb-0755-9a52a4d5ee8e", 80.0, 0.5, 224298318, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "f6f8e718-ad1f-35ca-1c90-9e8a323eb529", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(4604), new DateOnly(2025, 12, 24), "Vel recusandae qui nemo possimus nisi consequatur non recusandae ut.", "6982f750-2dea-2ddd-6ab4-338fd5c7909c", 134.0, 4.5, -1844884905, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "f7e0efb2-4333-cd9e-562e-a9c859581d1b", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(469), new DateOnly(2025, 12, 29), "Consequatur blanditiis in ratione non quia vel fuga commodi architecto.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 141.0, 4.0, 67631932, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "f7ec6be5-f8a9-01b4-39df-a42946cb69a2", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(7541), new DateOnly(2025, 12, 26), "Consectetur optio molestiae tempora atque minus deserunt in ratione nemo.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 87.0, 0.5, 2136749619, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" },
                    { "f8c8f64b-d947-6572-90cb-b4078072850d", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3509), new DateOnly(2025, 12, 26), "Harum reiciendis ut maiores nam et rerum est temporibus est.", "c9c1c82a-d75b-27da-eebd-34c31858868b", 148.0, 4.0, 224298318, 0, "a905569d-db07-3ae3-63a0-322750a4a3bd" },
                    { "f8d4727e-8ebd-9988-737c-af676de5d194", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1952), new DateOnly(2025, 12, 23), "Qui numquam quis et itaque sint neque tempore in voluptas.", "95c69371-b924-6fe3-7c38-98b7dd200bc1", 94.0, 8.0, -2001551291, 0, "95c69371-b924-6fe3-7c38-98b7dd200bc1" },
                    { "f9b0fee5-6f5b-fd46-ca69-bf45a78bedff", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(6541), new DateOnly(2026, 1, 1), "Quaerat dolores exercitationem eum sed nobis sint qui eius qui.", "420371f9-ea23-96de-9ce3-00aeeec060a2", 55.0, 4.0, 2136749619, 0, "cf85ddf4-1ece-d1e2-3171-650938abd2b7" },
                    { "f9bc7a18-24d1-315c-ad1a-baa694fe3986", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4995), new DateOnly(2025, 12, 29), "Ducimus id voluptatem et reprehenderit exercitationem qui est consequatur autem.", "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798", 101.0, 8.0, -1844884905, 0, "bc4519c8-fdeb-06e2-4a08-cc98c4273aba" },
                    { "fcbcfce2-f592-dfd2-6043-d0d053910155", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(3603), new DateOnly(2025, 12, 26), "Consectetur id voluptates aperiam qui dolorem facere itaque laudantium quod.", "bc4519c8-fdeb-06e2-4a08-cc98c4273aba", 91.0, 4.0, -1288389735, 0, "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3" },
                    { "fda4047c-8ba6-77a5-9ae1-db0e7aaa6947", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(9543), new DateOnly(2026, 1, 1), "Illum quaerat vero officiis pariatur rerum quia aperiam saepe ad.", "a24141d3-9394-90dc-1fed-01e130515792", 98.0, 4.0, 624061566, 0, "09442776-8478-34e0-e6aa-335b933599ad" },
                    { "fdb080af-401c-abbc-7d92-d56f661db5ce", new DateTime(2025, 12, 25, 9, 49, 39, 341, DateTimeKind.Utc).AddTicks(6594), new DateOnly(2025, 12, 29), "Alias et rerum tenetur quia iste ut maiores cum molestias.", "ef404e81-1b22-bed9-bc8e-68a5ff5fb584", 145.0, 8.0, -1601722507, 0, "f604634b-6295-68e1-ff41-99ea1fb201b0" },
                    { "fe8c0b16-21ba-0f79-d37e-e64ca0c4d139", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(3027), new DateOnly(2025, 12, 28), "Dignissimos omnis aut quo corporis qui necessitatibus magni voluptatem consequatur.", "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9", 105.0, 3.5, 780793488, 0, "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6" },
                    { "fe988849-d630-438f-b730-e0ad8d371dc0", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(1461), new DateOnly(2025, 12, 25), "Et sit fugiat autem in laboriosam odit vitae odit ipsa.", "56433424-0c06-62de-834b-9a1e6143f89f", 51.0, 8.0, -1445121657, 0, "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9" },
                    { "ff808fe2-6c44-db63-f0cd-ebecb45185b2", new DateTime(2025, 12, 25, 9, 49, 39, 342, DateTimeKind.Utc).AddTicks(4509), new DateOnly(2025, 12, 31), "Aliquam ut dolor harum doloremque sed cum dolor sed in.", "cf85ddf4-1ece-d1e2-3171-650938abd2b7", 59.0, 7.5, -1288389735, 0, "8286d046-9740-a3e4-95cf-ff46699c73c4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntries_EmployeeId",
                table: "TimeEntries",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntries_ProjectId",
                table: "TimeEntries",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntries_WorkTypeId",
                table: "TimeEntries",
                column: "WorkTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "TimeEntries");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
