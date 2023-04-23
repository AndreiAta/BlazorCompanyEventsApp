using BlazorCompanyEventsApp.Shared.Models;

namespace BlazorCompanyEventsApp.Server.Data;

public interface IParticipantRepository
{
    Task CreateParticipant(Participant participant);

    Task<IReadOnlyCollection<Participant>> GetParticipantsByCompanyEventId(int companyEventId);

    Task UpdateParticipant(Participant participant);
}