using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class vin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a59ebae8-b711-4015-85f7-645f7ed2e677", "AQAAAAIAAYagAAAAEFJwiOxy95gae6IusFbZX71LS9yv+BRZ41lw277uFnO5i27qcJ8fniXvK0EGzlTLOA==", "eec641ec-6dee-44b3-a221-34c6d066ae8e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "472ba632-6133-44a1-b158-6c10bd7d850d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "218036a7-3af7-4418-bdf1-5e9eaf10d17b", "AQAAAAIAAYagAAAAEGhim8p0po/3j5/QRKnK5yOEwxxGktd+ByD1Yp8yVNQLBUmCSpYz1qGBqfBrPHi/Fw==", "8a10b868-b1f0-4943-9b19-685194d02c46" });
        }
    }
}
