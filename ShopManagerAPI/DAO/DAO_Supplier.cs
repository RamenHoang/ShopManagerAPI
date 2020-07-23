using System;
using System.Collections.Generic;
using ShopManagerAPI.Database;
using ShopManagerAPI.Models;
using System.Linq;

namespace ShopManagerAPI.DAO
{
    public class DAO_Supplier
    {
        private SQLServer db;

        public DAO_Supplier()
        {
            db = SQLServer.getDB();
        }

        public List<ModelSupplier> GetAll()
        {
            List<ModelSupplier> suppliers = (List<ModelSupplier>)db.Supplier.Take(100);
            return suppliers;
        }

        public ModelSupplier GetById(int id)
        {
            ModelSupplier supplier = db.Supplier.First(s => s.Id == id);
            return supplier;
        }

        public void AddNew(ModelSupplier supplier)
        {
            db.Supplier.InsertOnSubmit(supplier);
            db.SubmitChanges();
        }
    }
}
