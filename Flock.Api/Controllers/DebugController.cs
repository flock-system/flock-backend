using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DebugController : ControllerBase
{
    [HttpGet("tenant")]
    [Authorize]
    public IActionResult GetTenant()
    {
        var tenantId = User.FindFirst("TenantId")?.Value;

        return Ok(new
        {
            TenantId = tenantId
        });
    }
}