using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class Donor
    {
        [Key]
        public int DonorId { get; set; }
        [StringLength(50)]
        public string? Company { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Phone]

        public string? Phone { get; set; }
        [EmailAddress]
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(30)]
        public string? StreetAddress { get; set; }
        [StringLength(30)]
        public string? City { get; set; }
        [StringLength(30)]
        public string? State { get; set; }
        [StringLength(10)]
        public string? Zip { get; set; }

        public bool Active { get; set; }
        //navigation properties
        //1 donor has many donations
        public ICollection<Donation> Donations { get; set; }
    }
}
