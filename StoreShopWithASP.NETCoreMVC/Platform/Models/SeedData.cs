using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Platform.Models
{
    public class SeedData
    {
        private CalculationContext context;
        private ILogger<SeedData> logger;
        private static Dictionary<int, long> data = new Dictionary<int, long>()
        {
            { 1, 1 },
            { 2, 3 },
            { 3, 6 },
            { 4, 10 },
            { 5, 15 },
            { 6, 21 },
            { 7, 28 },
            { 8, 36 },
            { 9, 45 },
            { 10, 55 }
        };
        public SeedData(CalculationContext dataContext, ILogger<SeedData> log)
        {
            context = dataContext;
            logger = log;
        }
        public void SeedDatabase()
        {
            context.Database.Migrate();
            if (context.Calculations.Count() == 0)
            {
                logger.LogInformation("Preparing to seed database");
                context.Calculations!.AddRange(data.Select(v => new Calculation()
                {
                    Count = v.Key,
                    Result = v.Value
                }));
                context.SaveChanges();
                logger.LogInformation("Database seedd");
            }
            else logger.LogInformation("Database not seeded");
        }
    }
}
