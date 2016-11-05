using System;

namespace Hackathon.Models
{
    public class LocationData
    {
        public int ShipId { get; set; }

        public float Longtitude { get; set; }

        public float Latitude { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Speed { get; set; }
    }
}