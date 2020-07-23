using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShopManagerAPI.DAO;
using ShopManagerAPI.Models;
using ShopManagerAPI.Helpers;
using System.Web.Script.Serialization;

namespace ShopManagerAPI.PrescriptionController
{
    [RoutePrefix("api/supplier")]
    public class PrescriptionController : ApiController
    {
        private DAO_Prescription PrescriptionDAO;

        public PrescriptionController()
        {
            PrescriptionDAO = new DAO_Prescription();
        }

        [Route("")]
        public string Get()
        {
            List<ModelPrescription> presciptions = PrescriptionDAO.GetAll();
            return JsonHelpers.stringify(presciptions);
        }

        [Route("{id}")]
        public string GetById(int id)
        {
            ModelPrescription presciption = PrescriptionDAO.GetById(id);
            return JsonHelpers.stringify(presciption);
        }

        [Route("")]
        public void Post([FromBody] string json)
        {
            ModelPrescription presciption = new JavaScriptSerializer().Deserialize<ModelPrescription>(json);
            PrescriptionDAO.AddNew(presciption);
        }
    }
}
