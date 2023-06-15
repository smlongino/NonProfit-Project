using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class Channel
    {
        [Key]
        public int ChannelId { get; set; }
        [Required(ErrorMessage = "Channel Type Required")]
        [StringLength(50, ErrorMessage = "Exceeds 50 character limit")]
        [Display(Name ="Channel Type")]
        public string ChannelType { get; set; }
        public bool Active { get; set; }

        //navigation property
        //a channel can be related to more than 1 donation and FundraiserChannels
        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<FundraiserChannel> FundraiserChannels { get; set; }
    }
}
