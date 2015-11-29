using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class Course
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual string CourseName { get; set; }

        public virtual string CoursePic { get; set; }

        public virtual int TeacherID { get; set; }

        [ForeignKey("TeacherID")]
        public virtual Teacher Teacher { get; set; }

        public virtual float Price { get; set; }

        public virtual DateTime StartDate { get; set; }

        //坐标
    }
}