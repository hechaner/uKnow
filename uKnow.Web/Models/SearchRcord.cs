using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class SearchRcord
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual string KeyWord { get; set; }

        public virtual int Count { get; set; }
    }
}