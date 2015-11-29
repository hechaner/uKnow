using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using uKnow.Web.APIModels;
using uKnow.Web.Models;

namespace uKnow.Web.Controllers
{
    public class CityController : ApiController
    {
        uKnowDataContext context = new uKnowDataContext();
        public object GetCities()
        {

            var list = new List<CityClassification>();
            var hotcitise = new CityClassification()
            {
                Title = "热门城市",
                Type = CityClassificationType.Likely,
                Cities = context.HotCities.Select(city => city.City).ToList()
            };
            list.Add(hotcitise);

            var groupCities = context.Citise.GroupBy(city => city.Spell.First())
                .Select(cities => new CityClassification()
                {
                    Title = char.ToUpper(cities.Key).ToString(),
                    Type = CityClassificationType.Normal,
                    Cities = cities.ToList()
                }).ToList();

            list.AddRange(groupCities);

            return new
            {
                items = list
            };
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}
