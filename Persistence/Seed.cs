using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context) 
        {
            if(context.Activities.Any()) return;
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 monthes ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub"
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 monthes ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in thew future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Natural History Museum"
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 monthes in the future",
                    Category = "music",
                    City = "London",
                    Venue = "02 Arena"
                },
                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 monthes in the future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub"
                },
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 monthes in the future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub"
                }
            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}