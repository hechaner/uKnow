using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace uKnow.Web.Models
{
    public class uKnowDBInitializer : DropCreateDatabaseAlways<uKnowDataContext>
    {
        protected override void Seed(uKnowDataContext context)
        {
            base.Seed(context);
        }
    }
}