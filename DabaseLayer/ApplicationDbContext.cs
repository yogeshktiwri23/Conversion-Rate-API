using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.DabaseLayer.Model;

namespace WebApplication1.DabaseLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ConversionRate> ConversionRates { get; set; }
    }

}
