using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class Donor
    {
        [Key]
        public int DonorId { get; set; }
        [StringLength(50)]
        [Display(Name = "Company")]
        public string? Company { get; set; }
        [Required(ErrorMessage = "First Name Required")]
        [StringLength(30, ErrorMessage = "Exceeds 30 character limit")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        [StringLength(30, ErrorMessage = "Exceeds 30 character limit")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Phone]
        [Display(Name = "Phone Number")]
        [StringLength(14, ErrorMessage = "Exceeds 14 character limit")]
        public string? Phone { get; set; }
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Exceeds 50 character limit")]
        public string? Email { get; set; }
        [StringLength(30, ErrorMessage = "Exceeds 30 character limit")]
        [Display(Name = "Street Address")]
        public string? StreetAddress { get; set; }
        [StringLength(30, ErrorMessage = "Exceeds 30 character limit")]
        public string? City { get; set; }
        [StringLength(30, ErrorMessage = "Exceeds 30 character limit")]
        public string? State { get; set; }
        [StringLength(10, ErrorMessage = "Exceeds 10 character limit")]
        [Display(Name = "Zip Code")]
        public string? Zip { get; set; }
        public bool Active { get; set; }

        //navigation properties
        //1 donor has many donations
        public IEnumerable<Donation> Donations { get; set; }
    }
}
