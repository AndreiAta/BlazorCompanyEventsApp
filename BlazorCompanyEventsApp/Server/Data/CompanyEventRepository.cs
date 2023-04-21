using BlazorCompanyEventsApp.Server.Data;
using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCompanyEventsApp.Shared;
public class CompanyEventRepository : ICompanyEventRepository
{
    private readonly CompanyEventContext _companyEventContext;

    public CompanyEventRepository(CompanyEventContext companyEventContext)
    {
        _companyEventContext = companyEventContext;
    }

    public async Task<IEnumerable<CompanyEvent>> GetCompanyEvents()
    {
        return await _companyEventContext.CompanyEvents.ToArrayAsync();
    }

    public async Task<CompanyEvent> GetCompanyEventById(int id)
    {
        throw new NotImplementedException();
    }    

    public async Task<CompanyEvent> UpdateCompanyEvent(CompanyEvent companyEvent)
    {
        throw new NotImplementedException();
    }
}
