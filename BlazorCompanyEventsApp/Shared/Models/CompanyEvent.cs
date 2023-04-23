using System.ComponentModel.DataAnnotations;

namespace BlazorCompanyEventsApp.Shared.Models;

[Serializable]
public class CompanyEvent
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public DateTime DateAndTime { get; set; }

    public List<Participant> Participants { get; set; }
}
