using Microsoft.EntityFrameworkCore;

namespace TodoApi.Model;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
    {
    }
    public DbSet<ToDoAppointment>? ToDoAppointments { get; set; }
}