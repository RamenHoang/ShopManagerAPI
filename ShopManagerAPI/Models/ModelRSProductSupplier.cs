using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "RS_Product_Supplier")]
    public class ModelRSProductSupplier
    {
        private EntityRef<ModelSupplier> _Supplier = new EntityRef<ModelSupplier>();
        private EntityRef<ModelProductInfo> _ProductInfo = new EntityRef<ModelProductInfo>();

        [Column(Name = "", IsPrimaryKey = true)]
        public int? id;

        [Column(Name = "idSupplier")]
        public int? IdSupplier { get; set; }

        [Column(Name = "idProduct")]
        public int? IdProduct { get; set; }

        [Column(Name = "status")]
        public int? Status { get; set; }

        [Association(Name = MyConst.FK_RS_PRODUCT_SUPPLIER_TO_SUPPLIER, Storage = "_Supplier", IsForeignKey = true, ThisKey = "IdSupplier")]
        public ModelSupplier Supplier
        {
            get
            {
                return this._Supplier.Entity;
            }
            set
            {
                this._Supplier.Entity = value;
            }
        }

        [Association(Name = MyConst.FK_RS_PRODUCT_SUPPLIER_TO_PRODUCT_INFO, Storage = "_ProductInfo", ThisKey = "IdProduct", IsForeignKey = true)]
        public ModelProductInfo ProductInfo
        {
            get
            {
                return this._ProductInfo.Entity;
            }
            set
            {
                this._ProductInfo.Entity = value;
            }
        }
    }
}