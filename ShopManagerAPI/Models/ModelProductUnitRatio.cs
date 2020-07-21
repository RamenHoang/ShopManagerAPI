using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="ProductUnitRatio")]
    public class ModelProductUnitRatio
    {
        private EntityRef<ModelProductInfo> _ProductInfo = new EntityRef<ModelProductInfo>();
        private EntityRef<ModelProductUnit> _ProductUnit = new EntityRef<ModelProductUnit>();

        [Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "idUnit")]
        public int IdUnit { get; set; }

        [Column(Name = "idProduct")]
        public int IdProduct { get; set; }

        [Column(Name = "ratio", DbType = "float")]
        public float Ratio { get; set; }

        [Column(Name = "isBase")]
        public bool IsBase { get; set; }

        [Association(Name = MyConst.FK_PRODUCT_UNIT_RATIO_TO_PRODUCT_INFO, IsForeignKey = true, Storage = "_ProductInfo", ThisKey = "IdProduct")]
        public ModelProductInfo ProductUnit
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

        [Association(Name = MyConst.FK_PRODUCT_UNIT_RATIO_TO_PRODUCT_UNIT, IsForeignKey = true, Storage = "_ProductUnit", ThisKey = "IdUnit")]
        public ModelProductUnit SupplierInvoice
        {
            get
            {
                return this._ProductUnit.Entity;
            }
            set
            {
                this._ProductUnit.Entity = value;
            }
        }
    }
}