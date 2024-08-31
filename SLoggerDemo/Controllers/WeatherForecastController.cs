using Microsoft.AspNetCore.Mvc;

namespace SLoggerDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                _logger.LogTrace("This is a trace statement");
                _logger.LogInformation("This is a info statement");
                _logger.LogDebug("THis is a debug statement");
                _logger.LogWarning("This is a warning statement");
                _logger.LogError("This is a Error statement");
                _logger.LogCritical("This is a critical statement");

                int x = 10;
                int y = 0;

                int answer = x / y;
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Some error occurred");
            }

            return Ok("Logger statement is done");
        }
    }
}
