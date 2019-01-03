

namespace BookingTDD.Models
{
    using BookingTDD.Attributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class Booking
    {
        [Required]
        public string Origin { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public DateTime Departure { get; set; }

        [DateGreaterThan("Departure","Are Equals!")]
        public DateTime Return { get; set; }

        public bool IsRoudTrip { get; set; }

        public int Adult { get; set; }

        public int Child { get; set; }

        public int Infant { get; set; }
    }
}