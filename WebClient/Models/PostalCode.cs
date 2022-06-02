using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebClient.Models
{
    public class PostalCode
    {
        [JsonPropertyName("post code")]
        public string PostCode { get; set; }
        public string Country { get; set; }

        [JsonPropertyName("country abbreviation")]
        public string CountryAbbreviation { get; set; }
        public List<Places> Places { get; set; } = new List<Places>();
    }
}
