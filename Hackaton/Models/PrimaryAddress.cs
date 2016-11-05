using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class PrimaryAddress
    {
        public object CityTown { get; set; }
        public object Country { get; set; }
        public object FloorOrSuite { get; set; }
        public object Line1 { get; set; }
        public object Line2 { get; set; }
        public object Line3 { get; set; }
        public object PostZipCode { get; set; }
        public object StateCountyProvince { get; set; }
    }
}