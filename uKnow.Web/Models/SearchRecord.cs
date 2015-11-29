using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace uKnow.Web.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SearchRecord
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public virtual int ID { get; set; }
        [JsonProperty(PropertyName = "title")]
        public virtual string KeyWord { get; set; }
        [JsonProperty(PropertyName = "count")]
        public virtual int Count { get; set; }
    }
}