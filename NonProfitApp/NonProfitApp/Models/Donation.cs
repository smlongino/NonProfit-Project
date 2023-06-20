using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NonProfitApp.Models
{
    public class Donation
    {
        [Key]
        public int DonationId { get; set; }
        [Required(ErrorMessage = "Donation Amount Required")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, int.MaxValue)]
        [Display(Name = "Donation Amount")]
        public decimal DonationAmount { get; set; }
        [Required(ErrorMessage = "Donation Date Required")]
        [Display(Name = "Donation Date")]
        public DateTime DonationDate { get; set; }
        [Required(ErrorMessage = "Donor Required")]
        [ForeignKey("Donor")]
        [Display(Name = "Donor Id")]
        public int DonorId { get; set; }
        [Display(Name = "Fundraiser Id")]
        public int? FundraiserId { get; set; }
        [Display(Name = "Channel Id")]
        public int? ChannelId { get; set; }
        [Display(Name = "Program Id")]
        public int? ProgramId { get; set; }

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
