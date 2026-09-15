using MediatR;
using Microsoft.EntityFrameworkCore;
using WebMedApp.Data;
using WebMedApp.Dtos;

namespace WebMedApp.Features.Student.Queries.GetAllStudents;

public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, IReadOnlyList<StudentResponseDto>>
{
    private readonly AppDbContext _context;
    public GetAllStudentsQueryHandler(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IReadOnlyList<StudentResponseDto>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
    {
        var students =await _context.Students.AsNoTracking().Select(student => new StudentResponseDto
        {
            Id = student.Id,
            Name = student.Name,
            Email = student.Email
        })
        .ToListAsync(cancellationToken);
        return students;
    }
}
