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

    [HttpGet("{id}")]
    public async Task<IReadOnlyCollection<Participant>> GetParticipantsForEvent(int id)
    {
        return await _participantRepository.GetParticipantsByCompanyEventId(id);
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
