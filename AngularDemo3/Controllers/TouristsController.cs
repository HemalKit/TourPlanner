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
    public class TouristsController : ControllerBase
    {
        private readonly TourGuideContext _context;

        public TouristsController(TourGuideContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Tourists.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var tourist = _context.Tourists.FirstOrDefault(t => t.Id == id);
            if(tourist == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(tourist);
            }
        }


    }
}