using System.ComponentModel.DataAnnotations;

namespace BlazorCompanyEventsApp.Shared;

[Serializable]
public class Participant
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string PhoneNumber { get; set; }
}
