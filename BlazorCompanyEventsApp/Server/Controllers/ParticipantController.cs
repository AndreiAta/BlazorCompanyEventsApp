using BlazorCompanyEventsApp.Server.Data;
using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCompanyEventsApp.Server.Controllers;

public class ParticipantController : ControllerBase
{
    private readonly ILogger<CompanyEventController> _logger;
    private readonly IParticipantRepository _participantRepository;

    public ParticipantController(IParticipantRepository participantRepository, ILogger<CompanyEventController> logger)
    {
        _participantRepository = participantRepository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IReadOnlyCollection<Participant>> GetParticipantsForEvent(int companyEventId)
    {
        return await _participantRepository.GetParticipantsByCompanyEventId(companyEventId);
    }

    [HttpPost]
    public async Task CreateParticipant(Participant participant)
    {
        await _participantRepository.CreateParticipant(participant);
    }

    [HttpPut]
    public async Task UpdateParticipant(Participant participant)
    {
        await _participantRepository.UpdateParticipant(participant);
    }
}
