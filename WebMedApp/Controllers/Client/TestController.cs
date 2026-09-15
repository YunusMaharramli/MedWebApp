using Microsoft.AspNetCore.Mvc;

namespace WebMedApp.Controllers.Client;

public class TestController : ClientApiController
{
    [HttpGet]
    [ProducesResponseType<TestEndpointResponse>(StatusCodes.Status200OK)]
    public ActionResult<TestEndpointResponse> Get()
    {
        return Ok(new TestEndpointResponse(
            Api: "Client",
            Version: "v1",
            Message: "Client API is working.",
            TimestampUtc: DateTimeOffset.UtcNow));
    }
}
