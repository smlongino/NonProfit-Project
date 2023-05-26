using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class Fundraiser
    {
        [Key]
        public int FundraiserId { get; set; }
        [Required]
        [StringLength(50)]
        public string FundraiserName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        //nav props
        //a fundraiser can be related to more than 1 Donation and FundraiserChannels
        public ICollection<Donation> Donations { get; set; }
        public ICollection<FundraiserChannel> FundraiserChannels { get; set; }
        public ICollection<FundraiserProgram> FundraiserPrograms { get; set; }
    }
}
