using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace NonProfitApp.Models
{
    public class Donation
    {
        [Key]
        public int DonationId { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal DonationAmount { get; set; }
        [Required]
        public DateTime DonationDate { get; set; }
        [ForeignKey("Donor")]
        public int DonorId { get; set; }
        [ForeignKey("Fundraiser")]
        public int? FundraiserId { get; set; }
        [ForeignKey("Channel")]
        public int ChannelId { get; set; }
        [ForeignKey("OrgProgram")]
        public int ProgramId { get; set; }

        //nav props
        //A donation is associated with one donor
        public Donor Donor { get; set; }
        //a donation is associated with one Fundraiser
        public Fundraiser Fundraiser { get; set; }
        //a donation is associated with one Channel
        public Channel Channel { get; set; }
        //A donation is associated with one program 
        public OrgProgram OrgProgram { get; set; }
    }
}
