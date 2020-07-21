using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ShopManagerAPI.Controllers
{
    [RoutePrefix("")]
    public class HomeController : ApiController
    {
        [Route("")]
        public string Get()
        {
            return "Welcom to Pharmacy";
        }
    }
}
