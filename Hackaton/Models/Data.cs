using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hackaton.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}