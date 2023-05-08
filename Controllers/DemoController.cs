using DemoAppSettings.Settings;
using Microsoft.AspNetCore.Mvc;

namespace DemoAppSettings.Controllers;

[ApiController]
[Route("")]
public class WeatherForecastController : ControllerBase
{
    private readonly IPositionConfigurations positionConfigurations;
    public WeatherForecastController(IPositionConfigurations positionConfigurations)
    {
        this.positionConfigurations = positionConfigurations;
    }

    [HttpGet]
    public string Get() =>
        $" O { positionConfigurations.Name } is {positionConfigurations.Title }";
}
