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
            db = new SQLServer();
        }

        public List<ModelCSe> GetAll()
        {
            List<ModelCSe> CSes = (List<ModelCSe>)db.CSe.Where(cse => cse.Id < 100).ToList();
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