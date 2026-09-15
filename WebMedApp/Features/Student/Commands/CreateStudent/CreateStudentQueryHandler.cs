using MediatR;
using Microsoft.EntityFrameworkCore;
using WebMedApp.Data;
using WebMedApp.Dtos;

namespace WebMedApp.Features.Student.Commands.CreateStudent;

public class CreateStudentQueryHandler : IRequestHandler<CreateStudentQuery, StudentResponseDto>
{
    private readonly AppDbContext _context;
    public CreateStudentQueryHandler(AppDbContext context)
    {
        _context = context;
    }
    public async Task<StudentResponseDto> Handle(CreateStudentQuery request, CancellationToken cancellationToken)
    {

        var stu = new WebMedApp.Entities.Student
        {
            Name = request.Name,
            Surname = request.Surname,
            Email = request.Email
        };

        await _context.Students.AddAsync(stu);

        await _context.SaveChangesAsync();
        return new StudentResponseDto
        {
            Id = stu.Id,
            Name= stu.Name,
            Email = stu.Email
        };
   
    }
}
