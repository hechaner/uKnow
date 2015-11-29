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
            #region Brand Classification
            context.BrandClassifications.Add(new BrandClassification { ID = 1, Title = "推荐品牌", Style = 2, Icon = "" });
            context.BrandClassifications.Add(new BrandClassification { ID = 1, Title = "品牌机构", Style = 1, Icon = "" });
            context.BrandClassifications.Add(new BrandClassification { ID = 1, Title = "更多品牌", Style = 0, Icon = "" });
            #endregion

            #region Category
            #endregion

            #region Brand Type
            context.BrandTypes.Add(new BrandType { ID = 1, TypeName = "机构" });
            context.BrandTypes.Add(new BrandType { ID = 2, TypeName = "个人" });
            #endregion

            #region Teacher Type

            #endregion
        }
    }
}