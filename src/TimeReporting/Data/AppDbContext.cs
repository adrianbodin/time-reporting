using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Models;

namespace TimeReporting.Data;

public class AppDbContext : IdentityDbContext<Employee>
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<TimeEntry> TimeEntries { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Customer>()
            .HasMany(c => c.TimeEntries)
            .WithOne(c => c.Customer)
            .HasForeignKey(c => c.CustomerId);

        modelBuilder.Entity<TimeEntry>()
            .HasKey(t => t.Id);

        modelBuilder.Entity<TimeEntry>()
            .HasOne(t => t.Customer)
            .WithMany(t => t.TimeEntries)
            .HasForeignKey(t => t.CustomerId);

        modelBuilder.Entity<TimeEntry>()
            .HasOne(t => t.Employee)
            .WithMany(t => t.TimeEntries)
            .HasForeignKey(t => t.EmployeeId);

        modelBuilder.Entity<TimeEntry>()
            .Property(t => t.Hours)
            .HasMaxLength(100);

        modelBuilder.Entity<TimeEntry>()
            .Property(t => t.Description)
            .HasMaxLength(500);

        modelBuilder.Entity<Employee>()
            .Property(e => e.FirstName)
            .HasMaxLength(50);

        modelBuilder.Entity<Employee>()
            .Property(e => e.LastName)
            .HasMaxLength(50);

        modelBuilder.Entity<Employee>()
            .HasMany(e => e.TimeEntries)
            .WithOne(t => t.Employee)
            .HasForeignKey(t => t.EmployeeId);
    }
}