using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourPlanner.Migrations
{
    public partial class ConfigForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cities_EndPointId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cities_StartingPointId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_EndPointId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "EndPointId",
                table: "Routes");

            migrationBuilder.AlterColumn<Guid>(
                name: "StartingPointId",
                table: "Routes",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EndingPointId",
                table: "Routes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Routes_EndingPointId",
                table: "Routes",
                column: "EndingPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cities_EndingPointId",
                table: "Routes",
                column: "EndingPointId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cities_StartingPointId",
                table: "Routes",
                column: "StartingPointId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cities_EndingPointId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cities_StartingPointId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_EndingPointId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "EndingPointId",
                table: "Routes");

            migrationBuilder.AlterColumn<Guid>(
                name: "StartingPointId",
                table: "Routes",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "EndPointId",
                table: "Routes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Routes_EndPointId",
                table: "Routes",
                column: "EndPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cities_EndPointId",
                table: "Routes",
                column: "EndPointId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cities_StartingPointId",
                table: "Routes",
                column: "StartingPointId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
