using System.ComponentModel.DataAnnotations;

namespace EntreprenadPro.Models;

public enum CustomerType
{
    [Display(Name = "Privat")] Private,
    [Display(Name = "Företag")] Company
}

public class Customer
{
    [Key] public string Id { get; set; }

    [Required(ErrorMessage = "Namn är obligatoriskt")]
    public string Name { get; set; }

    [Display(Name = "Organisationsnummer")]
    [RegularExpression(@"^\d{6}-?\d{4}$",
        ErrorMessage = "Organisationsnumret måste vara i formatet XXXXXX-XXXX eller XXXXXXXXXX")]
    public string? OrgNumber { get; set; }

    [Display(Name = "Telefonnummer")]
    [RegularExpression(@"^(?:\+46|0)[\s\d]{8,13}$", ErrorMessage = "Ogiltigt svenskt telefonnummer")]
    public string? PhoneNumber { get; set; }

    [EmailAddress(ErrorMessage = "Ogiltig e-postadress")]
    public string? Email { get; set; }

    public CustomerType Type { get; set; }

    public ICollection<Project> Projects { get; set; } = [];
}