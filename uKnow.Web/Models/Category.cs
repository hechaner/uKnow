using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class Category
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual string CategoryName { get; set; }

        public virtual string Subtitle { get; set; }

        public virtual string CategoryIcon { get; set; }

        public virtual int ParentCategoryID { get; set; }

        [ForeignKey("TeacherID")]
        public virtual Category ParentCategory { get; set; }


    }
}