using ShopManagerAPI.DAO;
using ShopManagerAPI.Helpers;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.Controllers
{
    [RoutePrefix("api/product_unit")]
    public class ProductUnitController : ApiController
    {
        DAO_ProductUnit ProductUnitDao = new DAO_ProductUnit();
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{id}")]
        // GET api/<controller>/5
        public string Get(int id)
        {
            ModelProductUnit data = ProductUnitDao.GetById(id);
            return JsonHelpers.stringify(data);
        }

        [Route("add")]
        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            ModelProductUnit product = new JavaScriptSerializer().Deserialize<ModelProductUnit>(value);
            ProductUnitDao.AddNewProductUnit(product);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}