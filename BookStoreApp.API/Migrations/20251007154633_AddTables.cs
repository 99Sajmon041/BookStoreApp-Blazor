using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8343074e-8623-4e1a-b0c1-84fb8678c8f3",
                column: "ConcurrencyStamp",
                value: "11059d62-bdd7-42bd-993e-9c350047d1ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ac6cfe-1f10-4baf-b604-cde350db9554",
                column: "ConcurrencyStamp",
                value: "2dac3cae-c05c-4655-9a2f-f59554f17b47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b47d43e-68d8-4452-8f53-41cbdb001b15", "AQAAAAEAACcQAAAAEF43wUU2Z+xzkZIAu9ntVageCyXIzyWG4cZD0VxuOiDGeeUhARGwGNm/2tJpGKzrMg==", "b2d7202b-731d-4e92-9bf9-6ef690bc8c61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b833532-e916-4212-9a3d-7f80e2b02535", "AQAAAAEAACcQAAAAEPz4hlvtPKaxP6CTdzr2fY7fyTv6424w42tXuCYbXnESRVpa4IoxXEFzGYY3YQvRtg==", "7342ba95-5e32-44d6-969d-57e4bcadf4f3" });
        }
    }
}
