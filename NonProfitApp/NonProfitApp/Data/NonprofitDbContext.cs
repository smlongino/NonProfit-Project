using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NonProfitApp.Models;

namespace NonProfitApp.Data
{
    public class NonprofitDbContext : IdentityDbContext<AppUser>
    {
        public NonprofitDbContext(DbContextOptions<NonprofitDbContext> options)
            : base(options)
        {

        }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<OrgProgram> OrgPrograms { get; set; }
        public DbSet<Fundraiser> Fundraisers { get; set; }
        public DbSet<FundraiserChannel> FundraiserChannels { get; set; }
        public DbSet<FundraiserProgram> FundraiserPrograms { get; set; }
        
    }
}