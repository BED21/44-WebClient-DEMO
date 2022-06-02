using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebClient.Models
{
    public class Places
    {
        [JsonPropertyName("place name")]
        public string PlaceName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string State { get; set; }

        [JsonPropertyName("state abbreviation")]
        public string StateAbbreviation { get; set; }
    }
}
