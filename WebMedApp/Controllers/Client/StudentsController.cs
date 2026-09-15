using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebMedApp.Features.Student.Commands.CreateStudent;
using WebMedApp.Features.Student.Queries;
using WebMedApp.Features.Student.Queries.GetAllStudents;

namespace WebMedApp.Controllers.Client;

public class StudentsController : ClientApiController
{
    private readonly IMediator _mediatr;
    public StudentsController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var query = new GetAllStudentsQuery();
        var result = await _mediatr.Send(query);
        return Ok(result);
    }

    // GET api/<StudentsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<StudentsController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateStudentQuery request)
    {
        var result = await _mediatr.Send(request);
        return Ok(result);
    }

    // PUT api/<StudentsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<StudentsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
