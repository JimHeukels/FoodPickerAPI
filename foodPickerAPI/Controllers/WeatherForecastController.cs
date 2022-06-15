using foodPicker.Model;
using foodPicker.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace foodPickerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ReceptenService _service;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, ReceptenService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public List<Recept> Get()
        {
            return _service.GetRecepten();
        }
    }
}
