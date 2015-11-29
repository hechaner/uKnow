using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class HotCity
    {
        [Key]
        public virtual int ID { get; set; }
                
        public virtual int CityID { get; set; }

        [ForeignKey("CityID")]
        public virtual City City { get; set; }
    }
}