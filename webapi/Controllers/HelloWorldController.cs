using Microsoft.AspNetCore.Mvc;
using webapi.Services;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;

    private readonly ILogger<WeatherForecastController> _logger;

    public HelloWorldController(ILogger<WeatherForecastController> logger, IHelloWorldService helloWorld)
    {
        _logger = logger;
        helloWorldService = helloWorld;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Se realiza el GET...");
        return Ok(helloWorldService.GetHelloWorld());
    }
}