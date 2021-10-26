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
    public class CountryController : ControllerBase
    {
        private ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpPost]
        [Route("Save")]

        public IActionResult Save(Country country)
        {
            return Ok(_countryService.Save(country));
        }
        [HttpGet]
        [Route("GetAllCountry")]
        public IActionResult GetAllCities()
        {
            return Ok(_countryService.GetAllCountry());
        }
    }
}
