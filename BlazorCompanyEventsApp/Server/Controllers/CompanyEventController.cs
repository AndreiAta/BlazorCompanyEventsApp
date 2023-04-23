using BlazorCompanyEventsApp.Shared;
using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCompanyEventsApp.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyEventController : ControllerBase
{
    private readonly ILogger<CompanyEventController> _logger;
    private readonly ICompanyEventRepository _companyEventRepository;

    public CompanyEventController(ICompanyEventRepository companyEventRepository, ILogger<CompanyEventController> logger)
    {
        _logger = logger;
        _companyEventRepository = companyEventRepository;
    }

    [HttpGet]
    public async Task<IReadOnlyCollection<CompanyEvent>> GetAll()
    {
        return await _companyEventRepository.GetCompanyEvents();
    }
}
