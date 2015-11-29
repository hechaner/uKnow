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
    public class City
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public virtual int ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public virtual string CityName { get; set; }

        //public virtual string Title { get; set; }

        //public virtual int CityType { get; set; }

        public virtual string Spell { get; set; }

        

        
    }
}