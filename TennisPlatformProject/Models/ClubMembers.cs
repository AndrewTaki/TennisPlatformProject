using System.ComponentModel.DataAnnotations;

namespace TennisPlatformProject.Models
{
    public class ClubMembers
    {
        public int Id { get; set; }

        public int MemberId { get; set; }


        [Required(ErrorMessage = "First Name is required!")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Gender is required!")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Mobile phone number is required!")]
        [Display(Name = "Mobil Number")]
        [Range(0, 9999999999, ErrorMessage = "The Mobile Number must be 10 digits!")]
        public int MobilNumber { get; set; }

        [Range(5, 100, ErrorMessage = "Email is required!")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }
    }
}
