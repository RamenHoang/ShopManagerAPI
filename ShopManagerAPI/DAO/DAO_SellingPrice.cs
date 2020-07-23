using ShopManagerAPI.Database;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.DAO
{

    public class DAO_SellingPrice
    {
        private SQLServer db;

        public DAO_SellingPrice()
        {
            db = SQLServer.getDB();
        }
        public ModelSellingPrice GetById(int id)
        {
            ModelSellingPrice productinfo = db.SellingPrice.First(p => p.Id == id);
            return productinfo;
        }

        public void AddNewSellingPrice(ModelSellingPrice value)
        {
            db.SellingPrice.InsertOnSubmit(value);
            db.SubmitChanges();
        }
    }
}