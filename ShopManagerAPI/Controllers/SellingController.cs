using Microsoft.Ajax.Utilities;
using ShopManagerAPI.DAO;
using ShopManagerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public string Get(int id)
        {
            ModelCSe all = _CSeDAO.GetById(id);
            string json = all.ToString();
            return json;
        }

    }
}
