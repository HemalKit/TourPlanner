using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TourPlanner.Controllers
{
    [Route("api/city")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly TourGuideContext _context;

        public RoutesController(TourGuideContext context)
        {
            _context = context;
        }

        [HttpGet("{cityId}/route")]
        public IActionResult Get(Guid cityId)
        {
            var city = _context.Cities.FirstOrDefault(c => c.Id == cityId);

            if(city == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(_context.Routes.Where(r => r.StartingPoint.Id == city.Id || r.EndPoint.Id == city.Id));
            }
        }
    }
}