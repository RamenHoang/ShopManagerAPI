using System;
using System.Collections.Generic;
using System.Linq;
using ShopManagerAPI.Database;
using ShopManagerAPI.Models;

namespace ShopManagerAPI.DAO
{
    public class DAO_Prescription
    {
        private SQLServer db;

        public DAO_Prescription()
        {
            db = SQLServer.getDB();
        }

        public List<ModelPrescription> GetAll()
        {
            List<ModelPrescription> prescriptions = (List<ModelPrescription>)db.Prescription.Take(100);
            return prescriptions;
        }

        public ModelPrescription GetById(int id)
        {
            ModelPrescription prescription = db.Prescription.First(i => i.ID == id);
            return prescription;
        }

        public void AddNew(ModelPrescription prescription)
        {
            db.Prescription.InsertOnSubmit(prescription);
            db.SubmitChanges();
        }
    }
}
