using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using uKnow.Web.Models;

namespace uKnow.Web.Controllers
{
    public class SearchController : ApiController
    {
        const int HotCount = 8;
        uKnowDataContext context = new uKnowDataContext();
        public object GetHotSearch()
        {
            return new
            {
                items = new 
                {
                    title = "热门搜索",
                    type = 1,
                    items = context.SearchRecords.OrderByDescending(record => record.Count).Take(HotCount).ToList()
                }
            };
        }

        public object GetSearch(string key)
        {
            return new
            {
                items = context.SearchRecords.Select(record => record.KeyWord.Contains(key)).ToList()
            };
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}
