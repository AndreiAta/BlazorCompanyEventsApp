using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCompanyEventsApp.Server.Data;

public class CompanyEventContext : DbContext
{
    public CompanyEventContext(DbContextOptions<CompanyEventContext> options) : base(options)
    {
        
    }

    public DbSet<CompanyEvent> CompanyEvents { get; set; }
}
