using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trainee_app_backend.Migrations
{
    public partial class DropBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_BaseEntities_Id",
                table: "Achievements");

            migrationBuilder.DropTable(
                name: "BaseEntities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_BaseEntities_Id",
                table: "Achievements",
                column: "Id",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
