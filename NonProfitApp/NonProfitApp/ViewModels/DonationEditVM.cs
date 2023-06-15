using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using NonProfitApp.Models;

namespace NonProfitApp.ViewModels
{
    public class DonationEditVM
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
        public int? FundraiserId { get; set; }
        [ForeignKey("Channel")]
        [Display(Name = "Channel Id")]
        public int? ChannelId { get; set; }
        [ForeignKey("OrgProgram")]
        [Display(Name = "Program Id")]
        public int? ProgramId { get; set; }
        public Donor Donor { get; set; }

        public IEnumerable<SelectListItem> DonorList { get; set; }
        public IEnumerable<SelectListItem> ChannelList { get; set; }
        public IEnumerable<SelectListItem> ProgramList { get; set; }
        public IEnumerable<SelectListItem> FundraiserList { get; set; }
    }
}
