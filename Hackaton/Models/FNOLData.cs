using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class FNOLData
    {
        public string DeviceId { get; set; }
        public string PolicyId { get; set; }
        public string OracleId { get; set; }
        public List<Party> Parties { get; set; }
        public List<Data> Data { get; set; }
        public DateTime? TriggerDate { get; set; }
        public string TriggerLevel { get; set; }
        public string TriggerLeverDescription { get; set; }
        public string TriggerType { get; set; }
        public object CustomerId { get; set; }
    }
}