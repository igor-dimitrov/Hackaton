using System.Collections.Generic;
using Hackathon.Models;

namespace Hackathon.ViewModels
{
    public class ShipsAndTerritoriesViewModel
    {
        public List<Ship> Ships { get; set; }

        public List<PirateTerritory> PirateTerritories { get; set; }
    }
}