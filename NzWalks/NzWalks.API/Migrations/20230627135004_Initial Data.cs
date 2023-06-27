using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NzWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diffuculties",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diffuculties", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Walks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LengthInKm = table.Column<double>(type: "float", nullable: false),
                    WalkImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Walks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Walks_Diffuculties_DifficultyID",
                        column: x => x.DifficultyID,
                        principalTable: "Diffuculties",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Walks_Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Diffuculties",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("5b8483c8-5a27-4c17-9b4e-30fb1553426c"), new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4495), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medium", 1 },
                    { new Guid("a48dc7a3-334c-473c-a995-50f5975414ec"), new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Easy", 1 },
                    { new Guid("d58a36f9-a5f2-437c-9436-c571149ed577"), new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4497), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hard", 1 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "Code", "CreatedDate", "ModifiedDate", "Name", "RegionImageUrl", "Status" },
                values: new object[,]
                {
                    { new Guid("14ceba71-4b51-4777-9b17-46602cf66153"), "BOP", new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4579), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bay Of Plenty", null, 1 },
                    { new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "NTL", new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4577), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northland", null, 1 },
                    { new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "NSN", new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4581), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 1 },
                    { new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"), "WGN", new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4580), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 1 },
                    { new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "STL", new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4587), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Southland", null, 1 },
                    { new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"), "AKL", new DateTime(2023, 6, 27, 16, 50, 3, 991, DateTimeKind.Local).AddTicks(4572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Walks_DifficultyID",
                table: "Walks",
                column: "DifficultyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Walks_RegionID",
                table: "Walks",
                column: "RegionID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Walks");

            migrationBuilder.DropTable(
                name: "Diffuculties");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
