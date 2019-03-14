using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TourPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly TourGuideContext _context;

        public CitiesController(TourGuideContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Cities.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var city = _context.Cities.Where(c => c.Id == id);
            if(city == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(city);
            }
        }


    }
}