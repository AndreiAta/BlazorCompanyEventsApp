
using BlazorCompanyEventsApp.Shared.Models;

namespace BlazorCompanyEventsApp.Shared;
public interface ICompanyEventRepository
{
    Task<IReadOnlyCollection<CompanyEvent>> GetCompanyEvents();

    Task<CompanyEvent> GetCompanyEventById(int id);

    void UpdateCompanyEvent(CompanyEvent companyEvent);
}
