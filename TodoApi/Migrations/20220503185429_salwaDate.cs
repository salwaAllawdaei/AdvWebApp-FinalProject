using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.Migrations
{
    public partial class salwaDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "details",
                table: "ToDoAppointments",
                newName: "Details");

            migrationBuilder.RenameColumn(
                name: "comments",
                table: "ToDoAppointments",
                newName: "Comments");

            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "ToDoAppointments",
                newName: "AppointmentDateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "ToDoAppointments",
                newName: "details");

            migrationBuilder.RenameColumn(
                name: "Comments",
                table: "ToDoAppointments",
                newName: "comments");

            migrationBuilder.RenameColumn(
                name: "AppointmentDateTime",
                table: "ToDoAppointments",
                newName: "Deadline");
        }
    }
}
