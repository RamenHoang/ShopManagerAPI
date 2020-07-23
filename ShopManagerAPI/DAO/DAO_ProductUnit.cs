using ShopManagerAPI.Database;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.DAO
{
    public class DAO_ProductUnit
    {
        private SQLServer db;

        public DAO_ProductUnit()
        {
            this.db = SQLServer.getDB();
        }

        public ModelProductUnit GetById(int id)
        {
            ModelProductUnit productUnit = db.ProductUnit.First(p => p.Id == id);
            return productUnit;
        }

        public void AddNewProductUnit(ModelProductUnit product)
        {
            db.ProductUnit.InsertOnSubmit(product);
            db.SubmitChanges();
        }
    }
}