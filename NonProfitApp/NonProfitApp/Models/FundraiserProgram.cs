using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NonProfitApp.Models
{
    public class FundraiserProgram
    {
        [Key]
        public int FundraiserProgramId { get; set; }

        public int ProgramId { get; set; }

        public int FundraiserId { get; set; }
        //nav prop
        public OrgProgram OrgProgram { get; set; }
        public Fundraiser Fundraiser { get; set; }
    }
}
