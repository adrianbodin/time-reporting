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
    [MaxLength(100, ErrorMessage = "Namnet får inte vara längre än 100 tecken")]
    [Display(Name = "Namn")]
    public string Name { get; set; }

    [Display(Name = "Organisationsnummer")]
    [RegularExpression(@"^\d{6}-?\d{4}$",
        ErrorMessage = "Organisationsnumret måste vara i formatet XXXXXX-XXXX eller XXXXXXXXXX")]
    [MaxLength(13, ErrorMessage = "Organisationsnumret får inte vara längre än 13 tecken")]
    public string? OrgNumber { get; set; }

    [Display(Name = "Telefonnummer")]
    [RegularExpression(@"^(?:\+46|0)[\s\d]{8,13}$", ErrorMessage = "Ogiltigt svenskt telefonnummer")]
    [MaxLength(13, ErrorMessage = "Telefonnumret får inte vara längre än 13 tecken")]
    public string? PhoneNumber { get; set; }

    [MaxLength(200, ErrorMessage = "Adressen får inte vara längre än 200 tecken")]
    [Display(Name = "Adress")]
    public string? Address { get; set; }

    [MaxLength(200, ErrorMessage = "Faktureringsadressen får inte vara längre än 200 tecken")]
    [Display(Name = "Faktureringsadress")]
    public string? BillingAddress { get; set; }

    [MaxLength(100, ErrorMessage = "Postkoden får inte vara längre än 100 tecken")]
    [Display(Name = "Postkod")]
    public string? PostalCode { get; set; }

    [MaxLength(100, ErrorMessage = "Staden får inte vara längre än 100 tecken")]
    [Display(Name = "Stad")]
    public string? City { get; set; }

    [EmailAddress(ErrorMessage = "Ogiltig e-postadress")]
    [MaxLength(100, ErrorMessage = "E-postadressen får inte vara längre än 100 tecken")]
    [Display(Name = "E-postadress")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Kundtyp är obligatoriskt")]
    [Display(Name = "Kundtyp")]
    public CustomerType Type { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Project> Projects { get; set; } = [];
}