
using BlazorCompanyEventsApp.Shared.Models;

namespace BlazorCompanyEventsApp.Shared;
public interface ICompanyEventRepository
{
    Task<IEnumerable<CompanyEvent>> GetCompanyEvents();

    Task<CompanyEvent> GetCompanyEventById(int id);

    Task<CompanyEvent> UpdateCompanyEvent(CompanyEvent companyEvent);
}
