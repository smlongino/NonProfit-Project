using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NonProfitApp.ViewModels
{
    public class DonorCreateVM
    {
        [Key]
        public int DonorId { get; set; }
        [StringLength(50)]
        [Display(Name = "Company")]
        public string? Company { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Phone]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }
        [EmailAddress]
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(30)]
        [Display(Name = "Street Address")]
        public string? StreetAddress { get; set; }
        [StringLength(30)]
        public string? City { get; set; }
        [StringLength(30)]
        public string? State { get; set; }
        [StringLength(10)]
        [Display(Name = "Zip Code")]
        public string? Zip { get; set; }
        public bool Active { get; set; }
        [StringLength(100)]
        public string ImageLocation { get; set; }
        [Display(Name ="Upload Donor Picture")]
        public IFormFile DonorImage { get; set; }
    }
}
