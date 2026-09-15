using Microsoft.AspNetCore.Mvc;

namespace WebMedApp.Controllers.Admin;

public class TestController : AdminApiController
{
    [HttpGet]
    [ProducesResponseType<TestEndpointResponse>(StatusCodes.Status200OK)]
    public ActionResult<TestEndpointResponse> Get()
    {
        return Ok(new TestEndpointResponse(
            Api: "Admin",
            Version: "v1",
            Message: "Admin API is working.",
            TimestampUtc: DateTimeOffset.UtcNow));
    }
}
