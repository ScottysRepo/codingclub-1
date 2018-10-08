using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CodingClubTest.Models
{
    
    public static class SeedData
    {
        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodingClubDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<CodingClubDbContext>>()))
                {
                    if(context.Member.Any())
                    {
                        return; //DB has been seeded
                    }
                    context.Member.AddRange(
                        new Member
                        {
                            ID = "1",
                            Email = "123@wtamu.edu"
                        }
                    );
                    context.SaveChanges();
                }

        }
    }
}