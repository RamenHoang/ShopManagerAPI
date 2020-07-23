using System;
using System.Collections.Generic;
using System.Linq;
using ShopManagerAPI.Database;
using ShopManagerAPI.Models;

namespace ShopManagerAPI.DAO
{
    public class DAO_InputPrice
    {
        private SQLServer db;

        public DAO_InputPrice()
        {
            db = SQLServer.getDB();
        }

        public List<ModelInputPrice> GetAll()
        {
            List<ModelInputPrice> inputPrices = (List<ModelInputPrice>)db.InputPrice.Take(100);
            return inputPrices;
        }

        public ModelInputPrice GetById(int id)
        {
            ModelInputPrice inputPrice = db.InputPrice.First(i => i.Id == id);
            return inputPrice;
        }

        public void AddNew(ModelInputPrice inputPrice)
        {
            db.InputPrice.InsertOnSubmit(inputPrice);
            db.SubmitChanges();
        }
    }
}
