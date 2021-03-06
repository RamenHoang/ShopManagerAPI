﻿using ShopManagerAPI.DAO;
using ShopManagerAPI.Helpers;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.Controllers
{

    [RoutePrefix("api/product")]
    public class ProductInfoController : ApiController
    {
        private DAO_ProductInfo ProductInfoDao;

        public ProductInfoController()
        {
            ProductInfoDao = new DAO_ProductInfo();
        }
        // GET api/<controller>

        [Route("{id}")]
        public string Get(int id)
        {
            ModelProductInfo data = ProductInfoDao.GetById(id);
            data.RSProductSuppliers.Assign(null);
            return JsonHelpers.stringify(data);
        }

        [Route("add")]
        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            ModelProductInfo product = new JavaScriptSerializer().Deserialize<ModelProductInfo>(value);
            ProductInfoDao.AddNewProduct(product);
        }


        [Route("update")]
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }


        [Route("delete/{id}")]
        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}