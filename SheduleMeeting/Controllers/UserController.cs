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
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("Save")]
        public IActionResult Save(User user)
        {
            return Ok(_userService.Save(user));
        }
        [HttpGet]
        [Route("GetAllUser")]
        public IActionResult GetAllCities()
        {
            return Ok(_userService.GetAllUser());
        }
    }
}
