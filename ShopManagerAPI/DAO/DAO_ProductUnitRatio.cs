using ShopManagerAPI.Database;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.DAO
{
    public class DAO_ProductUnitRatio
    {
        private SQLServer db;
        public DAO_ProductUnitRatio()
        {
            db = SQLServer.getDB();
        }
        public ModelProductUnitRatio GetById(int id)
        {
            ModelProductUnitRatio productUnitRatio = db.ProductUnitRatio.First(p => p.Id == id);
            return productUnitRatio;
        }

        public void AddNewProductUnitRatio(ModelProductUnitRatio productUnitRatio)
        {
            db.ProductUnitRatio.InsertOnSubmit(productUnitRatio);
            db.SubmitChanges();
        }
    }
}