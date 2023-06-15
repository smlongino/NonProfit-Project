using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class OrgProgram
    {
        [Key]
        public int ProgramId { get; set; }
        [Required(ErrorMessage = "Program Name Required")]
        [StringLength(50,ErrorMessage = "Exceeds 50 character limit")]
        [Display(Name = "Program Name")]
        public string Name { get; set; }
        public bool Active { get; set; }

        //navigation property
        //a program can be asscoiated with more than 1 donation
        public IEnumerable<Donation> Donations { get; set; }
        public IEnumerable<FundraiserProgram> FundraiserPrograms { get; set; }
    }
}
