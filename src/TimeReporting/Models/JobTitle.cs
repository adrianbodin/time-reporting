namespace TimeReporting.Models;

public class JobTitle
{
    public string Id { get; set; }
    public string Name { get; set; }

    public ICollection<Employee> Employees { get; set; } = [];
}