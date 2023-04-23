using BlazorCompanyEventsApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCompanyEventsApp.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyEvent>().HasData(
                new CompanyEvent { Id = 1, Name= "Annual Party", Description="Annual party held for the entire company", DateAndTime = new DateTime(2023, 11, 26)},
                new CompanyEvent { Id = 2, Name= "Intro course to React.js", Description="Introduction course to React for beginners", DateAndTime = DateTime.UtcNow},
                new CompanyEvent { Id = 3, Name= "Learning in databases", Description="SQL learning module", DateAndTime = new DateTime(2023, 8, 11)}
            );
    }

    public DbSet<CompanyEvent> CompanyEvents { get; set; }

    public DbSet<Participant> Participants { get; set; }

}
