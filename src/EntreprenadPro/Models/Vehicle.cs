using System.ComponentModel.DataAnnotations;

namespace EntreprenadPro.Models;

public enum VehicleType
{
    [Display(Name = "Bil")] Car,
    [Display(Name = "Lastbil")] Truck,
    [Display(Name = "Lastmaskin")] Loader,
    [Display(Name = "Hjulgrävare")] WheeledExcavator,
    [Display(Name = "Bandgrävare")] CrawlerExcavator,
    [Display(Name = "Traktor")] Tractor
}

public class Vehicle
{
    [Key] public string Id { get; set; }

    public VehicleType Type { get; set; }

    [Display(Name = "Registreringsnummer")]
    [MaxLength(10, ErrorMessage = "Registreringsnumret får inte vara längre än 10 tecken")]
    public string? RegistrationNumber { get; set; }

    [Display(Name = "Märke")] public string? Make { get; set; }

    [Display(Name = "Modell")] public string? Model { get; set; }

    [Display(Name = "Årsmodell")] public int? Year { get; set; }

    [Display(Name = "Inköpspris(SEK)")] public decimal? PurchasePrice { get; set; }

    [Display(Name = "Inköpsdatum")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? PurchaseDate { get; set; }

    [Display(Name = "Anteckning")] public string? Note { get; set; }
}

public record AddVehicleDto
{
    [Required]
    [Display(Name = "Fordonstyp")]
    public VehicleType Type { get; set; }

    [Display(Name = "Registreringsnummer")]
    [MaxLength(10, ErrorMessage = "Registreringsnumret får inte vara längre än 10 tecken")]
    public string? RegistrationNumber { get; set; }

    [Display(Name = "Märke")] public string? Make { get; set; }

    [Display(Name = "Modell")] public string? Model { get; set; }

    [Display(Name = "Årsmodell")] public int? Year { get; set; }

    [Display(Name = "Inköpspris(SEK)")] public decimal? PurchasePrice { get; set; }

    [Display(Name = "Inköpsdatum")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? PurchaseDate { get; set; }

    [Display(Name = "Anteckning")] public string? Note { get; set; }
}

public record EditVehicleDto
{
    [Required] public string Id { get; set; }

    [Required]
    [Display(Name = "Fordonstyp")]
    public VehicleType Type { get; set; }

    [Display(Name = "Registreringsnummer")]
    [MaxLength(10, ErrorMessage = "Registreringsnumret får inte vara längre än 10 tecken")]
    public string? RegistrationNumber { get; set; }

    [Display(Name = "Märke")] public string? Make { get; set; }

    [Display(Name = "Modell")] public string? Model { get; set; }

    [Display(Name = "Årsmodell")] public int? Year { get; set; }

    [Display(Name = "Inköpspris(SEK)")] public decimal? PurchasePrice { get; set; }

    [Display(Name = "Inköpsdatum")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? PurchaseDate { get; set; }

    [Display(Name = "Anteckning")] public string? Note { get; set; }
}