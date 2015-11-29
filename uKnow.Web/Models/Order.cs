using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class Order
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual int CourseID { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }

        public virtual int UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public virtual DateTime CreatDateTime { get; set; }
    }
}