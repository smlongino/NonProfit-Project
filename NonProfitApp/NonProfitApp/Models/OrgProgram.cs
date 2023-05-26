using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class OrgProgram
    {
        [Key]
        public int ProgramId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        //navigation property
        //a program can be asscoiated with more than 1 donation
        public ICollection<Donation> Donations { get; set; }
        public ICollection<FundraiserProgram> FundraiserPrograms { get; set; }
    }
}
