using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class Route
    {
        public Guid Id { get; set; }

        [Required]
        public Guid StartingPointId { get; set; }
        public City StartingPoint { get; set; }

        [Required]
        public Guid EndingPointId { get; set; }
        public City EndPoint { get; set; }

        public int Cost { get; set; }

        public TransportModes Mode { get; set; }
    }
}
