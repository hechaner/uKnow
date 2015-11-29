using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class BrandBrandClassification
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual int BrandID { get; set; }

        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }

        public virtual int BrandClassificationID { get; set; }

        [ForeignKey("BrandClassificationID")]
        public virtual BrandClassification BrandClassification { get; set; }
    }
}