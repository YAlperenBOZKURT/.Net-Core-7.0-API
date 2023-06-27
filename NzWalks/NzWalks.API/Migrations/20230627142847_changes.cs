using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NzWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("5b8483c8-5a27-4c17-9b4e-30fb1553426c"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("a48dc7a3-334c-473c-a995-50f5975414ec"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("d58a36f9-a5f2-437c-9436-c571149ed577"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("14ceba71-4b51-4777-9b17-46602cf66153"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 17, 28, 47, 750, DateTimeKind.Local).AddTicks(3761));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("5b8483c8-5a27-4c17-9b4e-30fb1553426c"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("a48dc7a3-334c-473c-a995-50f5975414ec"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("d58a36f9-a5f2-437c-9436-c571149ed577"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("14ceba71-4b51-4777-9b17-46602cf66153"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4572));
        }
    }
}
