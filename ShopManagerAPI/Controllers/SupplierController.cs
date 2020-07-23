using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShopManagerAPI.DAO;
using ShopManagerAPI.Models;
using ShopManagerAPI.Helpers;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.SupplierController
{
    [RoutePrefix("api/supplier")]
    public class SupplierController : ApiController
    {
        private DAO_Supplier SupplierDAO;

        public SupplierController()
        {
            SupplierDAO = new DAO_Supplier();
        }

        [Route("")]
        public string Get()
        {
            List<ModelSupplier> suppliers = SupplierDAO.GetAll();
            return JsonHelpers.stringify(suppliers);
        }

        [Route("{id}")]
        public string GetById(int id)
        {
            ModelSupplier supplier = SupplierDAO.GetById(id);
            return JsonHelpers.stringify(supplier);
        }

        [Route("")]
        public void Post([FromBody] string json)
        {
            ModelSupplier supplier = new JavaScriptSerializer().Deserialize<ModelSupplier>(json);
            SupplierDAO.AddNew(supplier);
        }
    }
}
