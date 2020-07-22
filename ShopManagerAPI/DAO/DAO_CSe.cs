using ShopManagerAPI.Database;
using ShopManagerAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagerAPI.DAO
{
    class CSeDAO
    {
        private SQLServer db;

        public CSeDAO()
        {
            db = SQLServer.getDB();
        }

        public List<ModelCSe> GetAll()
        {
            List<ModelCSe> CSes = (List<ModelCSe>)db.CSe.Take(100);
            return CSes;
        }
        public ModelCSe GetById(int id)
        {
            ModelCSe result = db.CSe.First(cse => cse.Id == id);
            return result;
        }

        public void AddNewCse(ModelCSe cse)
        {
            db.CSe.InsertOnSubmit(cse);
            db.SubmitChanges();
        }
    }
}