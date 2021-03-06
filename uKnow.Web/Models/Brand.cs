﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class Brand
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual string BrandName { get; set; }

        public virtual string BrandLogo { get; set; }

        public virtual string BrandImg { get; set; }

        public virtual string BrandDesc { get; set; }

        public virtual int BrandTypeID { get; set; }

        [ForeignKey("BrandTypeID")]
        public virtual BrandType BrandType { get; set; }
    }
}