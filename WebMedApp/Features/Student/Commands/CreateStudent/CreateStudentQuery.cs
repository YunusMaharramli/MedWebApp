using MediatR;
using WebMedApp.Dtos;

namespace WebMedApp.Features.Student.Commands.CreateStudent;

public record CreateStudentQuery(string Name, string Surname, string Email) : IRequest<StudentResponseDto>;

