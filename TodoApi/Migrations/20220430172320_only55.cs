using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.Migrations
{
    public partial class only55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "ToDoAppointments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoAppointments",
                table: "ToDoAppointments",
                column: "ToDoAppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoAppointments",
                table: "ToDoAppointments");

            migrationBuilder.RenameTable(
                name: "ToDoAppointments",
                newName: "Appointments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "ToDoAppointmentId");
        }
    }
}
