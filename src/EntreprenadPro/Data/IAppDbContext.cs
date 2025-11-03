using EntreprenadPro.Models;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Data;

public interface IAppDbContext
{
    DbSet<Customer> Customers { get; set; }
    DbSet<TimeEntry> TimeEntries { get; set; }
    DbSet<Project> Projects { get; set; }
    DbSet<WorkType> WorkTypes { get; set; }
    DbSet<Employee> Users { get; set; }
    DbSet<Vehicle> Vehicles { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}