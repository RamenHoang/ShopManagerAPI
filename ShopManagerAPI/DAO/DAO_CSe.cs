using ShopManagerAPI.Database;
using ShopManagerAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagerAPI.DAO
{
    class CSeDAO
    {
        private SQLServer db;

        public CSeDAO()
        {
            db = new SQLServer();
        }

        public IEnumerable<ModelCSe> GetAll()
        {
            IEnumerable<ModelCSe> CSes = from item in db.CSe select item;
            return CSes;
        }
        public ModelCSe GetById(int id)
        {
            ModelCSe result = null;

            IEnumerable<ModelCSe> CSeQuery = from cse in db.CSe
                                             join cs in db.CS on cse.Id equals cs.IdCS
                                             where cse.Id == id
                                             select cse;

            //IEnumerable<DishModel> dishTemp = from d in db.dishes
            //                                  join f in db.foods on d.FoodId equals f.Id
            //                                  where d.Id == id
            //                                  select d;

            foreach (ModelCSe cse in CSeQuery)
            {
                result = cse;
            }

            return result;
        }
    }
}