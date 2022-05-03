using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApi.Migrations
{
    public partial class dbn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cont",
                table: "ToDoAppointments",
                newName: "Contact");

            migrationBuilder.RenameColumn(
                name: "Appointment",
                table: "ToDoAppointments",
                newName: "CustomerName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "ToDoAppointments",
                newName: "Appointment");

            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "ToDoAppointments",
                newName: "Cont");
        }
    }
}
