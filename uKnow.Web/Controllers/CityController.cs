using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using uKnow.Web.APIModels;

namespace uKnow.Web.Controllers
{
    public class CityController : ApiController
    {
        public object GetCities()
        {
            return new
            {
                items = new List<CityClassification>
                {
                   
                }
            };
        }
    }
}
