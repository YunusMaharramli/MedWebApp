namespace WebMedApp.Dtos;

public class StudentResponseDto
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Email { get; set; }
}
