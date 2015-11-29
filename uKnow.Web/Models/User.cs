using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace uKnow.Web.Models
{
    public class User
    {
        [Key]
        public virtual int ID { get; set; }

        public virtual string UserName { get; set; }

        public virtual string UserIcon { get; set; }

        public virtual string Phone { get; set; }

        public virtual bool IsMale { get; set; }

        public virtual string Points { get; set; }

        //第三方账号绑定

        //关注

        //分销

        //人气

    }
}