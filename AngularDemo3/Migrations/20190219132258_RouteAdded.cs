using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourPlanner.Migrations
{
    public partial class RouteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StartingPointId = table.Column<Guid>(nullable: true),
                    EndPointId = table.Column<Guid>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Cities_EndPointId",
                        column: x => x.EndPointId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routes_Cities_StartingPointId",
                        column: x => x.StartingPointId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_EndPointId",
                table: "Routes",
                column: "EndPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_StartingPointId",
                table: "Routes",
                column: "StartingPointId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
