using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task6
{
    public class Book
    {
        [JsonPropertyName("Title")]
        public string Name { get; set; }

        //public string Title { get; set; }
        public PublishingHouse publishingHouse { get; set; }

        //[JsonIgnore]
        public int PublishingHouseId { get; set; }
    }
}
