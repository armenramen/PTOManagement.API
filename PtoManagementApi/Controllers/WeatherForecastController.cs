using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PtoManagement.Core.Services;

namespace PtoManagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly IPtoService _ptoService;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPtoService ptoService)
        {
            _logger = logger;
            _ptoService = ptoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ptoService.GetPtoRequestsAsync());
        }
    }
}
