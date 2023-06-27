using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NzWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class ImageUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("5b8483c8-5a27-4c17-9b4e-30fb1553426c"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("a48dc7a3-334c-473c-a995-50f5975414ec"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Diffuculties",
                keyColumn: "ID",
                keyValue: new Guid("d58a36f9-a5f2-437c-9436-c571149ed577"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("14ceba71-4b51-4777-9b17-46602cf66153"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "ID",
                keyValue: new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 22, 34, 44, 75, DateTimeKind.Local).AddTicks(4833));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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
    }
}
