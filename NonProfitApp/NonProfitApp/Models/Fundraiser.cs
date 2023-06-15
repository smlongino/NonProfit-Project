using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class Fundraiser
    {
        [Key]
        public int FundraiserId { get; set; }
        [Required(ErrorMessage = "Fundraiser Name Required")]
        [StringLength(50)]
        [Display(Name = "Fundraiser Name")]
        public string FundraiserName { get; set; }
        [Required(ErrorMessage = "Start Date Required")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End Date Required")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }

        //nav props
        //a fundraiser can be related to more than 1 Donation and FundraiserChannels
        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<FundraiserChannel> FundraiserChannels { get; set; }
        public IEnumerable<FundraiserProgram> FundraiserPrograms { get; set; }
    }
}
