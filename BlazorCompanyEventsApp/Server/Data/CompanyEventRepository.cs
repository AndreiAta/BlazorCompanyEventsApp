using BlazorCompanyEventsApp.Server.Data;
using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCompanyEventsApp.Shared;
public class CompanyEventRepository : ICompanyEventRepository
{
    private readonly DataContext _companyEventContext;

    public CompanyEventRepository(DataContext companyEventContext)
    {
        _companyEventContext = companyEventContext;
    }

    public async Task<IReadOnlyCollection<CompanyEvent>> GetCompanyEvents()
    {
        return await _companyEventContext.CompanyEvents.ToArrayAsync();
    }

    public async Task<CompanyEvent> GetCompanyEventById(int id)
    {
        var companyEvent = await _companyEventContext.CompanyEvents.FindAsync(id);
        if (companyEvent == null)
        {
            throw new Exception();
        }

        return companyEvent;
    }    

    public async Task<CompanyEvent> UpdateCompanyEvent(CompanyEvent companyEvent)
    {
        throw new NotImplementedException();

    }
}
