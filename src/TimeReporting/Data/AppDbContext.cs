using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Models;

namespace TimeReporting.Data;

public class AppDbContext : IdentityDbContext<Employee>
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<TimeEntry> TimeEntries { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<WorkType> WorkTypes { get; set; }
    public DbSet<JobTitle> JobTitles { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Customer>()
            .HasMany(c => c.Projects)
            .WithOne(p => p.Customer)
            .HasForeignKey(p => p.CustomerId);

        modelBuilder.Entity<Project>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Project>()
            .HasMany(p => p.TimeEntries)
            .WithOne(t => t.Project)
            .HasForeignKey(t => t.ProjectId);

        modelBuilder.Entity<TimeEntry>()
            .HasKey(t => t.Id);

        modelBuilder.Entity<TimeEntry>()
            .HasOne(t => t.Project)
            .WithMany(p => p.TimeEntries)
            .HasForeignKey(t => t.ProjectId);

        modelBuilder.Entity<TimeEntry>()
            .HasOne(t => t.Employee)
            .WithMany(e => e.TimeEntries)
            .HasForeignKey(t => t.EmployeeId);

        modelBuilder.Entity<TimeEntry>()
            .HasOne(t => t.WorkType)
            .WithMany(w => w.TimeEntries)
            .HasForeignKey(t => t.WorkTypeId);

        modelBuilder.Entity<TimeEntry>()
            .Property(t => t.Hours)
            .HasMaxLength(100);

        modelBuilder.Entity<TimeEntry>()
            .Property(t => t.Description)
            .HasMaxLength(500);

        modelBuilder.Entity<Employee>()
            .Property(e => e.FullName)
            .HasMaxLength(100);

        modelBuilder.Entity<Employee>()
            .Property(e => e.PhoneNumber)
            .HasMaxLength(20);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.TimeEntries)
            .WithOne(t => t.Employee)
            .HasForeignKey(t => t.EmployeeId);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.JobTitle)
            .WithMany(r => r.Employees)
            .HasForeignKey(e => e.JobTitleId);

        modelBuilder.Entity<JobTitle>()
            .HasKey(r => r.Id);

        modelBuilder.Entity<JobTitle>()
            .HasMany(r => r.Employees)
            .WithOne(e => e.JobTitle)
            .HasForeignKey(e => e.JobTitleId);

        modelBuilder.Entity<WorkType>()
            .HasKey(w => w.Id);

        modelBuilder.Entity<WorkType>()
            .HasMany(w => w.TimeEntries)
            .WithOne(t => t.WorkType)
            .HasForeignKey(t => t.WorkTypeId);
    }
}