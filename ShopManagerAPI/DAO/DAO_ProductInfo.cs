using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopManagerAPI.Database;
using ShopManagerAPI.Models;

namespace ShopManagerAPI.DAO
{
    public class DAO_ProductInfo
    {
        private SQLServer db;
        
        public DAO_ProductInfo()
        {
            db = SQLServer.getDB();
        }

        public ModelProductInfo GetById(int id)
        {
            ModelProductInfo productinfo = db.ProductInfo.First(p => p.Id == id);
            return productinfo;
        }

        public void AddNewProduct(ModelProductInfo product)
        {
            db.ProductInfo.InsertOnSubmit(product);
            db.SubmitChanges();
        }
    }
}