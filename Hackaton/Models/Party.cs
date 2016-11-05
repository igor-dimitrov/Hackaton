using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Party
    {
        public object CustomerId { get; set; }
        public object Name { get; set; }
        public object Parent { get; set; }
        public PrimaryAddress PrimaryAddress { get; set; }
        public object PrimaryContact { get; set; }
        public object PrimaryContactEmail { get; set; }
        public object PrimaryContactPhone { get; set; }
        public object PrimarySector { get; set; }
        public object TechSector { get; set; }
        public object Type { get; set; }
    }
}