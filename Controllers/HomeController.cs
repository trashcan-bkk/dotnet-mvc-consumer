using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using dotnet_mvc_consumer.Interfaces;
using dotnet_mvc_consumer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_mvc_consumer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHolidaysApiService _holidaysApiService;

        public HomeController(IHolidaysApiService holidaysApiService)
        {
            _holidaysApiService = holidaysApiService;
        }
        
        [HttpGet("Index/{countryCode}/{year}")]
        public async Task<IActionResult> Index(string countryCode, int year)
        {
            List<HolidayModel> holidays = new List<HolidayModel>();
            holidays = await _holidaysApiService.GetHolidays(countryCode, year);

            return View(holidays);
        }
    }
}
