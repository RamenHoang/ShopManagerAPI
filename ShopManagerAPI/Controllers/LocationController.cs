using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShopManagerAPI.DAO;
using ShopManagerAPI.Models;
using ShopManagerAPI.Helpers;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.LocationController
{
    [RoutePrefix("api/location")]
    public class LocationController : ApiController
    {
        private DAO_Location LocationDAO;

        public LocationController()
        {
            LocationDAO = new DAO_Location();
        }

        [Route("")]
        public string Get()
        {
            List<ModelLocation> locations = LocationDAO.GetAll();
            return JsonHelpers.stringify(locations);
        }

        [Route("{id}")]
        public string GetById(int id)
        {
            ModelLocation location = LocationDAO.GetById(id);
            return JsonHelpers.stringify(location);
        }

        [Route("")]
        public void Post([FromBody] string json)
        {
            ModelLocation location = new JavaScriptSerializer().Deserialize<ModelLocation>(json);
            LocationDAO.AddNew(location);
        }
    }
}
