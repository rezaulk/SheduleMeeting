using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScheduleMeeting.Entity;
using ScheduleMeeting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheduleMeeting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICityService _CityService;
        public CityController(ICityService cityService)
        {
            _CityService = cityService;

        }

        [HttpPost]
        [Route("Save")]

        public IActionResult Save(City city)
        {
            return Ok(_CityService.Save(city));
        }
        [HttpGet]
        [Route("GetAllCities")]
        public IActionResult GetAllCities()
        {
            return Ok(_CityService.GetAllCities());
        }
    }
}
