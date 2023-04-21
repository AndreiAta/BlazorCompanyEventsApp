using BlazorCompanyEventsApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCompanyEventsApp.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyEventController : ControllerBase
{
    [HttpGet]
    public async Task<IReadOnlyCollection<CompanyEvent>> GetAll()
    {

    }
}
