using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntreprenadPro.Migrations
{
    /// <inheritdoc />
    public partial class AddedPropertiesToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "character varying(13)",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OrgNumber",
                table: "Customers",
                type: "character varying(13)",
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress",
                table: "Customers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "Customers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmMQNkrn2H1DfTEXcFEZ9i9kVLkGJzl+jd+pjfrn93XozroZmMGKM1hhOzDHLalgg==");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(5376), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(5474), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(5604), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 214, DateTimeKind.Utc).AddTicks(8624), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(4101), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(4500), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(4637), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(4941), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(5066), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                columns: new[] { "Address", "BillingAddress", "City", "CreatedAt", "PostalCode" },
                values: new object[] { null, null, null, new DateTime(2025, 11, 18, 19, 44, 31, 215, DateTimeKind.Utc).AddTicks(5215), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -2001551291,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1844884905,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1601722507,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1445121657,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1288389735,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1045358408,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -888626487,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -731960101,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 224, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -488863238,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -332196852,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 67631932,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 224298318,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 624061566,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 780793488,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1180556736,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1337157586,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1580319985,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1736986371,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1893652757,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2136749619,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 226, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "007413af-b7ce-a74d-0d1c-f18bc7de392b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "03749579-878f-56c3-c045-07b5867001fa",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "038011ac-3c05-89d9-a3f7-011573e34d81",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "045c9d13-1da3-ee97-fae3-12f3ad8969ec",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "04681946-d219-22ad-dd94-0c549afdb573",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0544a4ad-b3b7-866a-3480-1d32d4a3d1de",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "055020e0-682d-ba81-1732-1792c1161d65",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0638287a-fe42-5254-51cf-22d1e8308557",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0938aa43-cf02-00ca-03f8-38faa6c24d26",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a20b2dd-6516-989e-3d96-4339cddcb517",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a2c2e10-1a8c-ccb4-2047-3e9aba4f019e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b08b977-fb2b-3072-7733-4e77f4f51d09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b1436aa-b0a1-6488-5ae5-49d8e1686990",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0cfc3d44-46b5-fc5c-9482-54170882d182",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0df0c111-913f-c845-b1d1-59b61b0f85fb",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10f043da-6200-77bb-64fa-6fe0daa14dca",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10fcc00e-1776-abd1-47ac-6a40c6149951",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7207), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11d84b74-f814-0f8f-9e98-7a1e01bbb5bc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11e4c7a7-ad8a-43a5-8149-757fed2e0143",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12c0520e-8d28-a763-d835-855c28d41dae",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12cccf41-429e-db79-bbe7-7fbd14476935",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "13b3d6db-d8b2-734d-f484-8afc3b61d127",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5921), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16b459a5-a973-21c2-a7ae-a025faf399f6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16c0d5d8-5ee9-55d8-8a5f-9b86e666e57d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "179c603e-3f87-b996-e14b-ab64210d01e8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5975), new DateOnly(2025, 11, 23) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "17a8dc72-f4fd-edac-c4fc-a6c50d804d6f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188367d8-d59b-516a-1be9-b6a2482669da",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188fe40b-8a11-8580-fe9a-b103349ab561",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1977eba5-2025-1d54-3837-bc425bb31d53",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d6bf13c-3c70-98b3-07b0-d70a2dd2999b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d786e6f-f1e6-ccc9-eb61-d26b1a45e522",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e53f9d6-d284-3087-414d-e24954ec018d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e5f7509-87fa-649d-24fe-ddaa415f4d14",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f3b006f-6898-c85b-7beb-ed877b06697f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f477da2-1d0e-fc71-5e9c-e8e86879b506",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "202f843c-b322-9445-9839-f3278f921df8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "232f0706-83e3-42ba-4b63-09504d25e5c7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "233b8339-3959-76d1-2e14-03b13a98314e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24170ea0-19f7-da8e-8500-148f743e4db9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24238ad3-ce6d-0ea4-68b2-0ef061b19940",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "250b926d-6481-a678-a24f-192e88cb0132",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "25ff163a-af0b-7262-bf9e-1fcd9b58b5ab",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "26f39906-fa95-3e4c-dced-246cafe56924",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "29ff9803-80cc-20d8-71c7-35f75aea7d7a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2ae7a09d-16e0-b9ac-ab65-40358104e56c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2af31cd0-cb56-edc2-8e16-3a966d7731f3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bcfa737-acf4-517f-e502-4b74a81d4d5e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9200), new DateOnly(2025, 11, 18) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bdb236a-616a-8595-c8b4-45d5949099e5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cb7aed1-4208-e953-1fa0-56b2cf37b550",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cc32b04-f77e-1d69-0251-5013bbaa01d7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30abb567-5e53-63b3-ef18-717ba1563098",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30b7319a-13c9-97c9-d2c9-6cdc8ec97c1f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8425), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3193bc01-f467-fb87-29b5-7cbac86f988a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "319f3834-a9dd-2f9d-0c67-771ab5e3e411",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "327bc49b-8a7c-935a-6253-87f8ef89007c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "328740ce-3ff2-c770-4504-8259dbfc4c03",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "336f4768-d406-5f44-7fa2-8c970216b4f5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6966), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "366fca31-a5c6-0eba-32cb-a3c1c1a87cc4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "367b4665-5a3c-42d0-157c-9d22ae1bc84b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "37634efe-f051-daa4-4f1a-a860d535303d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "384b5598-8665-7278-89b7-b39ffc4e982f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3857d1cb-3bdb-a68e-6c69-ad00e8c2e4b6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "39335d32-1c79-0a4c-c355-bedd23680021",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "393fd965-d1ef-3e62-a606-b83e0fdb4ca8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3c3f5b2f-a2b0-ecd7-5830-ce68ce6d1477",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d2763c9-38c4-84ab-92cd-d9a6f5877c68",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d33dffc-ed3a-b8c1-757e-d407e1fac8ef",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e0f6a62-ced8-1c7f-cc6b-e4e51ca1e45a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e1be795-834e-5095-af1c-df45081430e1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3f03ee2f-1962-e869-e9b9-ea842f2e98d3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2163), new DateOnly(2025, 11, 22) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3ff772fc-64ec-b453-0608-ef2343ba4c4c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43eb7893-8037-2fb2-d680-0bec15d9c894",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1717), new DateOnly(2025, 11, 25) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43f7f4c6-35ad-63c8-b932-054d014d141b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "44dffc60-cbc1-fb9c-f3cf-108b28667c0d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45c703f9-60d5-9370-2d6d-1bca4f80e4ff",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45d37f2d-154b-c786-101e-162a3cf33086",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46af0b93-f6e9-2b44-660a-260876994cf1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46bb87c6-ab5f-5f5a-4abb-2169630d9878",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "49bb0990-7c20-0dcf-fce5-3793219f6047",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aa3112a-1234-a5a3-3682-42d148b8c839",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aaf8d5d-c7aa-d9b9-1934-3c32352c14c0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b8b18c4-a848-3d77-7020-4d106fd2302b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b9795f7-5dbe-718d-53d1-47705c457cb2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c73205d-3e5c-d54b-aabd-584e96ec981d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c7f9c91-f3d2-0961-8d6f-52af835fe4a4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4f7f1f5a-c493-b7d7-4098-68d841f1ac73",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "506726f4-5aa7-50aa-7935-7317680b1465",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5073a227-0f1d-84c1-5de7-6e78557e60ec",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "515baac1-a531-1c94-9684-79b67c97c8de",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5243b15b-3b45-b468-d022-84f5a3b130d0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "524f2e8e-f0bb-e87e-b3d3-7e558f247c57",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "53363528-86cf-8052-ed70-8994b63ee449",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5637b8f1-5790-2ec8-a09a-9fbe75d0ac18",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "571fbf8b-eca4-c69c-da37-aafc9cea140a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5178), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "572b3bbe-a11a-fab2-bde9-a55d885d6091",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5806c725-82b8-5e6f-14d5-b53ac3037cfc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "58124358-372e-9285-f786-b09baf76c883",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59eecebf-18cd-f643-4e72-c079ea1de4ee",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59fa4af2-cd42-2a59-3124-badad6903075",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5cfbcdbc-9e03-d9cf-e34d-d1039522f844",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5de2d455-3417-71a3-1deb-db42bc3c6036",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5dee5088-e98d-a5b9-009c-d6a3a8afacbd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5ed65822-7fa1-3d8d-3a39-e1e1cfc914af",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fbe5fbc-15b6-d560-74d7-ec20f6e27ca1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3305), new DateOnly(2025, 11, 22) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fcadcef-ca2c-0977-5788-e680e356c828",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "60b2e389-6040-a14a-9126-f1bf0a6f301a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63b26653-3101-4fc0-444f-07e8c901f8e9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63bee286-e676-83d6-2700-0249b5744470",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "649a6ded-c715-e794-7eed-1227f01b60db",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "64a6e920-7c8b-1baa-619e-0d88dc8eac62",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "65827586-5d29-7f68-b78a-1d651635c8cd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "658ef1b9-129f-b37e-9a3b-18c603a81454",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6676f853-a8b3-4b52-d4d9-23052ac17c46",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "69767b1d-7874-fac7-8702-392ee9544415",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a5e82b7-0e88-929b-c1a0-446d106dac07",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a6affea-c3fe-c6b1-a451-3ecefce0f88e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6b520684-5912-5e85-deef-490c23fa6080",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c3a0e1d-ef26-f659-188c-544a4a14c872",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c468a51-a49c-2a6f-fb3d-4fab378714f9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6d2e91ea-3ab0-c243-35db-5aea5ea07ceb",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "702e14b4-0b71-70b8-e704-70131c3343b9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "703a90e7-c0e7-a4ce-cab6-6a7409a68f41",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7639), new DateOnly(2025, 11, 18) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71161b4e-a185-088c-21a2-7b52434cabab",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71229881-56fb-3ca2-0453-75b330bff732",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "720a9f1b-ec0f-d476-3ef1-80f157d95f24",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "72fe23e8-3799-a060-5b3f-86906a66139d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "73f2a6b5-8223-6c4a-788e-8b307ef3c716",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6267), new DateOnly(2025, 11, 17) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76f2297e-53e4-1bbf-2bb7-a1593c858fe5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76fea5b1-085a-4ed6-0e69-9cba29f8db6c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77da3018-e9f8-b393-6555-ac98639ef7d7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6436), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77e6ad4b-9e6e-e7a9-4806-a7f95012435e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "78ceb4e5-3382-7f7d-82a4-b237772bab50",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79b6bc7f-c996-1751-bc41-bc759e451342",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79c238b2-7e0c-4b67-9ff2-b7d68ab85fc9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7daac215-e5e1-91b1-8bb9-d83e70648f8a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7db63e48-9a57-c5c7-6e6b-d39f5cd7db11",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e92c9af-7bf5-2984-c557-e37d977df77c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e9e46e2-306b-5d9a-a808-dede83f14303",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f7ad149-1109-c158-fff4-eebbbe975f6e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f864d7c-c67f-f56e-e2a6-e81caa0aabf5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "806e5516-5c93-8d42-1c43-f35ad12413e7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 231, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "836ed7e0-2d54-3cb8-ce6d-098490b6dbb6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(954), new DateOnly(2025, 11, 22) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "837a5313-e2ca-70ce-b21e-04e57c29273d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8456df79-c368-d48c-080a-14c3b7d043a8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "84625bac-78de-08a2-ebbb-0f23a3438f2f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "853ee613-597d-6c5f-42a8-1f01dee9ab9a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "854a6246-0ef2-a075-2559-1a62ca5df721",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "86326ae0-a407-3849-5ff6-25a0f1765f13",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "893e69dd-2a3d-1ad5-f5d1-352b9c7c7369",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a267077-bf51-b2a9-2f6f-4069c395db5b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a32ecaa-74c7-e6bf-1220-3bcab00827e2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b0e7710-5566-4a7d-690c-4ba8eaaf434d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9657), new DateOnly(2025, 11, 24) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b1af444-0adc-7e93-4cbd-4609d7228fd4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8c02fbdd-a0f0-1667-865b-5147fe3cf7c6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8cf67faa-eb7a-e250-a3aa-56e611c8ab3f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90ea8541-07c5-5db0-7222-72afe3e72787",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90f60174-bc3b-91c6-55d3-6c10d05b730e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91d28ddb-9dd9-f584-acbf-7dee0a018f79",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91de090e-524f-299a-8f71-774ef774db00",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92ba9474-33ed-8d58-e65d-882c311bf76b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92c610a8-e863-c16e-c90e-828d1e8e43f2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "93ad1841-7e77-5942-03ac-8dcb45a7abe4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "96ba173e-04ae-3bcd-9986-9e56f0adbf3a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97a21ed8-9ac2-d3a1-d324-a99417c6272c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97ae9a0b-4f38-07b7-b6d5-a3f5043a73b3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "98892672-30d6-6b75-0cc1-b4d33ee08f1e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9896a2a5-e54c-9f8b-f073-ae332a53dba5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "99712d0c-c5ea-0349-465f-bf1165faf710",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "997da93f-7b60-375f-2910-b972516d4397",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9c7e2c08-4b21-e5d4-dc39-cf9c10ff0b66",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d6533a2-e135-7ea8-16d7-dada37197358",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d71b0d5-96ab-b2be-f988-d53b248cbfdf",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e4d3b3c-7749-167c-5074-e5195e32db4a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e59b76f-2cbf-4a92-3326-e0794ba527d1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f3542d6-0d5d-ae50-8a12-f057854c433c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f41bf09-c2d3-e266-6dc3-ebb872bf8fc3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2602), new DateOnly(2025, 11, 19) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a335c59f-de1e-5cc5-3c3b-068144de0b0b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a41dcc39-7432-f499-76d9-11bf6bf873fc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a429486c-29a8-28af-598a-0c20576bbf83",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2104), new DateOnly(2025, 11, 22) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a505d4d3-0a46-8c6d-b076-1cfe9211dbee",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a5115006-bfbc-c083-9328-165e7e852775",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6eddb6d-a05a-2441-ea14-273cb92b43e0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6f957a0-55d0-5857-cdc5-219da59e8f67",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a9f9da6a-2691-07cd-80ef-37c764305736",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aae1e103-bca5-9fa1-ba8c-42058b4abf28",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aaed5e37-711b-d3b7-9d3d-3d6677bd0baf",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abc9e99d-51b9-3774-f42a-4d43b264271a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abd565d0-072f-6b8a-d7db-48a49ed773a1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acb1f037-e7cd-cf48-2dc7-5882d97d8f0c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acbd6d6a-9c43-035e-1178-53e3c5f0db93",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "afbdef34-6d04-b1d4-c3a2-690c8483a262",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b0b17301-b88e-7dbe-e0f1-6eac970f56db",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1997a9b-4ea2-1592-1a8e-79eabe29becd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1a5f7ce-0318-49a8-fd3f-744bab9c0a54",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b2818234-e4b7-ad65-542c-8429e54326bf",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b28dfe67-992c-e17c-37dd-7f89d2b67246",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b3750601-2f41-794f-717a-8ac8f9cfda38",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b67588cb-0001-28c5-24a4-a0f1b762a207",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b75d9065-9616-c099-5d41-ab30de7b0af9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5606), new DateOnly(2025, 11, 17) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b7690c98-4b8c-f4af-40f3-a591cbee5680",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b84597ff-2c2a-586d-97df-b66e059572eb",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b8511332-e1a0-8c83-7a90-b0cff208be72",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b92d9e98-c23e-f040-d17c-c1ad2caedadd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b9391bcb-77b4-2457-b42e-bb0e19222664",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc399d95-4875-d2cc-6757-d137d7b4ee33",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bd2d2162-92ff-9eb6-84a6-d7d7eb41a2ac",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be1528fc-2813-368a-be43-e215125a0a9e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be21a52f-dd89-6aa0-a1f4-dc76fecd5625",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bf09acc9-739d-0274-db92-e7b425e7be17",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bffd3096-be27-ce5e-f8e1-ed5339747290",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3652), new DateOnly(2025, 11, 19) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c0f1b463-09b1-9a48-152f-f2f34c012609",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3f1362c-da72-49bd-c759-081c0b93eed8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3fdb25f-8fe8-7cd3-aa0a-037df7063a5f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4d93ec6-7086-e191-01f6-135b32ad56ca",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4e5baf9-25fc-15a7-e4a8-0ebc1e20a251",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5c14560-069a-7965-3b94-1e9959c6bebc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5cdc193-bb10-ad7b-1e45-19fa45390a43",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c6b5c92d-5124-454f-58e3-23396c537235",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9b54bf7-22e5-f3c4-0b0c-3a622be53a04",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "caa9cfc3-6d6f-bfae-285b-3f013f72ee7d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb91d75d-0383-5782-61f8-4a40658c566f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(8429), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb9d5390-b8f9-8b98-45aa-44a152ffa2f6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc79def7-9997-ef56-9b96-557e8ca5be61",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc855a2a-4e0d-236c-7e47-4fdf79180ae8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cd6d62c4-e321-bb40-b8e5-5a1ea03272da",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d06de48e-b4e2-6ab5-6b0e-70475fc43aa9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d07961c1-6958-9ecc-4ebf-6ba84b378630",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8041), new DateOnly(2025, 11, 24) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d155ec27-4af6-0289-a5ac-7b8686dea29b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d161685b-ff6c-369f-885d-76e77251ee22",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d23df3c1-e00a-9a5d-df49-86c4adf70a8d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d2496ff4-9580-ce73-c2fa-8125996b5614",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d330778e-2b94-6647-fc98-8c63c084be06",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6621), new DateOnly(2025, 11, 23) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d631f958-fc55-14bd-aec1-a28d7f1686d4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d63d768b-b1cb-48d3-9173-9cee6b8ad25c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d7257d25-47df-e0a7-cb10-a72c92a33a4d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d80c85bf-ddf3-787a-05ae-b26bb9bda23f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d81901f2-9269-ac91-e85f-adcca630eec6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d900088b-287d-4464-22fc-b80acd4a56b8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d9f48c58-7308-104e-3f4b-bda9e0d60a31",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dde892ef-8f52-8bae-0fc3-d972b2f58679",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ddf50f22-44c8-bfc4-f275-d3d39f69d200",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ded09a89-2467-2382-4961-e4b1d90fee6b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dedc16bc-dadc-5798-2c12-de11c6823af2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfb8a123-ba7b-bb55-83fe-efef0029565d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfc41e56-6ff1-ef6c-66b0-e950ed9ca2e4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e0ac25ef-0505-873f-9f4d-f48e14b60ad6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3aca8b9-d6c6-35b5-5276-0ab8d248d2a5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1336), new DateOnly(2025, 11, 19) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3b824ec-8b3b-69cb-3528-0519bfbb1e2c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e494af53-6cda-cd89-8c14-15f7f9613a97",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e4a02b86-2150-019f-6fc5-1057e6d5861e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e5883320-b764-9973-a963-1b960deeee10",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e6703aba-4d78-3147-e300-25d434085602",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e67cb6ed-02ee-655d-c6b1-2035207ba289",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e97c39b6-d3af-13d2-79db-365fdf0d6a58",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea644050-69c3-aca6-b278-419d0627d24a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea70bd83-1e39-e0bc-962a-3cfef29a1ed1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb4c48ea-ffd7-447a-ec16-4cdc2d403a3c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(18), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb58c41d-b44d-7890-cfc7-473c19b486c3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec344f84-95eb-dc4e-26b3-571a545aa22e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec40ccb7-4a61-1064-0965-517b40cdeeb5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f028561a-b036-56ad-f62c-72e326791d76",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f034d24e-65ac-8ac3-d9dd-6d4412ec69fd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f1105db4-464a-ee81-30c9-7d214d938568",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f11cd9e7-fbc0-2297-137a-78823906d1ef",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f204e181-91d4-ba6b-4d18-83c1601f39e1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3ece81b-27e8-523f-87b5-8eff8739a1d3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3f8654e-dc5e-8655-6a67-886074aced5a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f6f8e718-ad1f-35ca-1c90-9e8a323eb529",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7e0efb2-4333-cd9e-562e-a9c859581d1b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7ec6be5-f8a9-01b4-39df-a42946cb69a2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8c8f64b-d947-6572-90cb-b4078072850d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8d4727e-8ebd-9988-737c-af676de5d194",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 252, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9b0fee5-6f5b-fd46-ca69-bf45a78bedff",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9bc7a18-24d1-315c-ad1a-baa694fe3986",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fcbcfce2-f592-dfd2-6043-d0d053910155",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 234, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fda4047c-8ba6-77a5-9ae1-db0e7aaa6947",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fdb080af-401c-abbc-7d92-d56f661db5ce",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe8c0b16-21ba-0f79-d37e-e64ca0c4d139",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe988849-d630-438f-b730-e0ad8d371dc0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 19, 44, 31, 235, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ff808fe2-6c44-db63-f0cd-ebecb45185b2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 19, 44, 31, 253, DateTimeKind.Utc).AddTicks(2954), new DateOnly(2025, 11, 25) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BillingAddress",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OrgNumber",
                table: "Customers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO8vfdEWwoQS58+XX3AmUZjwqsF4h0d+lTR6lkQKgcp/c7Kdq0HyymnB4W8kXPqTaw==");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -2001551291,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1844884905,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1601722507,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1445121657,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1288389735,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1045358408,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -888626487,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -731960101,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 772, DateTimeKind.Utc).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -488863238,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -332196852,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 67631932,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 224298318,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 624061566,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 780793488,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1180556736,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1337157586,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1580319985,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1736986371,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1893652757,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2136749619,
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 774, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "007413af-b7ce-a74d-0d1c-f18bc7de392b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "03749579-878f-56c3-c045-07b5867001fa",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "038011ac-3c05-89d9-a3f7-011573e34d81",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "045c9d13-1da3-ee97-fae3-12f3ad8969ec",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "04681946-d219-22ad-dd94-0c549afdb573",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0544a4ad-b3b7-866a-3480-1d32d4a3d1de",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "055020e0-682d-ba81-1732-1792c1161d65",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0638287a-fe42-5254-51cf-22d1e8308557",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0938aa43-cf02-00ca-03f8-38faa6c24d26",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a20b2dd-6516-989e-3d96-4339cddcb517",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a2c2e10-1a8c-ccb4-2047-3e9aba4f019e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b08b977-fb2b-3072-7733-4e77f4f51d09",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b1436aa-b0a1-6488-5ae5-49d8e1686990",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0cfc3d44-46b5-fc5c-9482-54170882d182",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0df0c111-913f-c845-b1d1-59b61b0f85fb",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10f043da-6200-77bb-64fa-6fe0daa14dca",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10fcc00e-1776-abd1-47ac-6a40c6149951",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6986), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11d84b74-f814-0f8f-9e98-7a1e01bbb5bc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11e4c7a7-ad8a-43a5-8149-757fed2e0143",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12c0520e-8d28-a763-d835-855c28d41dae",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12cccf41-429e-db79-bbe7-7fbd14476935",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "13b3d6db-d8b2-734d-f484-8afc3b61d127",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9340), new DateOnly(2025, 11, 19) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16b459a5-a973-21c2-a7ae-a025faf399f6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16c0d5d8-5ee9-55d8-8a5f-9b86e666e57d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "179c603e-3f87-b996-e14b-ab64210d01e8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5635), new DateOnly(2025, 11, 22) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "17a8dc72-f4fd-edac-c4fc-a6c50d804d6f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188367d8-d59b-516a-1be9-b6a2482669da",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188fe40b-8a11-8580-fe9a-b103349ab561",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1977eba5-2025-1d54-3837-bc425bb31d53",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d6bf13c-3c70-98b3-07b0-d70a2dd2999b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d786e6f-f1e6-ccc9-eb61-d26b1a45e522",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e53f9d6-d284-3087-414d-e24954ec018d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e5f7509-87fa-649d-24fe-ddaa415f4d14",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f3b006f-6898-c85b-7beb-ed877b06697f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f477da2-1d0e-fc71-5e9c-e8e86879b506",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "202f843c-b322-9445-9839-f3278f921df8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "232f0706-83e3-42ba-4b63-09504d25e5c7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "233b8339-3959-76d1-2e14-03b13a98314e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24170ea0-19f7-da8e-8500-148f743e4db9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24238ad3-ce6d-0ea4-68b2-0ef061b19940",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "250b926d-6481-a678-a24f-192e88cb0132",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "25ff163a-af0b-7262-bf9e-1fcd9b58b5ab",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "26f39906-fa95-3e4c-dced-246cafe56924",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "29ff9803-80cc-20d8-71c7-35f75aea7d7a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2ae7a09d-16e0-b9ac-ab65-40358104e56c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2af31cd0-cb56-edc2-8e16-3a966d7731f3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bcfa737-acf4-517f-e502-4b74a81d4d5e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2759), new DateOnly(2025, 11, 17) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bdb236a-616a-8595-c8b4-45d5949099e5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cb7aed1-4208-e953-1fa0-56b2cf37b550",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cc32b04-f77e-1d69-0251-5013bbaa01d7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30abb567-5e53-63b3-ef18-717ba1563098",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30b7319a-13c9-97c9-d2c9-6cdc8ec97c1f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8206), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3193bc01-f467-fb87-29b5-7cbac86f988a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "319f3834-a9dd-2f9d-0c67-771ab5e3e411",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "327bc49b-8a7c-935a-6253-87f8ef89007c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "328740ce-3ff2-c770-4504-8259dbfc4c03",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "336f4768-d406-5f44-7fa2-8c970216b4f5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(402), new DateOnly(2025, 11, 19) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "366fca31-a5c6-0eba-32cb-a3c1c1a87cc4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "367b4665-5a3c-42d0-157c-9d22ae1bc84b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "37634efe-f051-daa4-4f1a-a860d535303d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "384b5598-8665-7278-89b7-b39ffc4e982f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3857d1cb-3bdb-a68e-6c69-ad00e8c2e4b6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "39335d32-1c79-0a4c-c355-bedd23680021",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "393fd965-d1ef-3e62-a606-b83e0fdb4ca8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3c3f5b2f-a2b0-ecd7-5830-ce68ce6d1477",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d2763c9-38c4-84ab-92cd-d9a6f5877c68",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d33dffc-ed3a-b8c1-757e-d407e1fac8ef",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e0f6a62-ced8-1c7f-cc6b-e4e51ca1e45a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e1be795-834e-5095-af1c-df45081430e1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3f03ee2f-1962-e869-e9b9-ea842f2e98d3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5715), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3ff772fc-64ec-b453-0608-ef2343ba4c4c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43eb7893-8037-2fb2-d680-0bec15d9c894",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1483), new DateOnly(2025, 11, 24) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43f7f4c6-35ad-63c8-b932-054d014d141b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "44dffc60-cbc1-fb9c-f3cf-108b28667c0d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45c703f9-60d5-9370-2d6d-1bca4f80e4ff",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45d37f2d-154b-c786-101e-162a3cf33086",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46af0b93-f6e9-2b44-660a-260876994cf1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46bb87c6-ab5f-5f5a-4abb-2169630d9878",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "49bb0990-7c20-0dcf-fce5-3793219f6047",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aa3112a-1234-a5a3-3682-42d148b8c839",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aaf8d5d-c7aa-d9b9-1934-3c32352c14c0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b8b18c4-a848-3d77-7020-4d106fd2302b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b9795f7-5dbe-718d-53d1-47705c457cb2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c73205d-3e5c-d54b-aabd-584e96ec981d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c7f9c91-f3d2-0961-8d6f-52af835fe4a4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4f7f1f5a-c493-b7d7-4098-68d841f1ac73",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "506726f4-5aa7-50aa-7935-7317680b1465",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5073a227-0f1d-84c1-5de7-6e78557e60ec",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "515baac1-a531-1c94-9684-79b67c97c8de",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5243b15b-3b45-b468-d022-84f5a3b130d0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "524f2e8e-f0bb-e87e-b3d3-7e558f247c57",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "53363528-86cf-8052-ed70-8994b63ee449",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5637b8f1-5790-2ec8-a09a-9fbe75d0ac18",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "571fbf8b-eca4-c69c-da37-aafc9cea140a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4841), new DateOnly(2025, 11, 19) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "572b3bbe-a11a-fab2-bde9-a55d885d6091",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5806c725-82b8-5e6f-14d5-b53ac3037cfc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "58124358-372e-9285-f786-b09baf76c883",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59eecebf-18cd-f643-4e72-c079ea1de4ee",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59fa4af2-cd42-2a59-3124-badad6903075",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5cfbcdbc-9e03-d9cf-e34d-d1039522f844",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5de2d455-3417-71a3-1deb-db42bc3c6036",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5dee5088-e98d-a5b9-009c-d6a3a8afacbd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5ed65822-7fa1-3d8d-3a39-e1e1cfc914af",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fbe5fbc-15b6-d560-74d7-ec20f6e27ca1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6777), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fcadcef-ca2c-0977-5788-e680e356c828",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "60b2e389-6040-a14a-9126-f1bf0a6f301a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63b26653-3101-4fc0-444f-07e8c901f8e9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63bee286-e676-83d6-2700-0249b5744470",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "649a6ded-c715-e794-7eed-1227f01b60db",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "64a6e920-7c8b-1baa-619e-0d88dc8eac62",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "65827586-5d29-7f68-b78a-1d651635c8cd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "658ef1b9-129f-b37e-9a3b-18c603a81454",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6676f853-a8b3-4b52-d4d9-23052ac17c46",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "69767b1d-7874-fac7-8702-392ee9544415",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a5e82b7-0e88-929b-c1a0-446d106dac07",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a6affea-c3fe-c6b1-a451-3ecefce0f88e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6b520684-5912-5e85-deef-490c23fa6080",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c3a0e1d-ef26-f659-188c-544a4a14c872",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c468a51-a49c-2a6f-fb3d-4fab378714f9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6d2e91ea-3ab0-c243-35db-5aea5ea07ceb",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "702e14b4-0b71-70b8-e704-70131c3343b9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "703a90e7-c0e7-a4ce-cab6-6a7409a68f41",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7387), new DateOnly(2025, 11, 17) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71161b4e-a185-088c-21a2-7b52434cabab",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71229881-56fb-3ca2-0453-75b330bff732",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "720a9f1b-ec0f-d476-3ef1-80f157d95f24",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "72fe23e8-3799-a060-5b3f-86906a66139d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "73f2a6b5-8223-6c4a-788e-8b307ef3c716",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9691), new DateOnly(2025, 11, 16) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76f2297e-53e4-1bbf-2bb7-a1593c858fe5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76fea5b1-085a-4ed6-0e69-9cba29f8db6c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77da3018-e9f8-b393-6555-ac98639ef7d7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6034), new DateOnly(2025, 11, 19) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77e6ad4b-9e6e-e7a9-4806-a7f95012435e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "78ceb4e5-3382-7f7d-82a4-b237772bab50",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79b6bc7f-c996-1751-bc41-bc759e451342",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79c238b2-7e0c-4b67-9ff2-b7d68ab85fc9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7daac215-e5e1-91b1-8bb9-d83e70648f8a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7db63e48-9a57-c5c7-6e6b-d39f5cd7db11",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e92c9af-7bf5-2984-c557-e37d977df77c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e9e46e2-306b-5d9a-a808-dede83f14303",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f7ad149-1109-c158-fff4-eebbbe975f6e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f864d7c-c67f-f56e-e2a6-e81caa0aabf5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "806e5516-5c93-8d42-1c43-f35ad12413e7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 779, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "836ed7e0-2d54-3cb8-ce6d-098490b6dbb6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(682), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "837a5313-e2ca-70ce-b21e-04e57c29273d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8456df79-c368-d48c-080a-14c3b7d043a8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "84625bac-78de-08a2-ebbb-0f23a3438f2f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "853ee613-597d-6c5f-42a8-1f01dee9ab9a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "854a6246-0ef2-a075-2559-1a62ca5df721",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "86326ae0-a407-3849-5ff6-25a0f1765f13",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "893e69dd-2a3d-1ad5-f5d1-352b9c7c7369",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a267077-bf51-b2a9-2f6f-4069c395db5b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a32ecaa-74c7-e6bf-1220-3bcab00827e2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b0e7710-5566-4a7d-690c-4ba8eaaf434d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3126), new DateOnly(2025, 11, 23) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b1af444-0adc-7e93-4cbd-4609d7228fd4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8c02fbdd-a0f0-1667-865b-5147fe3cf7c6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8cf67faa-eb7a-e250-a3aa-56e611c8ab3f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90ea8541-07c5-5db0-7222-72afe3e72787",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90f60174-bc3b-91c6-55d3-6c10d05b730e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91d28ddb-9dd9-f584-acbf-7dee0a018f79",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91de090e-524f-299a-8f71-774ef774db00",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92ba9474-33ed-8d58-e65d-882c311bf76b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92c610a8-e863-c16e-c90e-828d1e8e43f2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "93ad1841-7e77-5942-03ac-8dcb45a7abe4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "96ba173e-04ae-3bcd-9986-9e56f0adbf3a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97a21ed8-9ac2-d3a1-d324-a99417c6272c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97ae9a0b-4f38-07b7-b6d5-a3f5043a73b3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "98892672-30d6-6b75-0cc1-b4d33ee08f1e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9896a2a5-e54c-9f8b-f073-ae332a53dba5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "99712d0c-c5ea-0349-465f-bf1165faf710",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "997da93f-7b60-375f-2910-b972516d4397",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9c7e2c08-4b21-e5d4-dc39-cf9c10ff0b66",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d6533a2-e135-7ea8-16d7-dada37197358",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d71b0d5-96ab-b2be-f988-d53b248cbfdf",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e4d3b3c-7749-167c-5074-e5195e32db4a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e59b76f-2cbf-4a92-3326-e0794ba527d1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f3542d6-0d5d-ae50-8a12-f057854c433c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f41bf09-c2d3-e266-6dc3-ebb872bf8fc3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6067), new DateOnly(2025, 11, 18) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a335c59f-de1e-5cc5-3c3b-068144de0b0b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a41dcc39-7432-f499-76d9-11bf6bf873fc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a429486c-29a8-28af-598a-0c20576bbf83",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1871), new DateOnly(2025, 11, 21) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a505d4d3-0a46-8c6d-b076-1cfe9211dbee",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a5115006-bfbc-c083-9328-165e7e852775",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6eddb6d-a05a-2441-ea14-273cb92b43e0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6f957a0-55d0-5857-cdc5-219da59e8f67",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a9f9da6a-2691-07cd-80ef-37c764305736",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aae1e103-bca5-9fa1-ba8c-42058b4abf28",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aaed5e37-711b-d3b7-9d3d-3d6677bd0baf",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abc9e99d-51b9-3774-f42a-4d43b264271a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abd565d0-072f-6b8a-d7db-48a49ed773a1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acb1f037-e7cd-cf48-2dc7-5882d97d8f0c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acbd6d6a-9c43-035e-1178-53e3c5f0db93",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "afbdef34-6d04-b1d4-c3a2-690c8483a262",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b0b17301-b88e-7dbe-e0f1-6eac970f56db",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1997a9b-4ea2-1592-1a8e-79eabe29becd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1a5f7ce-0318-49a8-fd3f-744bab9c0a54",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b2818234-e4b7-ad65-542c-8429e54326bf",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b28dfe67-992c-e17c-37dd-7f89d2b67246",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b3750601-2f41-794f-717a-8ac8f9cfda38",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b67588cb-0001-28c5-24a4-a0f1b762a207",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b75d9065-9616-c099-5d41-ab30de7b0af9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5209), new DateOnly(2025, 11, 16) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b7690c98-4b8c-f4af-40f3-a591cbee5680",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b84597ff-2c2a-586d-97df-b66e059572eb",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b8511332-e1a0-8c83-7a90-b0cff208be72",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b92d9e98-c23e-f040-d17c-c1ad2caedadd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b9391bcb-77b4-2457-b42e-bb0e19222664",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc399d95-4875-d2cc-6757-d137d7b4ee33",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bd2d2162-92ff-9eb6-84a6-d7d7eb41a2ac",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be1528fc-2813-368a-be43-e215125a0a9e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be21a52f-dd89-6aa0-a1f4-dc76fecd5625",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bf09acc9-739d-0274-db92-e7b425e7be17",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bffd3096-be27-ce5e-f8e1-ed5339747290",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7133), new DateOnly(2025, 11, 18) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c0f1b463-09b1-9a48-152f-f2f34c012609",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3f1362c-da72-49bd-c759-081c0b93eed8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3fdb25f-8fe8-7cd3-aa0a-037df7063a5f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4d93ec6-7086-e191-01f6-135b32ad56ca",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4e5baf9-25fc-15a7-e4a8-0ebc1e20a251",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5c14560-069a-7965-3b94-1e9959c6bebc",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5cdc193-bb10-ad7b-1e45-19fa45390a43",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c6b5c92d-5124-454f-58e3-23396c537235",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9b54bf7-22e5-f3c4-0b0c-3a622be53a04",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "caa9cfc3-6d6f-bfae-285b-3f013f72ee7d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb91d75d-0383-5782-61f8-4a40658c566f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2349), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb9d5390-b8f9-8b98-45aa-44a152ffa2f6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc79def7-9997-ef56-9b96-557e8ca5be61",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc855a2a-4e0d-236c-7e47-4fdf79180ae8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cd6d62c4-e321-bb40-b8e5-5a1ea03272da",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d06de48e-b4e2-6ab5-6b0e-70475fc43aa9",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d07961c1-6958-9ecc-4ebf-6ba84b378630",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7772), new DateOnly(2025, 11, 23) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d155ec27-4af6-0289-a5ac-7b8686dea29b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d161685b-ff6c-369f-885d-76e77251ee22",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d23df3c1-e00a-9a5d-df49-86c4adf70a8d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d2496ff4-9580-ce73-c2fa-8125996b5614",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d330778e-2b94-6647-fc98-8c63c084be06",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(50), new DateOnly(2025, 11, 22) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d631f958-fc55-14bd-aec1-a28d7f1686d4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d63d768b-b1cb-48d3-9173-9cee6b8ad25c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d7257d25-47df-e0a7-cb10-a72c92a33a4d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d80c85bf-ddf3-787a-05ae-b26bb9bda23f",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d81901f2-9269-ac91-e85f-adcca630eec6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d900088b-287d-4464-22fc-b80acd4a56b8",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d9f48c58-7308-104e-3f4b-bda9e0d60a31",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dde892ef-8f52-8bae-0fc3-d972b2f58679",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ddf50f22-44c8-bfc4-f275-d3d39f69d200",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ded09a89-2467-2382-4961-e4b1d90fee6b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dedc16bc-dadc-5798-2c12-de11c6823af2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfb8a123-ba7b-bb55-83fe-efef0029565d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfc41e56-6ff1-ef6c-66b0-e950ed9ca2e4",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e0ac25ef-0505-873f-9f4d-f48e14b60ad6",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3aca8b9-d6c6-35b5-5276-0ab8d248d2a5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1063), new DateOnly(2025, 11, 18) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3b824ec-8b3b-69cb-3528-0519bfbb1e2c",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e494af53-6cda-cd89-8c14-15f7f9613a97",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e4a02b86-2150-019f-6fc5-1057e6d5861e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e5883320-b764-9973-a963-1b960deeee10",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e6703aba-4d78-3147-e300-25d434085602",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e67cb6ed-02ee-655d-c6b1-2035207ba289",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e97c39b6-d3af-13d2-79db-365fdf0d6a58",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea644050-69c3-aca6-b278-419d0627d24a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea70bd83-1e39-e0bc-962a-3cfef29a1ed1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb4c48ea-ffd7-447a-ec16-4cdc2d403a3c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3491), new DateOnly(2025, 11, 20) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb58c41d-b44d-7890-cfc7-473c19b486c3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec344f84-95eb-dc4e-26b3-571a545aa22e",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec40ccb7-4a61-1064-0965-517b40cdeeb5",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f028561a-b036-56ad-f62c-72e326791d76",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f034d24e-65ac-8ac3-d9dd-6d4412ec69fd",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f1105db4-464a-ee81-30c9-7d214d938568",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f11cd9e7-fbc0-2297-137a-78823906d1ef",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f204e181-91d4-ba6b-4d18-83c1601f39e1",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3ece81b-27e8-523f-87b5-8eff8739a1d3",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3f8654e-dc5e-8655-6a67-886074aced5a",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f6f8e718-ad1f-35ca-1c90-9e8a323eb529",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7e0efb2-4333-cd9e-562e-a9c859581d1b",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7ec6be5-f8a9-01b4-39df-a42946cb69a2",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8c8f64b-d947-6572-90cb-b4078072850d",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8d4727e-8ebd-9988-737c-af676de5d194",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9b0fee5-6f5b-fd46-ca69-bf45a78bedff",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 794, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9bc7a18-24d1-315c-ad1a-baa694fe3986",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fcbcfce2-f592-dfd2-6043-d0d053910155",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 782, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fda4047c-8ba6-77a5-9ae1-db0e7aaa6947",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fdb080af-401c-abbc-7d92-d56f661db5ce",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe8c0b16-21ba-0f79-d37e-e64ca0c4d139",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe988849-d630-438f-b730-e0ad8d371dc0",
                column: "CreatedAt",
                value: new DateTime(2025, 11, 18, 17, 43, 14, 783, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ff808fe2-6c44-db63-f0cd-ebecb45185b2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 11, 18, 17, 43, 14, 793, DateTimeKind.Utc).AddTicks(6423), new DateOnly(2025, 11, 24) });
        }
    }
}
