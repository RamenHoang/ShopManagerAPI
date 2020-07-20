using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using ShopManagerAPI.DAO;
using ShopManagerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.Controllers
{
    public class SellingController : ApiController
    {
        private CSeDAO _CSeDAO;
        public SellingController()
        {
            _CSeDAO = new CSeDAO();
        }
        // GET: api/Selling
        public String Get(int id)
        {
            ModelCSe all = _CSeDAO.GetById(id);
            List<ModelCSe> lst = (List<ModelCSe>)_CSeDAO.GetAll();
            //JsonResult jr = new JsonResult();
            //jr.Data = Json(all);
            //string json = new JavaScriptSerializer().Serialize(jr.Data);

            var data = JsonConvert.SerializeObject(lst, Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );

            return data;
        }

        public void Post([FromBody] string json)
        {
            ModelCSe cse = new JavaScriptSerializer().Deserialize<ModelCSe>(json);

            _CSeDAO.AddNewCse(cse);
        }

    }
}
