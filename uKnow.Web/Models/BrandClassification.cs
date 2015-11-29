using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class BrandClassification
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual string Title { get; set; }

        public virtual int Style { get; set; }

        public virtual string Icon { get; set; }
    }
}