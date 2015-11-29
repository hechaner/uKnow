using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class Teacher
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual string Name { get; set; }

        public virtual int TeacherTypeID { get; set; }

        [ForeignKey("TeacherTypeID")]
        public virtual TeacherType TeacherType { get; set; }

        //评分

        //认证

        //关注

        //位置、坐标
    }
}