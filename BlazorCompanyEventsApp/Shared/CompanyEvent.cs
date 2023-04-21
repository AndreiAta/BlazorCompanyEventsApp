﻿using System.ComponentModel.DataAnnotations;

namespace BlazorCompanyEventsApp.Shared;

[Serializable]
public class CompanyEvent
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public DateTime DateAndTime { get; set; }

    public IReadOnlyCollection<Participant> Participants { get; set; }
}
