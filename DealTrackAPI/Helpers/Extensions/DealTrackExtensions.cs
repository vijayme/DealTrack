using DealTrackAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealTrackAPI.Helpers.Extensions
{
    public static class DealTrackExtensions
    {
        public static DealTrack ReadFromCsv(this DealTrack dealTrack, String datRow)
        {
            string[] values = datRow.SplitCSVRow();
            dealTrack.DealNumber = values[0];
            dealTrack.CustomerName = values[1];
            dealTrack.DealerShip = values[2];
            dealTrack.vechile = values[3];
            dealTrack.Price = values[4];
            dealTrack.Date = values[5];
            return dealTrack;
        }
    }
}
