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
    [RoutePrefix("api/selling_price")]
    public class SellingPriceController : ApiController
    {
        private DAO_SellingPrice SellingPriceDao = new DAO_SellingPrice();
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("{id}")]
        // GET api/<controller>/5
        public string Get(int id)
        {
            ModelSellingPrice data = SellingPriceDao.GetById(id);
            return JsonHelpers.stringify(data);
        }

        [Route("add")]
        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            ModelSellingPrice product = new JavaScriptSerializer().Deserialize<ModelSellingPrice>(value);
            SellingPriceDao.AddNewSellingPrice(product);
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