using System.ComponentModel.DataAnnotations;

namespace Session26_validation_component_razor.Models;

public class CourseRegistrationModel
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

    [Required(ErrorMessage = "Please select a course")]
    [RegularExpression(@"^(?!Choose\.\.\.).*$", ErrorMessage = "Please select a valid course")]
    public string SelectedCourse { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a study mode")]
    public string StudyMode { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a start date")]
    public DateTime? StartDate { get; set; }

    public string? Comments { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
    public bool Agree { get; set; } = false;
}
