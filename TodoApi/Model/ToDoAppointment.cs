namespace TodoApi.Model;


public class ToDoAppointment
{

    public uint ToDoAppointmentId { get; set; }
    public string? CustomerNm { get; set; }
    public int? Contact { get; set; }
    public string? Details { get; set; }
    public DateTime? AppointmentDateTime { get; set; }
    public bool IsConfirmed { get; set; } = false;
    public string? Comments { get; set; }
}