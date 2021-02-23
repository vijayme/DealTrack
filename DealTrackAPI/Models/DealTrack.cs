using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DealTrackAPI.Helpers;

namespace DealTrackAPI.Models
{
    public class DealTrack
    {
        public string DealNumber { get; set; }
        public string CustomerName { get; set; }
        public string DealerShip { get; set; }
        public string vechile { get; set; }
        public string Price { get; set; }

        public string Date { get; set; } 
    }
}
