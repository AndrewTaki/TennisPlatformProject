using Microsoft.EntityFrameworkCore;
using TennisPlatformProject.Data;

namespace TennisPlatformProject.Models
{
    public class SeedData
    {
        // Method to initialize and seed data into the database
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TennisPlatformProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TennisPlatformProjectContext>>()))
            {
                if (context == null || context.ClubMembers == null)
                {
                    throw new ArgumentNullException("Null TennisPlatformProjectContext");
                }

                if (context.ClubMembers.Any())
                {
                    return;
                }
                // Sample data for ClubMembers
                context.ClubMembers.AddRange(
                    new ClubMembers
                    {

                        FirstName = "Nicky",
                        LastName = "Lee",
                        Gender = "Male",
                        MobilNumber = 0873334444,
                        Email = "nicky@example.com"
                    },

                    new ClubMembers
                    {

                        FirstName = "Emma",
                        LastName = "Flynn",
                        Gender = "Female",
                        MobilNumber = 0872224444,
                        Email = "emma@example.com"
                    },

                    new ClubMembers
                    {

                        FirstName = "Gary",
                        LastName = "Thomson",
                        Gender = "Male",
                        MobilNumber = 0875559999,
                        Email = "gary@example.com"
                    },

                    new ClubMembers
                    {

                        FirstName = "Derek",
                        LastName = "Boyd",
                        Gender = "Male",
                        MobilNumber = 0871115555,
                        Email = "derek@example.com"
                    },

                    new ClubMembers
                    {

                        FirstName = "Andrew",
                        LastName = "Lake",
                        Gender = "Male",
                        MobilNumber = 0872345655,
                        Email = "andrew@example.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }

}
