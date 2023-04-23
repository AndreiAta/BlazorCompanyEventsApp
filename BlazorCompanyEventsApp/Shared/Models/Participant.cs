using System.ComponentModel.DataAnnotations;

namespace BlazorCompanyEventsApp.Shared.Models;

[Serializable]
public class Participant
{
    public Participant()
    {
        
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public int CompanyEventId { get; set; }
}
