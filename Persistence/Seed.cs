using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async System.Threading.Tasks.Task SeedData(DataContext context)
        {
            if (context.Tasks.Any()) return;

            var tasks = new List<Domain.Task>
            {
                new Domain.Task
                {
                    Title = "Task 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Task one description",
                    Category = "work",
                },
                new Domain.Task
                {
                    Title = "Task 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Task two description",
                    Category = "health",
                },
                new Domain.Task
                {
                    Title = "Task 3",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Task three description",
                    Category = "finance"
                },
                new Domain.Task
                {
                    Title = "Task 4",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Task four description",
                    Category = "errands"
                },
                new Domain.Task
                {
                    Title = "Task 5",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Task five description",
                    Category = "finance"
                },
                new Domain.Task
                {
                    Title = "Task 6",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Task six description",
                    Category = "finance"
                },
                new Domain.Task
                {
                    Title = "Task 7",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Task seven description",
                    Category = "health"
                },
                new Domain.Task
                {
                    Title = "Task 8",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Task eight description",
                    Category = "personal"
                },
                new Domain.Task
                {
                    Title = "Task 9",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Task nine description",
                    Category = "work"
                },
                new Domain.Task
                {
                    Title = "Task 10",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Task ten description",
                    Category = "education"
                }
            };

            await context.Tasks.AddRangeAsync(tasks);
            await context.SaveChangesAsync();
        }
    }
}