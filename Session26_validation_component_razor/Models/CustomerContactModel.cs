using System.ComponentModel.DataAnnotations;

namespace Session26_validation_component_razor.Models;

public class CustomerContactModel
{
    [Required(ErrorMessage = "Please input Full Name")]
    [MinLength(3, ErrorMessage = "Full Name must be at least 3 characters long")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Phone Number")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits")]
    public string PhoneNumber { get; set; } = string.Empty;

    [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Message")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters long")]
    public string Message { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a service")]
    [RegularExpression(@"^(?!Choose\.\.\.).*$", ErrorMessage = "Please select a valid service")]
    public string Services { get; set; } = string.Empty;

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
    public bool Agree { get; set; } = false;
}
