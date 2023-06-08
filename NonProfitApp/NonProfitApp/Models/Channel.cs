using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class Channel
    {
        [Key]
        public int ChannelId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Channel Type")]
        public string ChannelType { get; set; }

        //navigation property
        //a channel can be related to more than 1 donation and FundraiserChannels
        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<FundraiserChannel> FundraiserChannels { get; set; }
    }
}
