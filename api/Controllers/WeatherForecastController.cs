using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]

public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("/blah")]
    public object Get()
    {
        return new Book("The Witcher - The Last Wish");

    }

    public class Book
    {
        public string Title { get; }

        public Book(string title)
        {
            Title = title;
        }
    }
}
