using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer.DTOs.Import
{
    public class ImportCarDto
    {

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("traveledDistance")]
        public long TraveledDistance { get; set; }

        [JsonProperty("partsId")]
        public ICollection<int> PartId { get; set; }
    }
}
