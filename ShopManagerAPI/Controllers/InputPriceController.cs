using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShopManagerAPI.DAO;
using ShopManagerAPI.Models;
using ShopManagerAPI.Helpers;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.InputPriceController
{
    [RoutePrefix("api/inputprice")]
    public class InputPriceController : ApiController
    {
        private DAO_InputPrice InputPriceDAO;

        public InputPriceController()
        {
            InputPriceDAO = new DAO_InputPrice();
        }

        [Route("")]
        public string Get()
        {
            List<ModelInputPrice> inputPrices = InputPriceDAO.GetAll();
            return JsonHelpers.stringify(inputPrices);
        }

        [Route("{id}")]
        public string GetById(int id)
        {
            ModelInputPrice inputPrice = InputPriceDAO.GetById(id);
            return JsonHelpers.stringify(inputPrice);
        }

        [Route("")]
        public void Post([FromBody] string json)
        {
            ModelInputPrice inputPrice = new JavaScriptSerializer().Deserialize<ModelInputPrice>(json);
            InputPriceDAO.AddNew(inputPrice);
        }
    }
}