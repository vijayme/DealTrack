using DealTrackAPI.Helpers.Decorators;
using DealTrackAPI.Helpers.Extensions;
using DealTrackAPI.Models;
using Decor;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealTrackAPI.Data
{
    public class DealTrackRepository
    {
        [Decorate(typeof(PriceDecorator))]
        public async Task<IEnumerable<DealTrack>> GetData()
        {
            try
            {
                return File.ReadAllLines("Dealertrack-CSV.csv")
                    .Skip(1)
                    .Select(v => new DealTrack().ReadFromCsv(v))
                    .ToList();
            }
            catch
            {
                return new List<DealTrack>();
            }
        }

        public void SaveData(IFormFile data)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(data.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(reader.ReadLine());
            }

            System.IO.File.AppendAllText(@"Dealertrack-CSV.csv", result.ToString());
        }
    }
}
