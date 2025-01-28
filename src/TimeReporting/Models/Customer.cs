namespace TimeReporting.Models;

public class Customer
{
    public string Id { get; set; }

    public string Name { get; set; }

    public ICollection<Project> Projects { get; set; } = [];
}