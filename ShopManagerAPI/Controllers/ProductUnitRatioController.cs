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
    [RoutePrefix("api/product_unit_ratio")]
    public class ProductUnitRatioController : ApiController
    {
        // GET api/<controller>
        DAO_ProductUnitRatio ProductUnitRatioDAO = new DAO_ProductUnitRatio();
 
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{id}")]
        // GET api/<controller>/5
        public string Get(int id)
        {
            ModelProductUnitRatio data = ProductUnitRatioDAO.GetById(id);
            return JsonHelpers.stringify(data);
        }

        [Route("add")]
        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            ModelProductUnitRatio product = new JavaScriptSerializer().Deserialize<ModelProductUnitRatio>(value);
            ProductUnitRatioDAO.AddNewProductUnitRatio(product);
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