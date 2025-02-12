using Bogus;
using Microsoft.AspNetCore.Identity;
using TimeReporting.Models;

namespace TimeReporting.Data;

public class DatabaseSeeder
{
    public List<Employee> Employees { get; set; } = [];
    public List<Customer> Customers { get; set; } = [];
    public List<Project> Projects { get; set; } = [];
    public List<WorkType> WorkTypes { get; set; } = [];
    public List<TimeEntry> TimeEntries { get; set; } = [];

    public DatabaseSeeder()
    {
        Employees = GenerateEmployees(amount: 20);
        Customers = GenerateCustomers(amount: 10);
        WorkTypes = GenerateWorkTypes(amount: 10);
        Projects = GenerateProjects(amount: 20, Customers);
        TimeEntries = GenerateTimeEntries(amount: 300, Employees, Projects, WorkTypes);
    }

    private List<Employee> GenerateEmployees(int amount)
    {
        List<string> jobTitles = ["Software Engineer", "Designer", "Administrator", "Manager", "IT-Support", "IT-Technician"];
        const string employeePassword = "Admin123!";

        var employeeFaker = new Faker<Employee>()
            .RuleFor(e => e.Id, f => f.Random.Guid().ToString())
            .RuleFor(e => e.FullName, f => f.Person.FullName)
            .RuleFor(e => e.PhoneNumber, f => f.Person.Phone)
            .RuleFor(e => e.HireDate, f => DateOnly.FromDateTime(f.Date.Past(10)))
            .RuleFor(e => e.Email, f => f.Person.Email)
            .RuleFor(e => e.NormalizedEmail, (f, e) => e.Email.ToUpper())
            .RuleFor(e => e.EmailConfirmed, true)
            .RuleFor(e => e.UserName, (f, e) => e.Email)
            .RuleFor(e => e.NormalizedUserName, (f, e) => e.Email.ToUpper())
            .RuleFor(e => e.PhoneNumber, f => f.Person.Phone)
            .RuleFor(e => e.ConcurrencyStamp, f => f.Random.Guid().ToString())
            .RuleFor(e => e.SecurityStamp, f => f.Random.Guid().ToString("D"))
            .RuleFor(e => e.PhoneNumberConfirmed, false)
            .RuleFor(e => e.TwoFactorEnabled, false)
            .RuleFor(e => e.LockoutEnd, (DateTimeOffset?)null)
            .RuleFor(e => e.LockoutEnabled, true)
            .RuleFor(e => e.AccessFailedCount, 0)
            .RuleFor(e => e.JobTitle, e => e.PickRandom(jobTitles))
            .RuleFor(e => e.PasswordHash, new PasswordHasher<Employee>().HashPassword(null!, employeePassword));

        var employees = Enumerable.Range(1, amount)
            .Select(i => SeedRow(employeeFaker, i))
            .ToList();

        return employees;
    }

    private List<Customer> GenerateCustomers(int amount)
    {
        var customerFaker = new Faker<Customer>()
            .RuleFor(c => c.Id, f => f.Random.Guid().ToString())
            .RuleFor(c => c.Name, f => f.Company.CompanyName());

        var customers = Enumerable.Range(1, amount)
            .Select(i => SeedRow(customerFaker, i))
            .ToList();

        return customers;
    }

    private List<WorkType> GenerateWorkTypes(int amount)
    {
        List<string> workTypeNames = [
            "Development",
            "Code Review",
            "Testing",
            "Documentation",
            "Project Management",
            "Client Meeting",
            "Technical Consultation",
            "UI/UX Design",
            "DevOps",
            "Bug Fixing",
            "Requirements Analysis",
            "Training",
            "System Architecture",
            "Database Administration",
            "Support"
        ];

        var workTypeFaker = new Faker<WorkType>()
            .RuleFor(w => w.Id, f => f.Random.Guid().ToString())
            .RuleFor(w => w.Name, f => f.PickRandom(workTypeNames))
            .RuleFor(w => w.HourlyRate, f => f.Random.Int(50, 150));

        var workTypes = Enumerable.Range(1, amount)
            .Select(i => SeedRow(workTypeFaker, i))
            .ToList();

        return workTypes;
    }

    private List<Project> GenerateProjects(int amount, List<Customer> customers)
    {
        var projectFaker = new Faker<Project>()
            .RuleFor(p => p.Id, f => f.Random.Guid().ToString())
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.CustomerId, f => f.PickRandom(customers).Id);


        var projects = Enumerable.Range(1, amount)
            .Select(i => SeedRow(projectFaker, i))
            .ToList();

        return projects;
    }

    private List<TimeEntry> GenerateTimeEntries(int amount, List<Employee> employees, List<Project> projects, List<WorkType> workTypes)
    {

        var timeEntryFaker = new Faker<TimeEntry>()
            .RuleFor(t => t.Id, f => f.Random.Guid().ToString())
            .RuleFor(t => t.EmployeeId, f => f.PickRandom(employees).Id)
            .RuleFor(t => t.ProjectId, f => f.PickRandom(projects).Id)
            .RuleFor(t => t.WorkTypeId, f => f.PickRandom(workTypes).Id)
            .RuleFor(t => t.Hours, f => f.Random.Int(1, 16) / 2.0)
            .RuleFor(t => t.Date, f => DateOnly.FromDateTime(f.Date.Between(DateTime.Now.AddDays(-2), DateTime.Now.AddDays(7))))
            .RuleFor(t => t.Description, f => f.Lorem.Sentence(10))
            .RuleFor(t => t.HourlyRate, f => f.Random.Int(50, 150));

        var timeEntries = Enumerable.Range(1, amount)
            .Select(i => SeedRow(timeEntryFaker, i))
            .ToList();

        return timeEntries;
    }

    private static T SeedRow<T>(Faker<T> faker, int rowId) where T : class
    {
        var recordRow = faker.UseSeed(rowId).Generate();
        return recordRow;
    }

}