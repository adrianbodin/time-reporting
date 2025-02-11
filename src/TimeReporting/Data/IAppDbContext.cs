using Microsoft.EntityFrameworkCore;
using TimeReporting.Models;

namespace TimeReporting.Data;

public interface IAppDbContext
{
    DbSet<Customer> Customers { get; set; }
    DbSet<TimeEntry> TimeEntries { get; set; }
    DbSet<Project> Projects { get; set; }
    DbSet<WorkType> WorkTypes { get; set; }
    DbSet<EntryTimer> EntryTimers { get; set; }
    DbSet<Employee> Users { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}