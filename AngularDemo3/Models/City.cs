using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class City
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }

        public ICollection<Route> StartingRoutes { get; set; }

        public ICollection<Route> EndingRoutes { get; set; }

    }
}
