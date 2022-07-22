using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningDiary_IK0._1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EstimatedTimeToMaster = table.Column<double>(nullable: false),
                    TimeSpent = table.Column<double>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    StartLearningDate = table.Column<DateTime>(nullable: true),
                    inProgress = table.Column<bool>(nullable: false),
                    CompletionDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
