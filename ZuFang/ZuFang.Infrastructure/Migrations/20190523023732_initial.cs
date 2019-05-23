using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZuFang.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashFlows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    HouseId = table.Column<int>(nullable: false),
                    RoomId = table.Column<int>(nullable: false),
                    Rent = table.Column<decimal>(nullable: false),
                    ManageCharge = table.Column<decimal>(nullable: false),
                    NetCharge = table.Column<decimal>(nullable: false),
                    CleanCharge = table.Column<decimal>(nullable: false),
                    Water1 = table.Column<float>(nullable: false),
                    Water2 = table.Column<float>(nullable: false),
                    WaterCharge = table.Column<decimal>(nullable: false),
                    Electricity1 = table.Column<float>(nullable: false),
                    Electricity2 = table.Column<float>(nullable: false),
                    ElectricityCharge = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashFlows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    HouseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    RoomNo = table.Column<string>(nullable: true),
                    ContractDate = table.Column<DateTime>(nullable: false),
                    Months = table.Column<int>(nullable: false),
                    Rent = table.Column<decimal>(nullable: false),
                    Deposit = table.Column<decimal>(nullable: false),
                    ManageCharge = table.Column<decimal>(nullable: false),
                    NetCharge = table.Column<decimal>(nullable: false),
                    CleanCharge = table.Column<decimal>(nullable: false),
                    WaterCharge = table.Column<decimal>(nullable: false),
                    ElectricityCharge = table.Column<decimal>(nullable: false),
                    Card1Charge = table.Column<decimal>(nullable: false),
                    Card2Charge = table.Column<decimal>(nullable: false),
                    KeyCharge = table.Column<decimal>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    HouseId = table.Column<int>(nullable: false),
                    GuestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "CreationDate", "HouseName" },
                values: new object[] { 1, new DateTime(2019, 5, 23, 10, 37, 31, 928, DateTimeKind.Local).AddTicks(4169), "1号公寓" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "CreationDate", "HouseName" },
                values: new object[] { 2, new DateTime(2019, 5, 23, 10, 37, 31, 928, DateTimeKind.Local).AddTicks(9152), "青年公寓" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "CreationDate", "HouseName" },
                values: new object[] { 3, new DateTime(2019, 5, 23, 10, 37, 31, 928, DateTimeKind.Local).AddTicks(9158), "柠檬公寓" });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_GuestId",
                table: "Contracts",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_HouseId",
                table: "Contracts",
                column: "HouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashFlows");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
