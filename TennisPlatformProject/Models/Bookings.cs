using System.ComponentModel.DataAnnotations;

namespace TennisPlatformProject.Models
{
    public class Bookings
    {
        public int Id { get; set; }

        public int BookingID { get; set; }

        [Required(ErrorMessage = "First Name is required!")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Range(5, 100, ErrorMessage = "Email is required!")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Time is required!")]
        [Display(Name = "Data Time")]
        public DateTime DateTime { get; set; }
    }
}
