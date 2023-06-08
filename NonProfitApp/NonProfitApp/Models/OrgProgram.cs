using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class OrgProgram
    {
        [Key]
        public int ProgramId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Program Name")]
        public string Name { get; set; }

        //navigation property
        //a program can be asscoiated with more than 1 donation
        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<FundraiserProgram> FundraiserPrograms { get; set; }
    }
}
