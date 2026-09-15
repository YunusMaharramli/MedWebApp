using MediatR;
using WebMedApp.Dtos;

namespace WebMedApp.Features.Student.Queries.GetAllStudents;

public record GetAllStudentsQuery : IRequest<IReadOnlyList<StudentResponseDto>>;
