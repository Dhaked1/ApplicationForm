using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationFormApp.Models
{
    public class ApplicationForm
    {
        public int Id { get; set; }

        // ===== PERSONAL DETAILS =====

        [Required]
        [StringLength(12, ErrorMessage = "Name cannot exceed 12 characters")]
        public string? FullName { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter exactly 10 digits")]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? CountryCode { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string? Email { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DOB.Year;
                if (DOB.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        // ===== QUALIFICATION =====

        [Required]
        public string? Degree { get; set; }

        [Required]
        public string? Branch { get; set; }

        [Range(0, 100)]
        public double? Percentage { get; set; }

        public string? OtherDetails { get; set; }


        // ===== ADDRESS (Relational) =====
        // ===== ADDRESS =====

        [Required]
        public string? Country { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Enter valid 6 digit pincode")]
        public string? Pincode { get; set; }

        public string? District { get; set; }

        [Required]
        public string? StreetAddress { get; set; }

    }
}
