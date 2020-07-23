using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using ShopManagerAPI.DAO;
using ShopManagerAPI.Helpers;
using ShopManagerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.Controllers
{
    [RoutePrefix("api/selling")]
    public class SellingController : ApiController
    {
        private CSeDAO _CSeDAO;
        public SellingController()
        {
            _CSeDAO = new CSeDAO();
        }

        // DEFINE ROUTES API

        [Route("")]
        public string GetAll()
        {
            List<ModelCSe> lst = (List<ModelCSe>)_CSeDAO.GetAll();
            return JsonHelpers.stringify(lst);
        }

        [Route("{id}")]
        public string Get(int id)
        {
            ModelCSe queryCSe = _CSeDAO.GetById(id);
            return JsonHelpers.stringify(queryCSe);
        }

        [Route("add")]
        public void Post([FromBody] string json)
        {
            ModelCSe cse = new JavaScriptSerializer().Deserialize<ModelCSe>(json);
            _CSeDAO.AddNewCse(cse);
        }

    }
}
