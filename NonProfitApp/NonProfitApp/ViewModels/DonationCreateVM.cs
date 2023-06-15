using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NonProfitApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NonProfitApp.ViewModels
{
    public class DonationCreateVM
    {
        [Key]
        public int DonationId { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, int.MaxValue)]
        [Display(Name = "Donation Amount")]
        public decimal DonationAmount { get; set; }
        [Required]
        [Display(Name = "Donation Date")]
        public DateTime DonationDate { get; set; }
        [ForeignKey("Donor")]
        [Display(Name = "Donor Name")]
        public int DonorId { get; set; }
        [ForeignKey("Fundraiser")]
        [Display(Name = "Fundraiser Name")]
        public int? FundraiserId { get; set; }
        [ForeignKey("Channel")]
        [Display(Name = "Channel Type")]
        public int ChannelId { get; set; }
        [ForeignKey("OrgProgram")]
        [Display(Name = "Program")]
        public int ProgramId { get; set; }

        public Donor Donor { get; set; }
        public IEnumerable<SelectListItem> DonorList { get; set; }
        public IEnumerable<SelectListItem> ChannelList { get; set; }
        public IEnumerable<SelectListItem> ProgramList { get; set; }
        public IEnumerable<SelectListItem> FundraiserList { get; set; }

    }
}
