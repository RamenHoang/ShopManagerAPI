using ShopManagerAPI.Database;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.DAO
{
    public class DAO_Supplier
    {
        private SQLServer db;

        public DAO_Supplier()
        {
            this.db = SQLServer.getDB();
        }

        public ModelSupplier GetById(int id)
        {
            ModelSupplier supplier = db.Supplier.First(p => p.Id == id);
            return supplier;
        }

        public void AddNewSupplier(ModelSupplier supplier)
        {
            db.Supplier.InsertOnSubmit(supplier);
            db.SubmitChanges();
        }
    }
}