using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class FundraiserChannel
    {

        [Key]
        public int FundraiserChannelId { get; set; }

        public int ChannelId { get; set; }

        public int FundraiserId { get; set; }
        //nav props
        public Channel Channel { get; set; }
        public Fundraiser Fundraiser { get; set; }
    }
}
