using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCompanyEventsApp.Server.Data;

public class ParticipantRepository : IParticipantRepository
{
    private readonly DataContext _companyEventContext;

    public ParticipantRepository(DataContext companyEventContext)
    {
        _companyEventContext = companyEventContext;
    }

    public Task CreateParticipant(Participant participant)
    {
        _companyEventContext.Participants.Add(participant);
        return Task.CompletedTask;
    }

    public async Task<Participant?> GetParticipantByEmail(string email)
    {
        return await _companyEventContext.Participants.Where(p => p.Email == email).FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyCollection<Participant>> GetParticipantsByCompanyEventId(int companyEventId)
    {
        return await _companyEventContext.Participants.Where(p => p.CompanyEventId == companyEventId).ToArrayAsync();
    }

    public async Task UpdateParticipant(Participant participant)
    {
        _companyEventContext.Entry(participant).State = EntityState.Modified;
    }
}
