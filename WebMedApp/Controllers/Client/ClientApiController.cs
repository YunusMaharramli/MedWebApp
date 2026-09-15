using Microsoft.AspNetCore.Mvc;
using WebMedApp.OpenApi;

namespace WebMedApp.Controllers.Client;

[ApiController]
[ApiExplorerSettings(GroupName = SwaggerDocumentNames.ClientV1)]
[Route("api/v1/client/[controller]")]
public abstract class ClientApiController : ControllerBase;
