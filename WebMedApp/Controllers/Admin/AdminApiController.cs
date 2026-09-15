using Microsoft.AspNetCore.Mvc;
using WebMedApp.OpenApi;

namespace WebMedApp.Controllers.Admin;

[ApiController]
[ApiExplorerSettings(GroupName = SwaggerDocumentNames.AdminV1)]
[Route("api/v1/admin/[controller]")]
public abstract class AdminApiController : ControllerBase;
