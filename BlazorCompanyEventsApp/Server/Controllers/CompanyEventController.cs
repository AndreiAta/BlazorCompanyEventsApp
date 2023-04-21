using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCompanyEventsApp.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyEventController : ControllerBase
{
    private readonly ILogger<CompanyEventController> _logger;

    public CompanyEventController(ILogger<CompanyEventController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IReadOnlyCollection<CompanyEvent>> GetAll()
    {
        return null;
    }
}
