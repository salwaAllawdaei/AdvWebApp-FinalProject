using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.Migrations
{
    public partial class onyh22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Task",
                table: "TodoItems",
                newName: "Cont");

            migrationBuilder.RenameColumn(
                name: "Reward",
                table: "TodoItems",
                newName: "details");

            migrationBuilder.RenameColumn(
                name: "IsComplete",
                table: "TodoItems",
                newName: "IsConfirmed");

            migrationBuilder.RenameColumn(
                name: "Instructions",
                table: "TodoItems",
                newName: "Appointment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "details",
                table: "TodoItems",
                newName: "Reward");

            migrationBuilder.RenameColumn(
                name: "IsConfirmed",
                table: "TodoItems",
                newName: "IsComplete");

            migrationBuilder.RenameColumn(
                name: "Cont",
                table: "TodoItems",
                newName: "Task");

            migrationBuilder.RenameColumn(
                name: "Appointment",
                table: "TodoItems",
                newName: "Instructions");
        }
    }
}
