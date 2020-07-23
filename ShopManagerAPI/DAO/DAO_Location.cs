using System;
using System.Collections.Generic;
using ShopManagerAPI.Database;
using ShopManagerAPI.Models;
using System.Linq;

namespace ShopManagerAPI.DAO
{
    public class DAO_Location
    {
        private SQLServer db;

        public DAO_Location()
        {
            db = SQLServer.getDB();
        }

        public List<ModelLocation> GetAll()
        {
            List<ModelLocation> locations = (List<ModelLocation>)db.Location.Take(100);
            return locations;
        }

        public ModelLocation GetById(int id)
        {
            ModelLocation location = (ModelLocation)db.Location.First(i => i.Id == id);
            return location;
        }

        public void AddNew(ModelLocation location)
        {
            db.Location.InsertOnSubmit(location);
            db.SubmitChanges();
        }
    }
}
