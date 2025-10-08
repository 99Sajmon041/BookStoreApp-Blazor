using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class AddEverythingToADb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8343074e-8623-4e1a-b0c1-84fb8678c8f3",
                column: "ConcurrencyStamp",
                value: "6fa9b8a3-0897-4b36-8f79-8195d317a891");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ac6cfe-1f10-4baf-b604-cde350db9554",
                column: "ConcurrencyStamp",
                value: "975ad449-60f8-4f35-a747-816ff7800165");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76d46552-62e7-4e61-84bc-31a26213fe3c", "AQAAAAEAACcQAAAAEN3g+iLL3JYJYzWeXvCM0CpkVMfvrIB2fVILLwHW5chiyyfwR1gU72YOL4l8MvWtSw==", "e3f400b2-42f9-40dd-b15e-263ca940357e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60c9191f-a90b-46e9-8646-723405a2963c", "AQAAAAEAACcQAAAAEF8jY60PFyQHdgQLdepfs0vCagfdGoztpuOF45aBtF6U2zZObxghWm/Xa/EY2fC2Pw==", "95624c7b-883c-48e9-b75e-dc086438f948" });
        }
    }
}
