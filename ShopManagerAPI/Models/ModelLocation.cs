using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="Location")]
    public class ModelLocation
    {
        private EntitySet<ModelProductInfo> _ProductInfos = new EntitySet<ModelProductInfo>(); 

        [Column(Name = "id", IsPrimaryKey =true, IsDbGenerated =true)]
        public int? Id { get; set; }

        [Column(Name = "Location")]
        public string Location { get; set; }

        [Association(Name = MyConst.FK_PRODUCT_INFO_TO_LOCATION, Storage = "_ProductInfos", OtherKey = "IdLocation")]
        public EntitySet<ModelProductInfo> ProductInfos
        {
            get
            {
                return this._ProductInfos;
            }
            set
            {
                this._ProductInfos.Assign(value);
            }
        }
    }
}