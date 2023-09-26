using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebApplication1.DabaseLayer;

namespace WebApplication1.Services
{
    public class ConversionService : IConversionService
    {
        private readonly ApplicationDbContext _dbContext;

        public ConversionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public double ConvertUnits(double value, string fromUnit, string toUnit, string conversionType)
        {
            var rates = _dbContext.ConversionRates.ToList(); // Retrieve all conversion rates to perform client-side evaluation

            var rateMetricToImperial = rates
                .FirstOrDefault(r => string.Equals(r.ConversionType, conversionType, StringComparison.OrdinalIgnoreCase) &&
                                     string.Equals(r.FromUnit, fromUnit, StringComparison.OrdinalIgnoreCase) &&
                                     string.Equals(r.ToUnit, toUnit, StringComparison.OrdinalIgnoreCase));

            var rateImperialToMetric = rates
                .FirstOrDefault(r => string.Equals(r.ConversionType, conversionType, StringComparison.OrdinalIgnoreCase) &&
                                     string.Equals(r.FromUnit, toUnit, StringComparison.OrdinalIgnoreCase) &&
                                     string.Equals(r.ToUnit, fromUnit, StringComparison.OrdinalIgnoreCase));

            if (rateMetricToImperial != null)
            {
                // Metric to Imperial conversion
                return value * rateMetricToImperial.Rate;
            }
            else if (rateImperialToMetric != null)
            {
                // Imperial to Metric conversion
                return value / rateImperialToMetric.Rate;
            }

            throw new ArgumentException("Conversion not supported.");
        }
    }

}
