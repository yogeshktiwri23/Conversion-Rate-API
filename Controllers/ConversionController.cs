using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{

    [Route("api/conversion")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _conversionService;

        public ConversionController(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        [HttpGet("convert")]
        public IActionResult ConvertUnits(double value, string fromUnit, string toUnit, string conversionType)
        {
            try
            {
                double result = _conversionService.ConvertUnits(value, fromUnit, toUnit, conversionType);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}

