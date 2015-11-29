using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using uKnow.Web.Models;

namespace uKnow.Web.APIModels
{
    public class CityClassification
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "type")]
        public CityClassificationType Type { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IEnumerable<City> Cities { get; set; }
    }
}