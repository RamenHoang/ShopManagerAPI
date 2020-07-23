using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ShopManagerAPI.Model;
using ShopManagerAPI.Const;
using Microsoft.Ajax.Utilities;
using ShopManagerAPI.Models;

namespace ShopManagerAPI.Database
{
    [Database]
    class SQLServer : DataContext
    {
        public Table<ModelCS> CS;
        public Table<ModelCSe> CSe;
        public Table<ModelProductInfo> ProductInfo;
        private static SQLServer DB = null;
        
        public SQLServer() : base(MyConst.connString)
        {

        }
        public static SQLServer getDB()
        {
            if(DB == null)
            {
                DB = new SQLServer();
            }

            return DB;
        }
    }
}
