using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntreprenadPro.Data.Migrations
{
    /// <inheritdoc />
    public partial class MorePropertiesForCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgNumber",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2018, 9, 1), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2017, 3, 19), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2025, 10, 14), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2020, 8, 12), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2015, 12, 3), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2023, 8, 31), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2022, 11, 21), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2020, 11, 28), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2024, 6, 12), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2017, 9, 20), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2021, 12, 31), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2024, 11, 8), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2017, 7, 25), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2020, 4, 5), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2016, 8, 5), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2018, 10, 16), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2022, 5, 12), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2025, 4, 1), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2019, 7, 23), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2023, 11, 21), "AQAAAAIAAYagAAAAEAzQHXE1vWRrb1uM+/USVF+OODhnd4sJfIegJtIeIB/mhFckMTs56C4BPSnocuau6w==" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                columns: new[] { "Email", "OrgNumber", "PhoneNumber", "Type" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 856, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 30, 18, 42, 35, 857, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "007413af-b7ce-a74d-0d1c-f18bc7de392b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5354), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "03749579-878f-56c3-c045-07b5867001fa",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8639), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "038011ac-3c05-89d9-a3f7-011573e34d81",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5512), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "045c9d13-1da3-ee97-fae3-12f3ad8969ec",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5042), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "04681946-d219-22ad-dd94-0c549afdb573",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1934), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0544a4ad-b3b7-866a-3480-1d32d4a3d1de",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1330), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "055020e0-682d-ba81-1732-1792c1161d65",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8214), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0638287a-fe42-5254-51cf-22d1e8308557",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4397), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0938aa43-cf02-00ca-03f8-38faa6c24d26",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7676), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4499), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a20b2dd-6516-989e-3d96-4339cddcb517",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4089), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a2c2e10-1a8c-ccb4-2047-3e9aba4f019e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(751), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b08b977-fb2b-3072-7733-4e77f4f51d09",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(233), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b1436aa-b0a1-6488-5ae5-49d8e1686990",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7140), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0cfc3d44-46b5-fc5c-9482-54170882d182",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3377), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0df0c111-913f-c845-b1d1-59b61b0f85fb",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6403), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10f043da-6200-77bb-64fa-6fe0daa14dca",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9768), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10fcc00e-1776-abd1-47ac-6a40c6149951",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6686), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11d84b74-f814-0f8f-9e98-7a1e01bbb5bc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6134), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11e4c7a7-ad8a-43a5-8149-757fed2e0143",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3157), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12c0520e-8d28-a763-d835-855c28d41dae",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2369), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12cccf41-429e-db79-bbe7-7fbd14476935",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9265), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "13b3d6db-d8b2-734d-f484-8afc3b61d127",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5419), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16b459a5-a973-21c2-a7ae-a025faf399f6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8705), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16c0d5d8-5ee9-55d8-8a5f-9b86e666e57d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5581), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "179c603e-3f87-b996-e14b-ab64210d01e8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5183), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "17a8dc72-f4fd-edac-c4fc-a6c50d804d6f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2002), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188367d8-d59b-516a-1be9-b6a2482669da",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1395), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188fe40b-8a11-8580-fe9a-b103349ab561",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8280), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1977eba5-2025-1d54-3837-bc425bb31d53",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4461), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4570), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d6bf13c-3c70-98b3-07b0-d70a2dd2999b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(818), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d786e6f-f1e6-ccc9-eb61-d26b1a45e522",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7741), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e53f9d6-d284-3087-414d-e24954ec018d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7205), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e5f7509-87fa-649d-24fe-ddaa415f4d14",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4193), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f3b006f-6898-c85b-7beb-ed877b06697f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3442), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f477da2-1d0e-fc71-5e9c-e8e86879b506",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(298), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "202f843c-b322-9445-9839-f3278f921df8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6468), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "232f0706-83e3-42ba-4b63-09504d25e5c7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9834), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "233b8339-3959-76d1-2e14-03b13a98314e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6752), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24170ea0-19f7-da8e-8500-148f743e4db9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6238), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24238ad3-ce6d-0ea4-68b2-0ef061b19940",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3224), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "250b926d-6481-a678-a24f-192e88cb0132",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9329), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "25ff163a-af0b-7262-bf9e-1fcd9b58b5ab",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2435), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "26f39906-fa95-3e4c-dced-246cafe56924",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5485), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "29ff9803-80cc-20d8-71c7-35f75aea7d7a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5646), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2ae7a09d-16e0-b9ac-ab65-40358104e56c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2068), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2af31cd0-cb56-edc2-8e16-3a966d7731f3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8770), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bcfa737-acf4-517f-e502-4b74a81d4d5e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8399), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bdb236a-616a-8595-c8b4-45d5949099e5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5251), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cb7aed1-4208-e953-1fa0-56b2cf37b550",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4525), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cc32b04-f77e-1d69-0251-5013bbaa01d7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1460), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4640), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30abb567-5e53-63b3-ef18-717ba1563098",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(884), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30b7319a-13c9-97c9-d2c9-6cdc8ec97c1f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7805), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3193bc01-f467-fb87-29b5-7cbac86f988a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7308), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "319f3834-a9dd-2f9d-0c67-771ab5e3e411",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4259), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "327bc49b-8a7c-935a-6253-87f8ef89007c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3507), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "328740ce-3ff2-c770-4504-8259dbfc4c03",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(384), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "336f4768-d406-5f44-7fa2-8c970216b4f5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6534), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "366fca31-a5c6-0eba-32cb-a3c1c1a87cc4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9900), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "367b4665-5a3c-42d0-157c-9d22ae1bc84b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6818), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "37634efe-f051-daa4-4f1a-a860d535303d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3289), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "384b5598-8665-7278-89b7-b39ffc4e982f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9433), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3857d1cb-3bdb-a68e-6c69-ad00e8c2e4b6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6304), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "39335d32-1c79-0a4c-c355-bedd23680021",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5549), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "393fd965-d1ef-3e62-a606-b83e0fdb4ca8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2500), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3c3f5b2f-a2b0-ecd7-5830-ce68ce6d1477",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5799), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d2763c9-38c4-84ab-92cd-d9a6f5877c68",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2261), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d33dffc-ed3a-b8c1-757e-d407e1fac8ef",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8837), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e0f6a62-ced8-1c7f-cc6b-e4e51ca1e45a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8466), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e1be795-834e-5095-af1c-df45081430e1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5317), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3f03ee2f-1962-e869-e9b9-ea842f2e98d3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1568), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3ff772fc-64ec-b453-0608-ef2343ba4c4c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4590), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4751), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43eb7893-8037-2fb2-d680-0bec15d9c894",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(950), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43f7f4c6-35ad-63c8-b932-054d014d141b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7869), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "44dffc60-cbc1-fb9c-f3cf-108b28667c0d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4324), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45c703f9-60d5-9370-2d6d-1bca4f80e4ff",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(452), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45d37f2d-154b-c786-101e-162a3cf33086",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7374), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46af0b93-f6e9-2b44-660a-260876994cf1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6598), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46bb87c6-ab5f-5f5a-4abb-2169630d9878",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3651), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "49bb0990-7c20-0dcf-fce5-3793219f6047",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6943), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aa3112a-1234-a5a3-3682-42d148b8c839",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3354), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aaf8d5d-c7aa-d9b9-1934-3c32352c14c0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9966), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b8b18c4-a848-3d77-7020-4d106fd2302b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9499), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b9795f7-5dbe-718d-53d1-47705c457cb2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6370), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c73205d-3e5c-d54b-aabd-584e96ec981d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5649), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c7f9c91-f3d2-0961-8d6f-52af835fe4a4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2647), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4f7f1f5a-c493-b7d7-4098-68d841f1ac73",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5866), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "506726f4-5aa7-50aa-7935-7317680b1465",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2328), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5073a227-0f1d-84c1-5de7-6e78557e60ec",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8924), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "515baac1-a531-1c94-9684-79b67c97c8de",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5383), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5243b15b-3b45-b468-d022-84f5a3b130d0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1634), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "524f2e8e-f0bb-e87e-b3d3-7e558f247c57",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8533), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "53363528-86cf-8052-ed70-8994b63ee449",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4693), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5637b8f1-5790-2ec8-a09a-9fbe75d0ac18",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7974), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4820), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "571fbf8b-eca4-c69c-da37-aafc9cea140a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4390), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "572b3bbe-a11a-fab2-bde9-a55d885d6091",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1016), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5806c725-82b8-5e6f-14d5-b53ac3037cfc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(517), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "58124358-372e-9285-f786-b09baf76c883",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7440), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59eecebf-18cd-f643-4e72-c079ea1de4ee",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6717), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59fa4af2-cd42-2a59-3124-badad6903075",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3717), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5cfbcdbc-9e03-d9cf-e34d-d1039522f844",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7009), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5de2d455-3417-71a3-1deb-db42bc3c6036",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3419), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5dee5088-e98d-a5b9-009c-d6a3a8afacbd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(71), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5ed65822-7fa1-3d8d-3a39-e1e1cfc914af",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6435), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fbe5fbc-15b6-d560-74d7-ec20f6e27ca1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2714), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fcadcef-ca2c-0977-5788-e680e356c828",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9565), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "60b2e389-6040-a14a-9126-f1bf0a6f301a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5715), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63b26653-3101-4fc0-444f-07e8c901f8e9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8991), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63bee286-e676-83d6-2700-0249b5744470",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5933), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "649a6ded-c715-e794-7eed-1227f01b60db",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5448), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "64a6e920-7c8b-1baa-619e-0d88dc8eac62",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2472), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "65827586-5d29-7f68-b78a-1d651635c8cd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1698), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "658ef1b9-129f-b37e-9a3b-18c603a81454",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8599), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6676f853-a8b3-4b52-d4d9-23052ac17c46",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4759), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "69767b1d-7874-fac7-8702-392ee9544415",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8040), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4891), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a5e82b7-0e88-929b-c1a0-446d106dac07",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4491), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a6affea-c3fe-c6b1-a451-3ecefce0f88e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1237), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6b520684-5912-5e85-deef-490c23fa6080",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7506), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c3a0e1d-ef26-f659-188c-544a4a14c872",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3783), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c468a51-a49c-2a6f-fb3d-4fab378714f9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(582), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6d2e91ea-3ab0-c243-35db-5aea5ea07ceb",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6782), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "702e14b4-0b71-70b8-e704-70131c3343b9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(137), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "703a90e7-c0e7-a4ce-cab6-6a7409a68f41",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7075), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71161b4e-a185-088c-21a2-7b52434cabab",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6537), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71229881-56fb-3ca2-0453-75b330bff732",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3525), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "720a9f1b-ec0f-d476-3ef1-80f157d95f24",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9631), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "72fe23e8-3799-a060-5b3f-86906a66139d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2783), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "73f2a6b5-8223-6c4a-788e-8b307ef3c716",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5780), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76f2297e-53e4-1bbf-2bb7-a1593c858fe5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9055), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76fea5b1-085a-4ed6-0e69-9cba29f8db6c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6001), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77da3018-e9f8-b393-6555-ac98639ef7d7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5568), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77e6ad4b-9e6e-e7a9-4806-a7f95012435e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2538), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "78ceb4e5-3382-7f7d-82a4-b237772bab50",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8664), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79b6bc7f-c996-1751-bc41-bc759e451342",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4825), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79c238b2-7e0c-4b67-9ff2-b7d68ab85fc9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1762), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4959), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7daac215-e5e1-91b1-8bb9-d83e70648f8a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1323), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7db63e48-9a57-c5c7-6e6b-d39f5cd7db11",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8105), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e92c9af-7bf5-2984-c557-e37d977df77c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7593), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e9e46e2-306b-5d9a-a808-dede83f14303",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4559), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f7ad149-1109-c158-fff4-eebbbe975f6e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3849), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f864d7c-c67f-f56e-e2a6-e81caa0aabf5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(648), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "806e5516-5c93-8d42-1c43-f35ad12413e7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6847), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 861, DateTimeKind.Utc).AddTicks(9432), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "836ed7e0-2d54-3cb8-ce6d-098490b6dbb6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(203), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "837a5313-e2ca-70ce-b21e-04e57c29273d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7140), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8456df79-c368-d48c-080a-14c3b7d043a8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6605), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "84625bac-78de-08a2-ebbb-0f23a3438f2f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3592), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "853ee613-597d-6c5f-42a8-1f01dee9ab9a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2859), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "854a6246-0ef2-a075-2559-1a62ca5df721",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9734), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "86326ae0-a407-3849-5ff6-25a0f1765f13",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5846), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "893e69dd-2a3d-1ad5-f5d1-352b9c7c7369",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6067), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a267077-bf51-b2a9-2f6f-4069c395db5b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2603), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a32ecaa-74c7-e6bf-1220-3bcab00827e2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9128), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b0e7710-5566-4a7d-690c-4ba8eaaf434d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8768), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b1af444-0adc-7e93-4cbd-4609d7228fd4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5635), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8c02fbdd-a0f0-1667-865b-5147fe3cf7c6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1827), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8cf67faa-eb7a-e250-a3aa-56e611c8ab3f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4890), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5066), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90ea8541-07c5-5db0-7222-72afe3e72787",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1406), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90f60174-bc3b-91c6-55d3-6c10d05b730e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8169), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91d28ddb-9dd9-f584-acbf-7dee0a018f79",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7660), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91de090e-524f-299a-8f71-774ef774db00",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4624), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92ba9474-33ed-8d58-e65d-882c311bf76b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3915), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92c610a8-e863-c16e-c90e-828d1e8e43f2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(795), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "93ad1841-7e77-5942-03ac-8dcb45a7abe4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6912), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(3700), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "96ba173e-04ae-3bcd-9986-9e56f0adbf3a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7241), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97a21ed8-9ac2-d3a1-d324-a99417c6272c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3658), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97ae9a0b-4f38-07b7-b6d5-a3f5043a73b3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(267), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "98892672-30d6-6b75-0cc1-b4d33ee08f1e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9799), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9896a2a5-e54c-9f8b-f073-ae332a53dba5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6670), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "99712d0c-c5ea-0349-465f-bf1165faf710",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5912), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "997da93f-7b60-375f-2910-b972516d4397",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2961), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9c7e2c08-4b21-e5d4-dc39-cf9c10ff0b66",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6157), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d6533a2-e135-7ea8-16d7-dada37197358",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2669), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d71b0d5-96ab-b2be-f988-d53b248cbfdf",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9203), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e4d3b3c-7749-167c-5074-e5195e32db4a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8835), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e59b76f-2cbf-4a92-3326-e0794ba527d1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5701), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f3542d6-0d5d-ae50-8a12-f057854c433c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4991), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f41bf09-c2d3-e266-6dc3-ebb872bf8fc3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1937), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5134), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a335c59f-de1e-5cc5-3c3b-068144de0b0b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8273), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a41dcc39-7432-f499-76d9-11bf6bf873fc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4690), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a429486c-29a8-28af-598a-0c20576bbf83",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1490), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a505d4d3-0a46-8c6d-b076-1cfe9211dbee",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(862), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a5115006-bfbc-c083-9328-165e7e852775",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7726), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6eddb6d-a05a-2441-ea14-273cb92b43e0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(7013), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6f957a0-55d0-5857-cdc5-219da59e8f67",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4033), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4040), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a9f9da6a-2691-07cd-80ef-37c764305736",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7308), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aae1e103-bca5-9fa1-ba8c-42058b4abf28",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3723), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aaed5e37-711b-d3b7-9d3d-3d6677bd0baf",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(368), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abc9e99d-51b9-3774-f42a-4d43b264271a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9865), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abd565d0-072f-6b8a-d7db-48a49ed773a1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6737), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acb1f037-e7cd-cf48-2dc7-5882d97d8f0c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5997), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acbd6d6a-9c43-035e-1178-53e3c5f0db93",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3026), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "afbdef34-6d04-b1d4-c3a2-690c8483a262",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6224), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b0b17301-b88e-7dbe-e0f1-6eac970f56db",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9355), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1997a9b-4ea2-1592-1a8e-79eabe29becd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5767), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1a5f7ce-0318-49a8-fd3f-744bab9c0a54",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2734), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b2818234-e4b7-ad65-542c-8429e54326bf",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2002), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b28dfe67-992c-e17c-37dd-7f89d2b67246",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8900), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b3750601-2f41-794f-717a-8ac8f9cfda38",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5057), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b67588cb-0001-28c5-24a4-a0f1b762a207",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8339), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5202), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b75d9065-9616-c099-5d41-ab30de7b0af9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4756), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b7690c98-4b8c-f4af-40f3-a591cbee5680",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1672), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b84597ff-2c2a-586d-97df-b66e059572eb",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(927), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b8511332-e1a0-8c83-7a90-b0cff208be72",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7791), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b92d9e98-c23e-f040-d17c-c1ad2caedadd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(7079), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b9391bcb-77b4-2457-b42e-bb0e19222664",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4099), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc399d95-4875-d2cc-6757-d137d7b4ee33",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7375), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4131), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bd2d2162-92ff-9eb6-84a6-d7d7eb41a2ac",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(436), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be1528fc-2813-368a-be43-e215125a0a9e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6803), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be21a52f-dd89-6aa0-a1f4-dc76fecd5625",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3825), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bf09acc9-739d-0274-db92-e7b425e7be17",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9930), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bffd3096-be27-ce5e-f8e1-ed5339747290",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3092), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c0f1b463-09b1-9a48-152f-f2f34c012609",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6063), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3f1362c-da72-49bd-c759-081c0b93eed8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9434), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3fdb25f-8fe8-7cd3-aa0a-037df7063a5f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6290), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4d93ec6-7086-e191-01f6-135b32ad56ca",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5867), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4e5baf9-25fc-15a7-e4a8-0ebc1e20a251",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2853), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5c14560-069a-7965-3b94-1e9959c6bebc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2067), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5cdc193-bb10-ad7b-1e45-19fa45390a43",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8965), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c6b5c92d-5124-454f-58e3-23396c537235",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5121), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9b54bf7-22e5-f3c4-0b0c-3a622be53a04",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8405), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5270), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "caa9cfc3-6d6f-bfae-285b-3f013f72ee7d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1738), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb91d75d-0383-5782-61f8-4a40658c566f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7857), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb9d5390-b8f9-8b98-45aa-44a152ffa2f6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4846), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc79def7-9997-ef56-9b96-557e8ca5be61",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4164), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc855a2a-4e0d-236c-7e47-4fdf79180ae8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(992), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cd6d62c4-e321-bb40-b8e5-5a1ea03272da",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(7143), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4208), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d06de48e-b4e2-6ab5-6b0e-70475fc43aa9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(501), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d07961c1-6958-9ecc-4ebf-6ba84b378630",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7441), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d155ec27-4af6-0289-a5ac-7b8686dea29b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6943), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d161685b-ff6c-369f-885d-76e77251ee22",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3893), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d23df3c1-e00a-9a5d-df49-86c4adf70a8d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3157), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d2496ff4-9580-ce73-c2fa-8125996b5614",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9995), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d330778e-2b94-6647-fc98-8c63c084be06",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6128), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d631f958-fc55-14bd-aec1-a28d7f1686d4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9507), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d63d768b-b1cb-48d3-9173-9cee6b8ad25c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6358), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d7257d25-47df-e0a7-cb10-a72c92a33a4d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2920), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d80c85bf-ddf3-787a-05ae-b26bb9bda23f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9068), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d81901f2-9269-ac91-e85f-adcca630eec6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(5938), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d900088b-287d-4464-22fc-b80acd4a56b8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2133), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d9f48c58-7308-104e-3f4b-bda9e0d60a31",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5186), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5337), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dde892ef-8f52-8bae-0fc3-d972b2f58679",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1804), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ddf50f22-44c8-bfc4-f275-d3d39f69d200",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8469), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ded09a89-2467-2382-4961-e4b1d90fee6b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8080), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dedc16bc-dadc-5798-2c12-de11c6823af2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4912), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfb8a123-ba7b-bb55-83fe-efef0029565d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4229), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfc41e56-6ff1-ef6c-66b0-e950ed9ca2e4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1172), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e0ac25ef-0505-873f-9f4d-f48e14b60ad6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(7207), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4348), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3aca8b9-d6c6-35b5-5276-0ab8d248d2a5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(566), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3b824ec-8b3b-69cb-3528-0519bfbb1e2c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7507), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e494af53-6cda-cd89-8c14-15f7f9613a97",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7010), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e4a02b86-2150-019f-6fc5-1057e6d5861e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3958), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e5883320-b764-9973-a963-1b960deeee10",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(102), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e6703aba-4d78-3147-e300-25d434085602",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6193), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e67cb6ed-02ee-655d-c6b1-2035207ba289",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3221), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e97c39b6-d3af-13d2-79db-365fdf0d6a58",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6552), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea644050-69c3-aca6-b278-419d0627d24a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(2987), new DateOnly(2025, 11, 5) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea70bd83-1e39-e0bc-962a-3cfef29a1ed1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9584), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb4c48ea-ffd7-447a-ec16-4cdc2d403a3c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9134), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb58c41d-b44d-7890-cfc7-473c19b486c3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6004), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec344f84-95eb-dc4e-26b3-571a545aa22e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(5250), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec40ccb7-4a61-1064-0965-517b40cdeeb5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2237), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(5444), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f028561a-b036-56ad-f62c-72e326791d76",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(1870), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f034d24e-65ac-8ac3-d9dd-6d4412ec69fd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(8535), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f1105db4-464a-ee81-30c9-7d214d938568",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(8149), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f11cd9e7-fbc0-2297-137a-78823906d1ef",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4977), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f204e181-91d4-ba6b-4d18-83c1601f39e1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(1259), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3ece81b-27e8-523f-87b5-8eff8739a1d3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(7272), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3f8654e-dc5e-8655-6a67-886074aced5a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(4332), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(4425), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f6f8e718-ad1f-35ca-1c90-9e8a323eb529",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(7611), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7e0efb2-4333-cd9e-562e-a9c859581d1b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(4024), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7ec6be5-f8a9-01b4-39df-a42946cb69a2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(631), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8c8f64b-d947-6572-90cb-b4078072850d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(167), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8d4727e-8ebd-9988-737c-af676de5d194",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(7075), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9b0fee5-6f5b-fd46-ca69-bf45a78bedff",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(6335), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9bc7a18-24d1-315c-ad1a-baa694fe3986",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(3311), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fcbcfce2-f592-dfd2-6043-d0d053910155",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(6621), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fda4047c-8ba6-77a5-9ae1-db0e7aaa6947",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(3054), new DateOnly(2025, 11, 6) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fdb080af-401c-abbc-7d92-d56f661db5ce",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 864, DateTimeKind.Utc).AddTicks(9700), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe8c0b16-21ba-0f79-d37e-e64ca0c4d139",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(9199), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe988849-d630-438f-b730-e0ad8d371dc0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 865, DateTimeKind.Utc).AddTicks(6069), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ff808fe2-6c44-db63-f0cd-ebecb45185b2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 30, 18, 42, 35, 866, DateTimeKind.Utc).AddTicks(2304), new DateOnly(2025, 11, 5) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OrgNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2018, 8, 30), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2017, 3, 17), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2025, 10, 12), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2020, 8, 10), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2015, 12, 1), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2023, 8, 29), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2022, 11, 19), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2020, 11, 26), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2024, 6, 10), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2017, 9, 18), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2021, 12, 29), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2024, 11, 6), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2017, 7, 23), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2020, 4, 3), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2016, 8, 3), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2018, 10, 14), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2022, 5, 10), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2025, 3, 30), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2019, 7, 21), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                columns: new[] { "HireDate", "PasswordHash" },
                values: new object[] { new DateOnly(2023, 11, 19), "AQAAAAIAAYagAAAAEKhMfbh6RhqMGftEUQEw1lxqMrV9nBTOxhqyFi8kZwzXWmivZAZZ0VrIWHxgc6zIIw==" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 16, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                column: "CreatedAt",
                value: new DateTime(2025, 10, 28, 21, 2, 3, 17, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "007413af-b7ce-a74d-0d1c-f18bc7de392b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1811), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "03749579-878f-56c3-c045-07b5867001fa",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4709), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "038011ac-3c05-89d9-a3f7-011573e34d81",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1528), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "045c9d13-1da3-ee97-fae3-12f3ad8969ec",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1085), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "04681946-d219-22ad-dd94-0c549afdb573",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7916), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0544a4ad-b3b7-866a-3480-1d32d4a3d1de",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7546), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "055020e0-682d-ba81-1732-1792c1161d65",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4375), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0638287a-fe42-5254-51cf-22d1e8308557",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(808), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0938aa43-cf02-00ca-03f8-38faa6c24d26",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3702), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "09442776-8478-34e0-e6aa-335b933599ad",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(431), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a20b2dd-6516-989e-3d96-4339cddcb517",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(85), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0a2c2e10-1a8c-ccb4-2047-3e9aba4f019e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6904), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b08b977-fb2b-3072-7733-4e77f4f51d09",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6508), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0b1436aa-b0a1-6488-5ae5-49d8e1686990",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3391), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0cfc3d44-46b5-fc5c-9482-54170882d182",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9757), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "0df0c111-913f-c845-b1d1-59b61b0f85fb",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2877), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10f043da-6200-77bb-64fa-6fe0daa14dca",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5821), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "10fcc00e-1776-abd1-47ac-6a40c6149951",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2599), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11d84b74-f814-0f8f-9e98-7a1e01bbb5bc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2345), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "11e4c7a7-ad8a-43a5-8149-757fed2e0143",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9119), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12c0520e-8d28-a763-d835-855c28d41dae",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8754), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "12cccf41-429e-db79-bbe7-7fbd14476935",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5505), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "13b3d6db-d8b2-734d-f484-8afc3b61d127",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1881), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16b459a5-a973-21c2-a7ae-a025faf399f6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4778), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "16c0d5d8-5ee9-55d8-8a5f-9b86e666e57d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1599), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "179c603e-3f87-b996-e14b-ab64210d01e8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1155), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "17a8dc72-f4fd-edac-c4fc-a6c50d804d6f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7986), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188367d8-d59b-516a-1be9-b6a2482669da",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7614), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "188fe40b-8a11-8580-fe9a-b103349ab561",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4444), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1977eba5-2025-1d54-3837-bc425bb31d53",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(876), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1c84eaa2-a65c-ffdf-ce12-cccc06b931a9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(504), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d6bf13c-3c70-98b3-07b0-d70a2dd2999b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6973), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1d786e6f-f1e6-ccc9-eb61-d26b1a45e522",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3771), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e53f9d6-d284-3087-414d-e24954ec018d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3497), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1e5f7509-87fa-649d-24fe-ddaa415f4d14",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(190), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f3b006f-6898-c85b-7beb-ed877b06697f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9825), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "1f477da2-1d0e-fc71-5e9c-e8e86879b506",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6577), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "202f843c-b322-9445-9839-f3278f921df8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2946), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "232f0706-83e3-42ba-4b63-09504d25e5c7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5891), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "233b8339-3959-76d1-2e14-03b13a98314e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2669), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24170ea0-19f7-da8e-8500-148f743e4db9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2492), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "24238ad3-ce6d-0ea4-68b2-0ef061b19940",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9187), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "250b926d-6481-a678-a24f-192e88cb0132",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5610), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "25ff163a-af0b-7262-bf9e-1fcd9b58b5ab",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8822), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "26f39906-fa95-3e4c-dced-246cafe56924",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1950), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "29ff9803-80cc-20d8-71c7-35f75aea7d7a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1669), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2ae7a09d-16e0-b9ac-ab65-40358104e56c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8055), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2af31cd0-cb56-edc2-8e16-3a966d7731f3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4846), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bcfa737-acf4-517f-e502-4b74a81d4d5e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4594), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2bdb236a-616a-8595-c8b4-45d5949099e5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1222), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cb7aed1-4208-e953-1fa0-56b2cf37b550",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(945), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2cc32b04-f77e-1d69-0251-5013bbaa01d7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7779), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "2fc3adcd-c83f-cbdf-b57a-663d7a3cc8a6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(615), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30abb567-5e53-63b3-ef18-717ba1563098",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7041), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "30b7319a-13c9-97c9-d2c9-6cdc8ec97c1f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3839), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3193bc01-f467-fb87-29b5-7cbac86f988a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3565), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "319f3834-a9dd-2f9d-0c67-771ab5e3e411",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(259), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "327bc49b-8a7c-935a-6253-87f8ef89007c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9894), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "328740ce-3ff2-c770-4504-8259dbfc4c03",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6685), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "336f4768-d406-5f44-7fa2-8c970216b4f5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3015), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "366fca31-a5c6-0eba-32cb-a3c1c1a87cc4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5960), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "367b4665-5a3c-42d0-157c-9d22ae1bc84b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2739), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "37634efe-f051-daa4-4f1a-a860d535303d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9255), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "384b5598-8665-7278-89b7-b39ffc4e982f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5679), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3857d1cb-3bdb-a68e-6c69-ad00e8c2e4b6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2560), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "39335d32-1c79-0a4c-c355-bedd23680021",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2018), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "393fd965-d1ef-3e62-a606-b83e0fdb4ca8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8928), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3c3f5b2f-a2b0-ecd7-5830-ce68ce6d1477",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1778), new DateOnly(2025, 10, 26) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d2763c9-38c4-84ab-92cd-d9a6f5877c68",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8206), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3d33dffc-ed3a-b8c1-757e-d407e1fac8ef",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4915), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e0f6a62-ced8-1c7f-cc6b-e4e51ca1e45a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4662), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3e1be795-834e-5095-af1c-df45081430e1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1435), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3f03ee2f-1962-e869-e9b9-ea842f2e98d3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7852), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "3ff772fc-64ec-b453-0608-ef2343ba4c4c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1051), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "420371f9-ea23-96de-9ce3-00aeeec060a2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(689), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43eb7893-8037-2fb2-d680-0bec15d9c894",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7109), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "43f7f4c6-35ad-63c8-b932-054d014d141b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3948), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "44dffc60-cbc1-fb9c-f3cf-108b28667c0d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(326), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45c703f9-60d5-9370-2d6d-1bca4f80e4ff",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6754), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "45d37f2d-154b-c786-101e-162a3cf33086",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3633), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46af0b93-f6e9-2b44-660a-260876994cf1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3163), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "46bb87c6-ab5f-5f5a-4abb-2169630d9878",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9987), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "49bb0990-7c20-0dcf-fce5-3793219f6047",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2919), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aa3112a-1234-a5a3-3682-42d148b8c839",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9323), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4aaf8d5d-c7aa-d9b9-1934-3c32352c14c0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6030), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b8b18c4-a848-3d77-7020-4d106fd2302b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5749), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4b9795f7-5dbe-718d-53d1-47705c457cb2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2629), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c73205d-3e5c-d54b-aabd-584e96ec981d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2126), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4c7f9c91-f3d2-0961-8d6f-52af835fe4a4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8997), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "4f7f1f5a-c493-b7d7-4098-68d841f1ac73",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1850), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "506726f4-5aa7-50aa-7935-7317680b1465",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8276), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5073a227-0f1d-84c1-5de7-6e78557e60ec",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5021), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "515baac1-a531-1c94-9684-79b67c97c8de",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1522), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5243b15b-3b45-b468-d022-84f5a3b130d0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7922), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "524f2e8e-f0bb-e87e-b3d3-7e558f247c57",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4731), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "53363528-86cf-8052-ed70-8994b63ee449",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1120), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5637b8f1-5790-2ec8-a09a-9fbe75d0ac18",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4018), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "56433424-0c06-62de-834b-9a1e6143f89f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(761), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "571fbf8b-eca4-c69c-da37-aafc9cea140a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(395), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "572b3bbe-a11a-fab2-bde9-a55d885d6091",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7215), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5806c725-82b8-5e6f-14d5-b53ac3037cfc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6822), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "58124358-372e-9285-f786-b09baf76c883",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3701), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59eecebf-18cd-f643-4e72-c079ea1de4ee",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3235), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "59fa4af2-cd42-2a59-3124-badad6903075",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(55), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5cfbcdbc-9e03-d9cf-e34d-d1039522f844",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2989), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5de2d455-3417-71a3-1deb-db42bc3c6036",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9391), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5dee5088-e98d-a5b9-009c-d6a3a8afacbd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6150), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5ed65822-7fa1-3d8d-3a39-e1e1cfc914af",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2698), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fbe5fbc-15b6-d560-74d7-ec20f6e27ca1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9066), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "5fcadcef-ca2c-0977-5788-e680e356c828",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5818), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "60b2e389-6040-a14a-9126-f1bf0a6f301a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2195), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63b26653-3101-4fc0-444f-07e8c901f8e9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5091), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "63bee286-e676-83d6-2700-0249b5744470",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1920), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "649a6ded-c715-e794-7eed-1227f01b60db",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1666), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "64a6e920-7c8b-1baa-619e-0d88dc8eac62",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8372), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "65827586-5d29-7f68-b78a-1d651635c8cd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7991), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "658ef1b9-129f-b37e-9a3b-18c603a81454",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4799), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6676f853-a8b3-4b52-d4d9-23052ac17c46",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1189), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "69767b1d-7874-fac7-8702-392ee9544415",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4086), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6982f750-2dea-2ddd-6ab4-338fd5c7909c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(835), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a5e82b7-0e88-929b-c1a0-446d106dac07",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(503), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6a6affea-c3fe-c6b1-a451-3ecefce0f88e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7287), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6b520684-5912-5e85-deef-490c23fa6080",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3770), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c3a0e1d-ef26-f659-188c-544a4a14c872",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(124), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6c468a51-a49c-2a6f-fb3d-4fab378714f9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6891), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "6d2e91ea-3ab0-c243-35db-5aea5ea07ceb",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3303), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "702e14b4-0b71-70b8-e704-70131c3343b9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6221), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "703a90e7-c0e7-a4ce-cab6-6a7409a68f41",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3058), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71161b4e-a185-088c-21a2-7b52434cabab",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2803), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "71229881-56fb-3ca2-0453-75b330bff732",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9497), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "720a9f1b-ec0f-d476-3ef1-80f157d95f24",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5886), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "72fe23e8-3799-a060-5b3f-86906a66139d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9133), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "73f2a6b5-8223-6c4a-788e-8b307ef3c716",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2263), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76f2297e-53e4-1bbf-2bb7-a1593c858fe5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5159), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "76fea5b1-085a-4ed6-0e69-9cba29f8db6c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1990), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77da3018-e9f8-b393-6555-ac98639ef7d7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1739), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "77e6ad4b-9e6e-e7a9-4806-a7f95012435e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8440), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "78ceb4e5-3382-7f7d-82a4-b237772bab50",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4918), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79b6bc7f-c996-1751-bc41-bc759e451342",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1257), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "79c238b2-7e0c-4b67-9ff2-b7d68ab85fc9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8059), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7cc2ba7c-4fcd-f9dd-511c-cd00494a2798",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(908), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7daac215-e5e1-91b1-8bb9-d83e70648f8a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7356), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7db63e48-9a57-c5c7-6e6b-d39f5cd7db11",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4156), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e92c9af-7bf5-2984-c557-e37d977df77c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3876), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7e9e46e2-306b-5d9a-a808-dede83f14303",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(572), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f7ad149-1109-c158-fff4-eebbbe975f6e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(192), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "7f864d7c-c67f-f56e-e2a6-e81caa0aabf5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6959), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "806e5516-5c93-8d42-1c43-f35ad12413e7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3371), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8286d046-9740-a3e4-95cf-ff46699c73c4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 23, DateTimeKind.Utc).AddTicks(3351), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "836ed7e0-2d54-3cb8-ce6d-098490b6dbb6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6290), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "837a5313-e2ca-70ce-b21e-04e57c29273d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3127), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8456df79-c368-d48c-080a-14c3b7d043a8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2872), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "84625bac-78de-08a2-ebbb-0f23a3438f2f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9566), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "853ee613-597d-6c5f-42a8-1f01dee9ab9a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9202), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "854a6246-0ef2-a075-2559-1a62ca5df721",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5992), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "86326ae0-a407-3849-5ff6-25a0f1765f13",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2331), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "893e69dd-2a3d-1ad5-f5d1-352b9c7c7369",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2060), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a267077-bf51-b2a9-2f6f-4069c395db5b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8508), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8a32ecaa-74c7-e6bf-1220-3bcab00827e2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5228), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b0e7710-5566-4a7d-690c-4ba8eaaf434d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4989), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8b1af444-0adc-7e93-4cbd-4609d7228fd4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1808), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8c02fbdd-a0f0-1667-865b-5147fe3cf7c6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8236), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8cf67faa-eb7a-e250-a3aa-56e611c8ab3f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1326), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "8f027ea7-71b0-c4dc-3884-6771bccebf95",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1066), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90ea8541-07c5-5db0-7222-72afe3e72787",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7425), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "90f60174-bc3b-91c6-55d3-6c10d05b730e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4225), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91d28ddb-9dd9-f584-acbf-7dee0a018f79",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3945), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "91de090e-524f-299a-8f71-774ef774db00",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(640), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92ba9474-33ed-8d58-e65d-882c311bf76b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(340), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "92c610a8-e863-c16e-c90e-828d1e8e43f2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7052), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "93ad1841-7e77-5942-03ac-8dcb45a7abe4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3441), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "95c69371-b924-6fe3-7c38-98b7dd200bc1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 25, DateTimeKind.Utc).AddTicks(9577), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "96ba173e-04ae-3bcd-9986-9e56f0adbf3a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3248), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97a21ed8-9ac2-d3a1-d324-a99417c6272c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9635), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "97ae9a0b-4f38-07b7-b6d5-a3f5043a73b3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6359), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "98892672-30d6-6b75-0cc1-b4d33ee08f1e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6061), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9896a2a5-e54c-9f8b-f073-ae332a53dba5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2941), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "99712d0c-c5ea-0349-465f-bf1165faf710",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2400), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "997da93f-7b60-375f-2910-b972516d4397",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9313), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9c7e2c08-4b21-e5d4-dc39-cf9c10ff0b66",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2164), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d6533a2-e135-7ea8-16d7-dada37197358",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8576), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9d71b0d5-96ab-b2be-f988-d53b248cbfdf",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5297), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e4d3b3c-7749-167c-5074-e5195e32db4a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5058), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9e59b76f-2cbf-4a92-3326-e0794ba527d1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1877), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f3542d6-0d5d-ae50-8a12-f057854c433c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1432), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "9f41bf09-c2d3-e266-6dc3-ebb872bf8fc3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8305), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a24141d3-9394-90dc-1fed-01e130515792",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1137), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a335c59f-de1e-5cc5-3c3b-068144de0b0b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4332), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a41dcc39-7432-f499-76d9-11bf6bf873fc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(707), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a429486c-29a8-28af-598a-0c20576bbf83",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7494), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a505d4d3-0a46-8c6d-b076-1cfe9211dbee",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7121), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a5115006-bfbc-c083-9328-165e7e852775",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4013), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6eddb6d-a05a-2441-ea14-273cb92b43e0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3606), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a6f957a0-55d0-5857-cdc5-219da59e8f67",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(411), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a905569d-db07-3ae3-63a0-322750a4a3bd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 25, DateTimeKind.Utc).AddTicks(9937), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "a9f9da6a-2691-07cd-80ef-37c764305736",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3318), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aae1e103-bca5-9fa1-ba8c-42058b4abf28",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9703), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "aaed5e37-711b-d3b7-9d3d-3d6677bd0baf",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6520), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abc9e99d-51b9-3774-f42a-4d43b264271a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6130), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "abd565d0-072f-6b8a-d7db-48a49ed773a1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3010), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acb1f037-e7cd-cf48-2dc7-5882d97d8f0c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2506), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "acbd6d6a-9c43-035e-1178-53e3c5f0db93",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9381), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "afbdef34-6d04-b1d4-c3a2-690c8483a262",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2232), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b0b17301-b88e-7dbe-e0f1-6eac970f56db",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5390), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1997a9b-4ea2-1592-1a8e-79eabe29becd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1946), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b1a5f7ce-0318-49a8-fd3f-744bab9c0a54",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8720), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b2818234-e4b7-ad65-542c-8429e54326bf",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8373), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b28dfe67-992c-e17c-37dd-7f89d2b67246",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5126), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b3750601-2f41-794f-717a-8ac8f9cfda38",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1502), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b67588cb-0001-28c5-24a4-a0f1b762a207",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4401), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b68104fe-b577-5bdb-0755-9a52a4d5ee8e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1209), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b75d9065-9616-c099-5d41-ab30de7b0af9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(776), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b7690c98-4b8c-f4af-40f3-a591cbee5680",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7603), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b84597ff-2c2a-586d-97df-b66e059572eb",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7191), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b8511332-e1a0-8c83-7a90-b0cff208be72",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4082), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b92d9e98-c23e-f040-d17c-c1ad2caedadd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3674), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "b9391bcb-77b4-2457-b42e-bb0e19222664",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(480), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc399d95-4875-d2cc-6757-d137d7b4ee33",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3388), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bc4519c8-fdeb-06e2-4a08-cc98c4273aba",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(27), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bd2d2162-92ff-9eb6-84a6-d7d7eb41a2ac",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6590), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be1528fc-2813-368a-be43-e215125a0a9e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3079), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "be21a52f-dd89-6aa0-a1f4-dc76fecd5625",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9810), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bf09acc9-739d-0274-db92-e7b425e7be17",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6198), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "bffd3096-be27-ce5e-f8e1-ed5339747290",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9449), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c0f1b463-09b1-9a48-152f-f2f34c012609",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2575), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3f1362c-da72-49bd-c759-081c0b93eed8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5459), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c3fdb25f-8fe8-7cd3-aa0a-037df7063a5f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2301), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4d93ec6-7086-e191-01f6-135b32ad56ca",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2070), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c4e5baf9-25fc-15a7-e4a8-0ebc1e20a251",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8792), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5c14560-069a-7965-3b94-1e9959c6bebc",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8440), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c5cdc193-bb10-ad7b-1e45-19fa45390a43",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5196), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c6b5c92d-5124-454f-58e3-23396c537235",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1570), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9b54bf7-22e5-f3c4-0b0c-3a622be53a04",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4469), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "c9c1c82a-d75b-27da-eebd-34c31858868b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1279), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "caa9cfc3-6d6f-bfae-285b-3f013f72ee7d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7673), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb91d75d-0383-5782-61f8-4a40658c566f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4169), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cb9d5390-b8f9-8b98-45aa-44a152ffa2f6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(880), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc79def7-9997-ef56-9b96-557e8ca5be61",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(549), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cc855a2a-4e0d-236c-7e47-4fdf79180ae8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7259), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cd6d62c4-e321-bb40-b8e5-5a1ea03272da",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3741), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "cf85ddf4-1ece-d1e2-3171-650938abd2b7",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(108), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d06de48e-b4e2-6ab5-6b0e-70475fc43aa9",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6660), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d07961c1-6958-9ecc-4ebf-6ba84b378630",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3458), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d155ec27-4af6-0289-a5ac-7b8686dea29b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3183), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d161685b-ff6c-369f-885d-76e77251ee22",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9879), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d23df3c1-e00a-9a5d-df49-86c4adf70a8d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9516), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d2496ff4-9580-ce73-c2fa-8125996b5614",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6302), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d330778e-2b94-6647-fc98-8c63c084be06",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2646), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d631f958-fc55-14bd-aec1-a28d7f1686d4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5529), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d63d768b-b1cb-48d3-9173-9cee6b8ad25c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2372), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d7257d25-47df-e0a7-cb10-a72c92a33a4d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8860), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d80c85bf-ddf3-787a-05ae-b26bb9bda23f",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5300), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d81901f2-9269-ac91-e85f-adcca630eec6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2140), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d900088b-287d-4464-22fc-b80acd4a56b8",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8509), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "d9f48c58-7308-104e-3f4b-bda9e0d60a31",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1638), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dc018b55-f93e-f2da-d526-ce348bdc1e87",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1384), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dde892ef-8f52-8bae-0fc3-d972b2f58679",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7743), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ddf50f22-44c8-bfc4-f275-d3d39f69d200",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4537), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ded09a89-2467-2382-4961-e4b1d90fee6b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4239), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dedc16bc-dadc-5798-2c12-de11c6823af2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(948), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfb8a123-ba7b-bb55-83fe-efef0029565d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(619), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "dfc41e56-6ff1-ef6c-66b0-e950ed9ca2e4",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7407), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e0ac25ef-0505-873f-9f4d-f48e14b60ad6",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3809), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e2c4a01f-40b1-9de1-18d9-ff7aab2e6ab3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(277), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3aca8b9-d6c6-35b5-5276-0ab8d248d2a5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6728), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e3b824ec-8b3b-69cb-3528-0519bfbb1e2c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3527), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e494af53-6cda-cd89-8c14-15f7f9613a97",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3253), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e4a02b86-2150-019f-6fc5-1057e6d5861e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(9947), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e5883320-b764-9973-a963-1b960deeee10",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6371), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e6703aba-4d78-3147-e300-25d434085602",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2714), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e67cb6ed-02ee-655d-c6b1-2035207ba289",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9620), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "e97c39b6-d3af-13d2-79db-365fdf0d6a58",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2461), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea644050-69c3-aca6-b278-419d0627d24a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8930), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ea70bd83-1e39-e0bc-962a-3cfef29a1ed1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5597), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb4c48ea-ffd7-447a-ec16-4cdc2d403a3c",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5368), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "eb58c41d-b44d-7890-cfc7-473c19b486c3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2209), new DateOnly(2025, 10, 28) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec344f84-95eb-dc4e-26b3-571a545aa22e",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(1743), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ec40ccb7-4a61-1064-0965-517b40cdeeb5",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8616), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ef404e81-1b22-bed9-bc8e-68a5ff5fb584",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(1457), new DateOnly(2025, 10, 31) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f028561a-b036-56ad-f62c-72e326791d76",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(7812), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f034d24e-65ac-8ac3-d9dd-6d4412ec69fd",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(4638), new DateOnly(2025, 11, 3) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f1105db4-464a-ee81-30c9-7d214d938568",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(4307), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f11cd9e7-fbc0-2297-137a-78823906d1ef",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(1017), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f204e181-91d4-ba6b-4d18-83c1601f39e1",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(7478), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3ece81b-27e8-523f-87b5-8eff8739a1d3",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(3913), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f3f8654e-dc5e-8655-6a67-886074aced5a",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(739), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f604634b-6295-68e1-ff41-99ea1fb201b0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(356), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f6f8e718-ad1f-35ca-1c90-9e8a323eb529",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(3632), new DateOnly(2025, 10, 27) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7e0efb2-4333-cd9e-562e-a9c859581d1b",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(16), new DateOnly(2025, 11, 2) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f7ec6be5-f8a9-01b4-39df-a42946cb69a2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(6798), new DateOnly(2025, 10, 30) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8c8f64b-d947-6572-90cb-b4078072850d",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(6439), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f8d4727e-8ebd-9988-737c-af676de5d194",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(3322), new DateOnly(2025, 10, 26) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9b0fee5-6f5b-fd46-ca69-bf45a78bedff",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 28, DateTimeKind.Utc).AddTicks(2806), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "f9bc7a18-24d1-315c-ad1a-baa694fe3986",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(9689), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fcbcfce2-f592-dfd2-6043-d0d053910155",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(2531), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fda4047c-8ba6-77a5-9ae1-db0e7aaa6947",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(8997), new DateOnly(2025, 11, 4) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fdb080af-401c-abbc-7d92-d56f661db5ce",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 26, DateTimeKind.Utc).AddTicks(5750), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe8c0b16-21ba-0f79-d37e-e64ca0c4d139",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(5436), new DateOnly(2025, 11, 1) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "fe988849-d630-438f-b730-e0ad8d371dc0",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(2277), new DateOnly(2025, 10, 29) });

            migrationBuilder.UpdateData(
                table: "TimeEntries",
                keyColumn: "Id",
                keyValue: "ff808fe2-6c44-db63-f0cd-ebecb45185b2",
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2025, 10, 28, 21, 2, 3, 27, DateTimeKind.Utc).AddTicks(8684), new DateOnly(2025, 11, 4) });
        }
    }
}
