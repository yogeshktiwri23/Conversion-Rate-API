namespace WebApplication1.Services
{
    public interface IConversionService
    {
        double ConvertUnits(double value, string fromUnit, string toUnit, string conversionType);
    }

}
