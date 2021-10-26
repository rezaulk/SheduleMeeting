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
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;

        }
        [HttpPost]
        [Route("Save")]

        public IActionResult Save(Company city)
        {
            return Ok(_companyService.Save(city));
        }
        [HttpGet]
        [Route("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            return Ok(_companyService.GetAllCompany());
        }
    }
}
