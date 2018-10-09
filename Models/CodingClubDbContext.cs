using Microsoft.EntityFrameworkCore;

namespace CodingClubTest.Models
{

    public class CodingClubDbContext : DbContext
    {
        public CodingClubDbContext (DbContextOptions<CodingClubDbContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }
        public DbSet<Organization> Organization {get; set;}
    }
}