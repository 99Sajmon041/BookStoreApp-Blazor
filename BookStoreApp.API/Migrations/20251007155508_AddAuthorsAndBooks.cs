using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class AddAuthorsAndBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8343074e-8623-4e1a-b0c1-84fb8678c8f3",
                column: "ConcurrencyStamp",
                value: "c101fcdc-048c-4db2-9531-0ce8eb6542d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ac6cfe-1f10-4baf-b604-cde350db9554",
                column: "ConcurrencyStamp",
                value: "2348a4c9-1dea-42cf-a5ec-f0c8de70e755");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfd90e76-d543-42f6-9a1a-00ca0e2b2f42", "AQAAAAEAACcQAAAAEJPVuh8sbdkJU6bQiwB+z9E+EC+AaRwkFOjEBN/ZEwAX2ZYaQ8KRW7e+z8qw7VQL2g==", "f5be66d5-fb54-45d0-b80e-627166e8464c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfc335b7-efa0-498b-a68a-df3b0047df14", "AQAAAAEAACcQAAAAEIkLvNqgO3vBtxiFXAgBBGxR4EmdgxzHb1jiRE4LT6MtkMXK7iamTq7J8GBugRXCdw==", "a5fd9ac7-a044-4c4f-a92f-8c90b5b8a304" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8343074e-8623-4e1a-b0c1-84fb8678c8f3",
                column: "ConcurrencyStamp",
                value: "06121b40-b7d6-4c57-9e96-ab3282e20f4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ac6cfe-1f10-4baf-b604-cde350db9554",
                column: "ConcurrencyStamp",
                value: "c1eab6de-5630-4b8c-9d17-f44b76d3bfbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e481b3f-274a-446a-b1f2-0db315417d59", "AQAAAAEAACcQAAAAEEIdLMM/QG86E8fznFv35qmcUk2Abfp6OsTK4UioomMyi6xXJBxKXUIAD5bbGwM05g==", "0d245afc-840f-49f5-85a8-0974288aca9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d90b829a-e5c5-4766-8e29-860e58fead1e", "AQAAAAEAACcQAAAAEDii+nMfTIqftZIrZpxBuE8rfTl5GCv7GDI75Q37VAixHj/yHw6VysVr5nCnNlFwQw==", "31d799c8-d0e6-442e-9d28-f5b1e201b77e" });
        }
    }
}
