using System.Collections.Generic;
using System.Linq;

namespace Hackathon.Models
{
    public class Ship
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public LocationData CurrentLocationData
        {
            get { return LocationDataHistory.Last(); } 
        }

        public List<LocationData> LocationDataHistory { get; set; }
    }
}